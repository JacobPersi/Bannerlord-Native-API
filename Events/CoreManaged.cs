
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
    public static class CoreManaged {
    
    public delegate void StartDelegate();
    private static StartDelegate  _start;
    public static event StartDelegate Start {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["Start"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("Start" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _start += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "Start");
        }
    }
    private static void StartInternal() =>  CoreManaged. _start?.Invoke();
    
    public delegate void OnLoadCommonFinishedDelegate();
    private static OnLoadCommonFinishedDelegate  _onLoadCommonFinished;
    public static event OnLoadCommonFinishedDelegate OnLoadCommonFinished {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["OnLoadCommonFinished"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("OnLoadCommonFinished" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onLoadCommonFinished += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "OnLoadCommonFinished");
        }
    }
    private static void OnLoadCommonFinishedInternal() =>  CoreManaged. _onLoadCommonFinished?.Invoke();
    
    public delegate void FinalizeDelegate();
    private static FinalizeDelegate  _finalize;
    public static event FinalizeDelegate Finalize {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["Finalize"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("Finalize" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _finalize += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "Finalize");
        }
    }
    private static void FinalizeInternal() =>  CoreManaged. _finalize?.Invoke();
    
    public delegate void CheckSharedStructureSizesDelegate();
    private static CheckSharedStructureSizesDelegate  _checkSharedStructureSizes;
    public static event CheckSharedStructureSizesDelegate CheckSharedStructureSizes {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["CheckSharedStructureSizes"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("CheckSharedStructureSizes" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _checkSharedStructureSizes += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "CheckSharedStructureSizes");
        }
    }
    private static void CheckSharedStructureSizesInternal() =>  CoreManaged. _checkSharedStructureSizes?.Invoke();
    
    public delegate void EngineApiMethodInterfaceInitializerDelegate( Int32 id ,  IntPtr pointer );
    private static EngineApiMethodInterfaceInitializerDelegate  _engineApiMethodInterfaceInitializer;
    public static event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["EngineApiMethodInterfaceInitializer"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("EngineApiMethodInterfaceInitializer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _engineApiMethodInterfaceInitializer += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "EngineApiMethodInterfaceInitializer");
        }
    }
    private static void EngineApiMethodInterfaceInitializerInternal( Int32 id ,  IntPtr pointer ) =>  CoreManaged. _engineApiMethodInterfaceInitializer?.Invoke( id ,  pointer );
    
    public delegate void FillEngineApiPointersDelegate();
    private static FillEngineApiPointersDelegate  _fillEngineApiPointers;
    public static event FillEngineApiPointersDelegate FillEngineApiPointers {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CoreManaged"]["FillEngineApiPointers"].Method;
            MethodInfo patch = typeof(Native.Events.CoreManaged).GetMethod("FillEngineApiPointers" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _fillEngineApiPointers += value;
        }
        remove {
            NativeManager.UnHook("CoreManaged", "FillEngineApiPointers");
        }
    }
    private static void FillEngineApiPointersInternal() =>  CoreManaged. _fillEngineApiPointers?.Invoke();
    
    }
}