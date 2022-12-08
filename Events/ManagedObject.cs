
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
    public static class ManagedObject {
    
    public delegate Int32 GetAliveManagedObjectCountDelegate();
    private static GetAliveManagedObjectCountDelegate  _getAliveManagedObjectCount;
    public static event GetAliveManagedObjectCountDelegate GetAliveManagedObjectCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedObject"]["GetAliveManagedObjectCount"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedObject).GetMethod("GetAliveManagedObjectCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveManagedObjectCount += value;
        }
        remove {
            NativeManager.UnHook("ManagedObject", "GetAliveManagedObjectCount");
        }
    }
    private static Int32 GetAliveManagedObjectCountInternal() =>  (Int32)  ManagedObject. _getAliveManagedObjectCount?.Invoke();
    
    public delegate UIntPtr GetAliveManagedObjectNamesDelegate();
    private static GetAliveManagedObjectNamesDelegate  _getAliveManagedObjectNames;
    public static event GetAliveManagedObjectNamesDelegate GetAliveManagedObjectNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedObject"]["GetAliveManagedObjectNames"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedObject).GetMethod("GetAliveManagedObjectNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAliveManagedObjectNames += value;
        }
        remove {
            NativeManager.UnHook("ManagedObject", "GetAliveManagedObjectNames");
        }
    }
    private static UIntPtr GetAliveManagedObjectNamesInternal() =>  (UIntPtr)  ManagedObject. _getAliveManagedObjectNames?.Invoke();
    
    public delegate UIntPtr GetCreationCallstackDelegate( IntPtr name );
    private static GetCreationCallstackDelegate  _getCreationCallstack;
    public static event GetCreationCallstackDelegate GetCreationCallstack {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedObject"]["GetCreationCallstack"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedObject).GetMethod("GetCreationCallstack" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getCreationCallstack += value;
        }
        remove {
            NativeManager.UnHook("ManagedObject", "GetCreationCallstack");
        }
    }
    private static UIntPtr GetCreationCallstackInternal( IntPtr name ) =>  (UIntPtr)  ManagedObject. _getCreationCallstack?.Invoke( name );
    
    public delegate UIntPtr GetClassOfObjectDelegate( Int32 thisPointer );
    private static GetClassOfObjectDelegate  _getClassOfObject;
    public static event GetClassOfObjectDelegate GetClassOfObject {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedObject"]["GetClassOfObject"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedObject).GetMethod("GetClassOfObject" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getClassOfObject += value;
        }
        remove {
            NativeManager.UnHook("ManagedObject", "GetClassOfObject");
        }
    }
    private static UIntPtr GetClassOfObjectInternal( Int32 thisPointer ) =>  (UIntPtr)  ManagedObject. _getClassOfObject?.Invoke( thisPointer );
    
    }
}