
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
    public static class BannerlordTableauManager {
    
    public delegate void RequestCharacterTableauSetupDelegate( Int32 characterCodeId ,  NativeObjectPointer scene ,  NativeObjectPointer poseEntity );
    private static RequestCharacterTableauSetupDelegate  _requestCharacterTableauSetup;
    public static event RequestCharacterTableauSetupDelegate RequestCharacterTableauSetup {
        add {
            MethodInfo callback = NativeManager.InboundManifest["BannerlordTableauManager"]["RequestCharacterTableauSetup"].Method;
            MethodInfo patch = typeof(Native.Events.BannerlordTableauManager).GetMethod("RequestCharacterTableauSetup" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _requestCharacterTableauSetup += value;
        }
        remove {
            NativeManager.UnHook("BannerlordTableauManager", "RequestCharacterTableauSetup");
        }
    }
    private static void RequestCharacterTableauSetupInternal( Int32 characterCodeId ,  NativeObjectPointer scene ,  NativeObjectPointer poseEntity ) =>  BannerlordTableauManager. _requestCharacterTableauSetup?.Invoke( characterCodeId ,  scene ,  poseEntity );
    
    public delegate void RegisterCharacterTableauSceneDelegate( NativeObjectPointer scene ,  Int32 type );
    private static RegisterCharacterTableauSceneDelegate  _registerCharacterTableauScene;
    public static event RegisterCharacterTableauSceneDelegate RegisterCharacterTableauScene {
        add {
            MethodInfo callback = NativeManager.InboundManifest["BannerlordTableauManager"]["RegisterCharacterTableauScene"].Method;
            MethodInfo patch = typeof(Native.Events.BannerlordTableauManager).GetMethod("RegisterCharacterTableauScene" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _registerCharacterTableauScene += value;
        }
        remove {
            NativeManager.UnHook("BannerlordTableauManager", "RegisterCharacterTableauScene");
        }
    }
    private static void RegisterCharacterTableauSceneInternal( NativeObjectPointer scene ,  Int32 type ) =>  BannerlordTableauManager. _registerCharacterTableauScene?.Invoke( scene ,  type );
    
    }
}