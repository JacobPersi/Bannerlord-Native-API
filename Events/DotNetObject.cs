
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
    public static class DotNetObject {
    
    public delegate Int32 GetAliveDotNetObjectCountDelegate();
    private static GetAliveDotNetObjectCountDelegate  _getAliveDotNetObjectCount;
    public static event GetAliveDotNetObjectCountDelegate GetAliveDotNetObjectCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["DotNetObject"]["GetAliveDotNetObjectCount"].Method;
            MethodInfo patch = typeof(Native.Events.DotNetObject).GetMethod("GetAliveDotNetObjectCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveDotNetObjectCount += value;
        }
        remove {
            NativeManager.UnHook("DotNetObject", "GetAliveDotNetObjectCount");
        }
    }
    private static Int32 GetAliveDotNetObjectCountInternal() =>  (Int32)  DotNetObject. _getAliveDotNetObjectCount?.Invoke();
    
    public delegate void IncreaseReferenceCountDelegate( Int32 dotnetObjectId );
    private static IncreaseReferenceCountDelegate  _increaseReferenceCount;
    public static event IncreaseReferenceCountDelegate IncreaseReferenceCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["DotNetObject"]["IncreaseReferenceCount"].Method;
            MethodInfo patch = typeof(Native.Events.DotNetObject).GetMethod("IncreaseReferenceCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _increaseReferenceCount += value;
        }
        remove {
            NativeManager.UnHook("DotNetObject", "IncreaseReferenceCount");
        }
    }
    private static void IncreaseReferenceCountInternal( Int32 dotnetObjectId ) =>  DotNetObject. _increaseReferenceCount?.Invoke( dotnetObjectId );
    
    public delegate void DecreaseReferenceCountDelegate( Int32 dotnetObjectId );
    private static DecreaseReferenceCountDelegate  _decreaseReferenceCount;
    public static event DecreaseReferenceCountDelegate DecreaseReferenceCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["DotNetObject"]["DecreaseReferenceCount"].Method;
            MethodInfo patch = typeof(Native.Events.DotNetObject).GetMethod("DecreaseReferenceCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _decreaseReferenceCount += value;
        }
        remove {
            NativeManager.UnHook("DotNetObject", "DecreaseReferenceCount");
        }
    }
    private static void DecreaseReferenceCountInternal( Int32 dotnetObjectId ) =>  DotNetObject. _decreaseReferenceCount?.Invoke( dotnetObjectId );
    
    public delegate UIntPtr GetAliveDotNetObjectNamesDelegate();
    private static GetAliveDotNetObjectNamesDelegate  _getAliveDotNetObjectNames;
    public static event GetAliveDotNetObjectNamesDelegate GetAliveDotNetObjectNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["DotNetObject"]["GetAliveDotNetObjectNames"].Method;
            MethodInfo patch = typeof(Native.Events.DotNetObject).GetMethod("GetAliveDotNetObjectNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveDotNetObjectNames += value;
        }
        remove {
            NativeManager.UnHook("DotNetObject", "GetAliveDotNetObjectNames");
        }
    }
    private static UIntPtr GetAliveDotNetObjectNamesInternal() =>  (UIntPtr)  DotNetObject. _getAliveDotNetObjectNames?.Invoke();
    
    }
}