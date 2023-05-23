
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
    public static class EngineScreenManager {
    
    public delegate void PreTickDelegate( Single dt );
    private static PreTickDelegate  _preTick;
    public static event PreTickDelegate PreTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["PreTick"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("PreTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _preTick += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "PreTick");
        }
    }
    private static void PreTickInternal( Single dt ) =>  EngineScreenManager. _preTick?.Invoke( dt );
    
    public delegate void TickDelegate( Single dt );
    private static TickDelegate  _tick;
    public static event TickDelegate Tick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["Tick"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("Tick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _tick += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "Tick");
        }
    }
    private static void TickInternal( Single dt ) =>  EngineScreenManager. _tick?.Invoke( dt );
    
    public delegate void LateTickDelegate( Single dt );
    private static LateTickDelegate  _lateTick;
    public static event LateTickDelegate LateTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["LateTick"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("LateTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _lateTick += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "LateTick");
        }
    }
    private static void LateTickInternal( Single dt ) =>  EngineScreenManager. _lateTick?.Invoke( dt );
    
    public delegate void OnOnscreenKeyboardDoneDelegate( IntPtr inputText );
    private static OnOnscreenKeyboardDoneDelegate  _onOnscreenKeyboardDone;
    public static event OnOnscreenKeyboardDoneDelegate OnOnscreenKeyboardDone {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["OnOnscreenKeyboardDone"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("OnOnscreenKeyboardDone" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onOnscreenKeyboardDone += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "OnOnscreenKeyboardDone");
        }
    }
    private static void OnOnscreenKeyboardDoneInternal( IntPtr inputText ) =>  EngineScreenManager. _onOnscreenKeyboardDone?.Invoke( inputText );
    
    public delegate void OnOnscreenKeyboardCanceledDelegate();
    private static OnOnscreenKeyboardCanceledDelegate  _onOnscreenKeyboardCanceled;
    public static event OnOnscreenKeyboardCanceledDelegate OnOnscreenKeyboardCanceled {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["OnOnscreenKeyboardCanceled"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("OnOnscreenKeyboardCanceled" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onOnscreenKeyboardCanceled += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "OnOnscreenKeyboardCanceled");
        }
    }
    private static void OnOnscreenKeyboardCanceledInternal() =>  EngineScreenManager. _onOnscreenKeyboardCanceled?.Invoke();
    
    public delegate void OnGameWindowFocusChangeDelegate( Boolean focusGained );
    private static OnGameWindowFocusChangeDelegate  _onGameWindowFocusChange;
    public static event OnGameWindowFocusChangeDelegate OnGameWindowFocusChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["OnGameWindowFocusChange"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("OnGameWindowFocusChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onGameWindowFocusChange += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "OnGameWindowFocusChange");
        }
    }
    private static void OnGameWindowFocusChangeInternal( Boolean focusGained ) =>  EngineScreenManager. _onGameWindowFocusChange?.Invoke( focusGained );
    
    public delegate void UpdateDelegate();
    private static UpdateDelegate  _update;
    public static event UpdateDelegate Update {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["Update"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("Update" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _update += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "Update");
        }
    }
    private static void UpdateInternal() =>  EngineScreenManager. _update?.Invoke();
    
    public delegate void InitializeLastPressedKeysDelegate( NativeObjectPointer lastKeysPressed );
    private static InitializeLastPressedKeysDelegate  _initializeLastPressedKeys;
    public static event InitializeLastPressedKeysDelegate InitializeLastPressedKeys {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineScreenManager"]["InitializeLastPressedKeys"].Method;
            MethodInfo patch = typeof(Native.Events.EngineScreenManager).GetMethod("InitializeLastPressedKeys" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _initializeLastPressedKeys += value;
        }
        remove {
            NativeManager.UnHook("EngineScreenManager", "InitializeLastPressedKeys");
        }
    }
    private static void InitializeLastPressedKeysInternal( NativeObjectPointer lastKeysPressed ) =>  EngineScreenManager. _initializeLastPressedKeys?.Invoke( lastKeysPressed );
    
    }
}