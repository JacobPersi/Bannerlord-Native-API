using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BannerlordUnlocked {

    public static class CodeGen {

        public static bool GenerateCode = false;
        public static readonly string ScriptingInterfaceOutputDirectory = @"E:\Code\BannerlordUnlocked\Interfaces";
        public static readonly string EventsfaceOutputDirectory = @"E:\Code\BannerlordUnlocked\Events";

        public static string InterfaceName = string.Empty;
        public static string MethodBody = string.Empty;
        public static Dictionary<string, string> DelegateBody = new Dictionary<string, string>();

        public static void RegisterDelegate(Delegate target) {
            string interfaceName = target.Method.Name.Split('_').First();
            string delegateName = target.Method.Name.Split('_').Last();

            string paramsStringWithTypes = "", paramsStringWithoutTypes = "";
            foreach (var paramType in target.Method.GetParameters()) {
                string paramName = paramType.Name;
                string paramName2 = paramName;
                string typeName = paramType.ParameterType.Name;
                bool passByRef = typeName.Contains("&");
                if (passByRef) {
                    typeName = typeName.Replace("&", "");
                    typeName = $" ref {typeName}";
                }

                if (passByRef)
                    paramName2 = $"ref {paramName}";

                if (paramsStringWithTypes != "") paramsStringWithTypes += ", ";
                if (paramsStringWithoutTypes != "") paramsStringWithoutTypes += ", ";
                paramsStringWithTypes += $" {typeName} {paramName} ";
                paramsStringWithoutTypes += $" {paramName2} ";
            }

            string internalName = " _" + Char.ToLower(delegateName[0]) + delegateName.Substring(1);
            string eventName = delegateName.Replace("Delegate", "");

            string returnType = target.Method.ReturnType.Name;
            string returnCast = (returnType != "") ? $" ({returnType}) " : "";

            if (returnType.Contains("Void")) {
                returnType = returnType.Replace("Void", "void");
                returnCast = "";
            }

            delegateName += "Delegate";
            string code = $@"
    public delegate {returnType} {delegateName}({paramsStringWithTypes});
    private static {delegateName} {internalName};
    public static event {delegateName} {eventName} {{
        add {{
            MethodInfo callback = NativeManager.InboundManifest[""{interfaceName}""][""{eventName}""].Method;
            MethodInfo patch = typeof(Native.Events.{interfaceName}).GetMethod(""{eventName}"" + ""Internal"", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
            {internalName} += value;
        }}
        remove {{
            NativeManager.UnHook(""{interfaceName}"", ""{eventName}"");
        }}
    }}
    private static {returnType} {eventName}Internal({paramsStringWithTypes}) => {returnCast} {interfaceName}.{internalName}?.Invoke({paramsStringWithoutTypes});
    ";

            if (DelegateBody.ContainsKey(interfaceName))
                DelegateBody[interfaceName] += code;
            else DelegateBody[interfaceName] = code;
        }

        public static void WriteDelegates() {
            foreach (KeyValuePair<string, string> pair in DelegateBody) {
                var output = $@"
using System;
using System.Reflection;
using HarmonyLib;

using TaleWorlds.Library;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using static TaleWorlds.MountAndBlade.Agent;
using static TaleWorlds.MountAndBlade.Mission;

namespace BannerlordUnlocked.Native.Events {{
    public static class {pair.Key} {{
    {pair.Value}
    }}
}}";
                File.WriteAllText(EventsfaceOutputDirectory + "\\" + pair.Key + ".cs", output);
            }
            DelegateBody = new Dictionary<string, string>();
        }


        public static void GenerateOutboundNativeCall(string methodName, Delegate target) {
            if (InterfaceName != String.Empty) {

                string returnType = target.Method.ReturnType.Name;
                string returnCast = (returnType != "") ? $" ({returnType}) " : "";
                string returnKeyword = (returnType != "") ? " return " : "";

                if (returnType.Contains("Void")) {
                    returnType = returnType.Replace("Void", "void");
                    returnCast = "";
                    returnKeyword = "";
                }

                string paramsStringWithTypes = "", paramsStringWithoutTypes = "";
                foreach (var paramType in target.Method.GetParameters()) {
                    string paramName = paramType.Name;
                    string typeName = paramType.ParameterType.Name;
                    if (typeName.Contains("&")) {
                        typeName = typeName.Replace("&", "");
                        typeName = $" ref {typeName}";
                    }

                    if (paramsStringWithTypes != "") paramsStringWithTypes += ", ";
                    if (paramsStringWithoutTypes != "") paramsStringWithoutTypes += ", ";
                    paramsStringWithTypes += $" {typeName} {paramName} ";
                    paramsStringWithoutTypes += $" {paramName} ";
                }

                string code = $@"
    public static {returnType} {methodName}({paramsStringWithTypes}) {{
        {returnKeyword} {returnCast} NativeManager.OutboundManifest[""{InterfaceName}""][""{methodName}""]
        .DynamicInvoke(new object[] {{ {paramsStringWithoutTypes} }} );
    }}
";
                MethodBody += code;
            }
        }

        public static void StartFrame(string interfaceName) {
            InterfaceName = interfaceName;
            MethodBody = String.Empty;
        }

        public static void EndFrame() {
            var output = $@"
using System;
using TaleWorlds.Library;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using static TaleWorlds.Engine.GameEntity;
using static TaleWorlds.MountAndBlade.Agent;
using static TaleWorlds.MountAndBlade.CompressionInfo;
using static TaleWorlds.MountAndBlade.MBCommon;
using static TaleWorlds.MountAndBlade.GameNetwork;
using static TaleWorlds.Core.ArmorComponent;

namespace BannerlordUnlocked.Native {{
    public static class {InterfaceName} {{
    {MethodBody}
    }}
}}";
            File.WriteAllText(ScriptingInterfaceOutputDirectory + "\\" + InterfaceName + ".cs", output);
            InterfaceName = String.Empty;
            MethodBody = String.Empty;
        }
    }
}
