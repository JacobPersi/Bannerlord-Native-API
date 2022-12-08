
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
    public static class EngineController {
    
    public delegate void InitializeDelegate();
    private static InitializeDelegate  _initialize;
    public static event InitializeDelegate Initialize {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["Initialize"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("Initialize" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _initialize += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "Initialize");
        }
    }
    private static void InitializeInternal() =>  EngineController. _initialize?.Invoke();
    
    public delegate void OnConfigChangeDelegate();
    private static OnConfigChangeDelegate  _onConfigChange;
    public static event OnConfigChangeDelegate OnConfigChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["OnConfigChange"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("OnConfigChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onConfigChange += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "OnConfigChange");
        }
    }
    private static void OnConfigChangeInternal() =>  EngineController. _onConfigChange?.Invoke();
    
    public delegate void OnConstrainedStateChangeDelegate( Boolean isConstrained );
    private static OnConstrainedStateChangeDelegate  _onConstrainedStateChange;
    public static event OnConstrainedStateChangeDelegate OnConstrainedStateChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["OnConstrainedStateChange"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("OnConstrainedStateChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onConstrainedStateChange += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "OnConstrainedStateChange");
        }
    }
    private static void OnConstrainedStateChangeInternal( Boolean isConstrained ) =>  EngineController. _onConstrainedStateChange?.Invoke( isConstrained );
    
    public delegate UIntPtr GetVersionStrDelegate();
    private static GetVersionStrDelegate  _getVersionStr;
    public static event GetVersionStrDelegate GetVersionStr {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["GetVersionStr"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("GetVersionStr" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getVersionStr += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "GetVersionStr");
        }
    }
    private static UIntPtr GetVersionStrInternal() =>  (UIntPtr)  EngineController. _getVersionStr?.Invoke();
    
    public delegate UIntPtr GetApplicationPlatformNameDelegate();
    private static GetApplicationPlatformNameDelegate  _getApplicationPlatformName;
    public static event GetApplicationPlatformNameDelegate GetApplicationPlatformName {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["GetApplicationPlatformName"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("GetApplicationPlatformName" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getApplicationPlatformName += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "GetApplicationPlatformName");
        }
    }
    private static UIntPtr GetApplicationPlatformNameInternal() =>  (UIntPtr)  EngineController. _getApplicationPlatformName?.Invoke();
    
    public delegate UIntPtr GetModulesVersionStrDelegate();
    private static GetModulesVersionStrDelegate  _getModulesVersionStr;
    public static event GetModulesVersionStrDelegate GetModulesVersionStr {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["GetModulesVersionStr"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("GetModulesVersionStr" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getModulesVersionStr += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "GetModulesVersionStr");
        }
    }
    private static UIntPtr GetModulesVersionStrInternal() =>  (UIntPtr)  EngineController. _getModulesVersionStr?.Invoke();
    
    public delegate void OnControllerDisconnectionDelegate();
    private static OnControllerDisconnectionDelegate  _onControllerDisconnection;
    public static event OnControllerDisconnectionDelegate OnControllerDisconnection {
        add {
            MethodInfo callback = NativeManager.InboundManifest["EngineController"]["OnControllerDisconnection"].Method;
            MethodInfo patch = typeof(Native.Events.EngineController).GetMethod("OnControllerDisconnection" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onControllerDisconnection += value;
        }
        remove {
            NativeManager.UnHook("EngineController", "OnControllerDisconnection");
        }
    }
    private static void OnControllerDisconnectionInternal() =>  EngineController. _onControllerDisconnection?.Invoke();
    
    }
}