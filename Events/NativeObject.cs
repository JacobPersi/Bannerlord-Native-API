
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
    public static class NativeObject {
    
    public delegate Int32 GetAliveNativeObjectCountDelegate();
    private static GetAliveNativeObjectCountDelegate  _getAliveNativeObjectCount;
    public static event GetAliveNativeObjectCountDelegate GetAliveNativeObjectCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["NativeObject"]["GetAliveNativeObjectCount"].Method;
            MethodInfo patch = typeof(Native.Events.NativeObject).GetMethod("GetAliveNativeObjectCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveNativeObjectCount += value;
        }
        remove {
            NativeManager.UnHook("NativeObject", "GetAliveNativeObjectCount");
        }
    }
    private static Int32 GetAliveNativeObjectCountInternal() =>  (Int32)  NativeObject. _getAliveNativeObjectCount?.Invoke();
    
    public delegate UIntPtr GetAliveNativeObjectNamesDelegate();
    private static GetAliveNativeObjectNamesDelegate  _getAliveNativeObjectNames;
    public static event GetAliveNativeObjectNamesDelegate GetAliveNativeObjectNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["NativeObject"]["GetAliveNativeObjectNames"].Method;
            MethodInfo patch = typeof(Native.Events.NativeObject).GetMethod("GetAliveNativeObjectNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveNativeObjectNames += value;
        }
        remove {
            NativeManager.UnHook("NativeObject", "GetAliveNativeObjectNames");
        }
    }
    private static UIntPtr GetAliveNativeObjectNamesInternal() =>  (UIntPtr)  NativeObject. _getAliveNativeObjectNames?.Invoke();
    
    }
}