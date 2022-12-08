
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
    public static class WeaponComponentMissionExtensions {
    
    public delegate Vec3 CalculateCenterOfMassDelegate( NativeObjectPointer body );
    private static CalculateCenterOfMassDelegate  _calculateCenterOfMass;
    public static event CalculateCenterOfMassDelegate CalculateCenterOfMass {
        add {
            MethodInfo callback = NativeManager.InboundManifest["WeaponComponentMissionExtensions"]["CalculateCenterOfMass"].Method;
            MethodInfo patch = typeof(Native.Events.WeaponComponentMissionExtensions).GetMethod("CalculateCenterOfMass" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _calculateCenterOfMass += value;
        }
        remove {
            NativeManager.UnHook("WeaponComponentMissionExtensions", "CalculateCenterOfMass");
        }
    }
    private static Vec3 CalculateCenterOfMassInternal( NativeObjectPointer body ) =>  (Vec3)  WeaponComponentMissionExtensions. _calculateCenterOfMass?.Invoke( body );
    
    }
}