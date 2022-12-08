using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace BannerlordUnlocked {
    public static class NativeManager {

        public static string AppName => "BannerlordUnlocked";
        public static Dictionary<string, Dictionary<string, Delegate>> OutboundManifest = new Dictionary<string, Dictionary<string, Delegate>>();
        public static Dictionary<string, Dictionary<string, Delegate>> InboundManifest = new Dictionary<string, Dictionary<string, Delegate>>();

        private static Harmony _harmony = null;
        public static Harmony Harmony {
            get {
                if (_harmony == null)
                    _harmony = new Harmony(AppName);
                return _harmony;
            }
        }

        public static void CollectReferences(bool generateCode) {
            CodeGen.GenerateCode = generateCode;
            object clrHost = GetNativeHost("TaleWorlds.DotNet", "Managed");
            CollectOutboundDelegates(clrHost, ref NativeManager.OutboundManifest);
            GetInboundDelegates(clrHost, ref NativeManager.InboundManifest);

            object engineHost = GetNativeHost("TaleWorlds.Engine", "EngineManaged");
            CollectOutboundDelegates(engineHost, ref NativeManager.OutboundManifest);
            GetInboundDelegates(engineHost, ref NativeManager.InboundManifest);

            object gameHost = GetNativeHost("TaleWorlds.MountAndBlade", "CoreManaged");
            CollectOutboundDelegates(gameHost, ref NativeManager.OutboundManifest);
            GetInboundDelegates(gameHost, ref NativeManager.InboundManifest);
        }

        
        // Todo: This currently only looks for single-param constructors, may need adopting for TW classes that don't follow this paradigm:
        public static T ConstrutFromNativePointer<T>(UIntPtr pointer) {
            var constructors = typeof(T).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var constructor in constructors) {
                if (constructor.GetParameters().Length == 1 && constructor.GetParameters()[0].ParameterType == typeof(UIntPtr))
                    return (T)constructor.Invoke(new object[] { pointer });
            }
            return default(T);
        }

        public static UIntPtr GetNativePtr(object obj) {
            return (UIntPtr)obj.GetType().GetProperty("Pointer", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(obj);
        }

        public static void UnHook(string interfaceName, string methodName) {
            NativeManager.Harmony.Unpatch(NativeManager.InboundManifest[interfaceName][methodName].Method, HarmonyPatchType.Prefix);
        }

        static object GetNativeHost(string assemblyName, string managerClassName) {
            return Assembly.Load(assemblyName)
               .GetType(assemblyName + "." + managerClassName)
               .GetField("_callbackManager", BindingFlags.NonPublic | BindingFlags.Static)
               .GetValue(null);
        }

        static Dictionary<string, object> GetScriptingInterfaces(object nativeManager) {
            return nativeManager.GetType()
                .GetMethod("GetScriptingInterfaceObjects")
                .Invoke(nativeManager, new object[] { })
                as Dictionary<string, object>;
        }

        static void GetInboundDelegates(object nativeManager, ref Dictionary<string, Dictionary<string, Delegate>> Manifest) {
            Delegate[] delegates = nativeManager.GetType()
                .GetMethod("GetDelegates")
                .Invoke(nativeManager, new object[] { })
                as Delegate[];

            foreach (Delegate del in delegates) {
                string interfaceName = del.Method.Name.Split('_').First();
                string delegateName = del.Method.Name.Split('_').Last();

                if (Manifest.ContainsKey(interfaceName) == false) {
                    Manifest[interfaceName] = new Dictionary<string, Delegate>();
                }
                Manifest[interfaceName][delegateName] = del;

                if (CodeGen.GenerateCode)
                    CodeGen.RegisterDelegate(del);
            }
            CodeGen.WriteDelegates();

        }

        static void CollectOutboundDelegates(object nativeHost, ref Dictionary<string, Dictionary<string, Delegate>> Manifest) {
            Dictionary<string, object> scriptingInterfaces = GetScriptingInterfaces(nativeHost);
            foreach (KeyValuePair<string, object> scriptingInterface in scriptingInterfaces) {
                string interfaceName = scriptingInterface.Key.Split('.').Last();
                var fields = scriptingInterface.Value.GetType()
                    .GetFields(BindingFlags.Static | BindingFlags.Public)
                    .Where(field => field.Name.StartsWith("call_") && field.Name.EndsWith("Delegate"));

                if (CodeGen.GenerateCode)
                    CodeGen.StartFrame(interfaceName);

                if (fields.Any()) {
                    if (Manifest.ContainsKey(interfaceName) == false) {
                        Manifest[interfaceName] = new Dictionary<string, Delegate>();
                    }
                    foreach (var field in fields) {
                        string methodName = field.Name.Replace("call_", "").Replace("Delegate", "");
                        var del = (Delegate)field.GetValue(null);
                        Manifest[interfaceName][methodName] = del;

                        if (CodeGen.GenerateCode)
                            CodeGen.GenerateOutboundNativeCall(methodName, del);
                    }
                }
                if (CodeGen.GenerateCode)
                    CodeGen.EndFrame();
            }
        }
    }
}
