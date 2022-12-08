
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
    public static class EngineManaged {
    
    public delegate void EngineApiMethodInterfaceInitializerDelegate( Int32 id ,  IntPtr pointer );
    private static EngineApiMethodInterfaceInitializerDelegate  _engineApiMethodInterfaceInitializer;
    public static event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineManaged"]["EngineApiMethodInterfaceInitializer"].Method;
            MethodInfo patch = typeof(Native.Events.EngineManaged).GetMethod("EngineApiMethodInterfaceInitializer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _engineApiMethodInterfaceInitializer += value;
        }
        remove {
            NativeManager.UnHook("EngineManaged", "EngineApiMethodInterfaceInitializer");
        }
    }
    private static void EngineApiMethodInterfaceInitializerInternal( Int32 id ,  IntPtr pointer ) =>  EngineManaged. _engineApiMethodInterfaceInitializer?.Invoke( id ,  pointer );
    
    public delegate void CheckSharedStructureSizesDelegate();
    private static CheckSharedStructureSizesDelegate  _checkSharedStructureSizes;
    public static event CheckSharedStructureSizesDelegate CheckSharedStructureSizes {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineManaged"]["CheckSharedStructureSizes"].Method;
            MethodInfo patch = typeof(Native.Events.EngineManaged).GetMethod("CheckSharedStructureSizes" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _checkSharedStructureSizes += value;
        }
        remove {
            NativeManager.UnHook("EngineManaged", "CheckSharedStructureSizes");
        }
    }
    private static void CheckSharedStructureSizesInternal() =>  EngineManaged. _checkSharedStructureSizes?.Invoke();
    
    public delegate void FillEngineApiPointersDelegate();
    private static FillEngineApiPointersDelegate  _fillEngineApiPointers;
    public static event FillEngineApiPointersDelegate FillEngineApiPointers {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineManaged"]["FillEngineApiPointers"].Method;
            MethodInfo patch = typeof(Native.Events.EngineManaged).GetMethod("FillEngineApiPointers" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _fillEngineApiPointers += value;
        }
        remove {
            NativeManager.UnHook("EngineManaged", "FillEngineApiPointers");
        }
    }
    private static void FillEngineApiPointersInternal() =>  EngineManaged. _fillEngineApiPointers?.Invoke();
    
    }
}