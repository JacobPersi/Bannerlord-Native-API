
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
    public static class SceneProblemChecker {
    
    public delegate Boolean OnCheckForSceneProblemsDelegate( NativeObjectPointer scene );
    private static OnCheckForSceneProblemsDelegate  _onCheckForSceneProblems;
    public static event OnCheckForSceneProblemsDelegate OnCheckForSceneProblems {
        add {
            MethodInfo callback = NativeManager.InboundManifest["SceneProblemChecker"]["OnCheckForSceneProblems"].Method;
            MethodInfo patch = typeof(Native.Events.SceneProblemChecker).GetMethod("OnCheckForSceneProblems" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onCheckForSceneProblems += value;
        }
        remove {
            NativeManager.UnHook("SceneProblemChecker", "OnCheckForSceneProblems");
        }
    }
    private static Boolean OnCheckForSceneProblemsInternal( NativeObjectPointer scene ) =>  (Boolean)  SceneProblemChecker. _onCheckForSceneProblems?.Invoke( scene );
    
    }
}