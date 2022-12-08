
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
    public static class CrashInformationCollector {
    
    public delegate UIntPtr CollectInformationDelegate();
    private static CollectInformationDelegate  _collectInformation;
    public static event CollectInformationDelegate CollectInformation {
        add {
            MethodInfo callback = NativeManager.InboundManifest["CrashInformationCollector"]["CollectInformation"].Method;
            MethodInfo patch = typeof(Native.Events.CrashInformationCollector).GetMethod("CollectInformation" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _collectInformation += value;
        }
        remove {
            NativeManager.UnHook("CrashInformationCollector", "CollectInformation");
        }
    }
    private static UIntPtr CollectInformationInternal() =>  (UIntPtr)  CrashInformationCollector. _collectInformation?.Invoke();
    
    }
}