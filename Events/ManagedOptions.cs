
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

namespace BannerlordUnlocked.Native.Events {
    public static class ManagedOptions {
    
    public delegate Int32 GetConfigCountDelegate();
    private static GetConfigCountDelegate  _getConfigCount;
    public static event GetConfigCountDelegate GetConfigCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedOptions"]["GetConfigCount"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedOptions).GetMethod("GetConfigCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getConfigCount += value;
        }
        remove {
            NativeManager.UnHook("ManagedOptions", "GetConfigCount");
        }
    }
    private static Int32 GetConfigCountInternal() =>  (Int32)  ManagedOptions. _getConfigCount?.Invoke();
    
    public delegate Single GetConfigValueDelegate( Int32 type );
    private static GetConfigValueDelegate  _getConfigValue;
    public static event GetConfigValueDelegate GetConfigValue {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedOptions"]["GetConfigValue"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedOptions).GetMethod("GetConfigValue" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getConfigValue += value;
        }
        remove {
            NativeManager.UnHook("ManagedOptions", "GetConfigValue");
        }
    }
    private static Single GetConfigValueInternal( Int32 type ) =>  (Single)  ManagedOptions. _getConfigValue?.Invoke( type );
    
    }
}