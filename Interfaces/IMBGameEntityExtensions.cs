
using System;
using TaleWorlds.Library;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using static TaleWorlds.Engine.GameEntity;
using static TaleWorlds.MountAndBlade.Agent;
using static TaleWorlds.MountAndBlade.CompressionInfo;
using static TaleWorlds.MountAndBlade.MBCommon;
using static TaleWorlds.MountAndBlade.GameNetwork;
using static TaleWorlds.Core.ArmorComponent;

namespace BannerlordUnlocked.Native {
    public static class IMBGameEntityExtensions {
    
    public static NativeObjectPointer CreateFromWeapon( UIntPtr scenePointer ,   ref WeaponDataAsNative weaponData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,   ref WeaponDataAsNative ammoWeaponData ,  IntPtr ammoWeaponStatsData ,  Int32 ammoWeaponStatsDataLength ,  Boolean showHolsterWithWeapon ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBGameEntityExtensions"]["CreateFromWeapon"]
        .DynamicInvoke(new object[] {  scenePointer ,  weaponData ,  weaponStatsData ,  weaponStatsDataLength ,  ammoWeaponData ,  ammoWeaponStatsData ,  ammoWeaponStatsDataLength ,  showHolsterWithWeapon  } );
    }

    public static void FadeOut( UIntPtr entityPointer ,  Single interval ,  Boolean isRemovingFromScene ) {
          NativeManager.OutboundManifest["IMBGameEntityExtensions"]["FadeOut"]
        .DynamicInvoke(new object[] {  entityPointer ,  interval ,  isRemovingFromScene  } );
    }

    public static void FadeIn( UIntPtr entityPointer ,  Boolean resetAlpha ) {
          NativeManager.OutboundManifest["IMBGameEntityExtensions"]["FadeIn"]
        .DynamicInvoke(new object[] {  entityPointer ,  resetAlpha  } );
    }

    public static void HideIfNotFadingOut( UIntPtr entityPointer ) {
          NativeManager.OutboundManifest["IMBGameEntityExtensions"]["HideIfNotFadingOut"]
        .DynamicInvoke(new object[] {  entityPointer  } );
    }

    public static void UpdateTrajectoryVisualizerForSpawner( UIntPtr gameEntity ,  Single maxShootSpeed ,  Single minShootSpeed ,  Single maxAngle ,  Single minAngle ,  Single turnAngle ,  Single frictionCoefficient ) {
          NativeManager.OutboundManifest["IMBGameEntityExtensions"]["UpdateTrajectoryVisualizerForSpawner"]
        .DynamicInvoke(new object[] {  gameEntity ,  maxShootSpeed ,  minShootSpeed ,  maxAngle ,  minAngle ,  turnAngle ,  frictionCoefficient  } );
    }

    }
}