
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
    public static class Agent {
    
    public delegate void SetAgentAIPerformingRetreatBehaviorDelegate( Int32 thisPointer ,  Boolean isAgentAIPerformingRetreatBehavior );
    private static SetAgentAIPerformingRetreatBehaviorDelegate  _setAgentAIPerformingRetreatBehavior;
    public static event SetAgentAIPerformingRetreatBehaviorDelegate SetAgentAIPerformingRetreatBehavior {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["SetAgentAIPerformingRetreatBehavior"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("SetAgentAIPerformingRetreatBehavior" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setAgentAIPerformingRetreatBehavior += value;
        }
        remove {
            NativeManager.UnHook("Agent", "SetAgentAIPerformingRetreatBehavior");
        }
    }
    private static void SetAgentAIPerformingRetreatBehaviorInternal( Int32 thisPointer ,  Boolean isAgentAIPerformingRetreatBehavior ) =>  Agent. _setAgentAIPerformingRetreatBehavior?.Invoke( thisPointer ,  isAgentAIPerformingRetreatBehavior );
    
    public delegate Single GetMissileRangeWithHeightDifferenceAuxDelegate( Int32 thisPointer ,  Single targetZ );
    private static GetMissileRangeWithHeightDifferenceAuxDelegate  _getMissileRangeWithHeightDifferenceAux;
    public static event GetMissileRangeWithHeightDifferenceAuxDelegate GetMissileRangeWithHeightDifferenceAux {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["GetMissileRangeWithHeightDifferenceAux"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("GetMissileRangeWithHeightDifferenceAux" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getMissileRangeWithHeightDifferenceAux += value;
        }
        remove {
            NativeManager.UnHook("Agent", "GetMissileRangeWithHeightDifferenceAux");
        }
    }
    private static Single GetMissileRangeWithHeightDifferenceAuxInternal( Int32 thisPointer ,  Single targetZ ) =>  (Single)  Agent. _getMissileRangeWithHeightDifferenceAux?.Invoke( thisPointer ,  targetZ );
    
    public delegate Int32 GetFormationUnitSpacingDelegate( Int32 thisPointer );
    private static GetFormationUnitSpacingDelegate  _getFormationUnitSpacing;
    public static event GetFormationUnitSpacingDelegate GetFormationUnitSpacing {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["GetFormationUnitSpacing"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("GetFormationUnitSpacing" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getFormationUnitSpacing += value;
        }
        remove {
            NativeManager.UnHook("Agent", "GetFormationUnitSpacing");
        }
    }
    private static Int32 GetFormationUnitSpacingInternal( Int32 thisPointer ) =>  (Int32)  Agent. _getFormationUnitSpacing?.Invoke( thisPointer );
    
    public delegate UIntPtr GetSoundAndCollisionInfoClassNameDelegate( Int32 thisPointer );
    private static GetSoundAndCollisionInfoClassNameDelegate  _getSoundAndCollisionInfoClassName;
    public static event GetSoundAndCollisionInfoClassNameDelegate GetSoundAndCollisionInfoClassName {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["GetSoundAndCollisionInfoClassName"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("GetSoundAndCollisionInfoClassName" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getSoundAndCollisionInfoClassName += value;
        }
        remove {
            NativeManager.UnHook("Agent", "GetSoundAndCollisionInfoClassName");
        }
    }
    private static UIntPtr GetSoundAndCollisionInfoClassNameInternal( Int32 thisPointer ) =>  (UIntPtr)  Agent. _getSoundAndCollisionInfoClassName?.Invoke( thisPointer );
    
    public delegate Boolean IsInSameFormationWithDelegate( Int32 thisPointer ,  Int32 otherAgent );
    private static IsInSameFormationWithDelegate  _isInSameFormationWith;
    public static event IsInSameFormationWithDelegate IsInSameFormationWith {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["IsInSameFormationWith"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("IsInSameFormationWith" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _isInSameFormationWith += value;
        }
        remove {
            NativeManager.UnHook("Agent", "IsInSameFormationWith");
        }
    }
    private static Boolean IsInSameFormationWithInternal( Int32 thisPointer ,  Int32 otherAgent ) =>  (Boolean)  Agent. _isInSameFormationWith?.Invoke( thisPointer ,  otherAgent );
    
    public delegate void OnWeaponSwitchingToAlternativeStartDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 usageIndex );
    private static OnWeaponSwitchingToAlternativeStartDelegate  _onWeaponSwitchingToAlternativeStart;
    public static event OnWeaponSwitchingToAlternativeStartDelegate OnWeaponSwitchingToAlternativeStart {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponSwitchingToAlternativeStart"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponSwitchingToAlternativeStart" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponSwitchingToAlternativeStart += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponSwitchingToAlternativeStart");
        }
    }
    private static void OnWeaponSwitchingToAlternativeStartInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 usageIndex ) =>  Agent. _onWeaponSwitchingToAlternativeStart?.Invoke( thisPointer ,  slotIndex ,  usageIndex );
    
    public delegate void OnWeaponReloadPhaseChangeDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 reloadPhase );
    private static OnWeaponReloadPhaseChangeDelegate  _onWeaponReloadPhaseChange;
    public static event OnWeaponReloadPhaseChangeDelegate OnWeaponReloadPhaseChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponReloadPhaseChange"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponReloadPhaseChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponReloadPhaseChange += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponReloadPhaseChange");
        }
    }
    private static void OnWeaponReloadPhaseChangeInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 reloadPhase ) =>  Agent. _onWeaponReloadPhaseChange?.Invoke( thisPointer ,  slotIndex ,  reloadPhase );
    
    public delegate void OnWeaponAmmoReloadDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  EquipmentIndex ammoSlotIndex ,  Int16 totalAmmo );
    private static OnWeaponAmmoReloadDelegate  _onWeaponAmmoReload;
    public static event OnWeaponAmmoReloadDelegate OnWeaponAmmoReload {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponAmmoReload"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponAmmoReload" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponAmmoReload += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponAmmoReload");
        }
    }
    private static void OnWeaponAmmoReloadInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  EquipmentIndex ammoSlotIndex ,  Int16 totalAmmo ) =>  Agent. _onWeaponAmmoReload?.Invoke( thisPointer ,  slotIndex ,  ammoSlotIndex ,  totalAmmo );
    
    public delegate void OnWeaponAmmoConsumeDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 totalAmmo );
    private static OnWeaponAmmoConsumeDelegate  _onWeaponAmmoConsume;
    public static event OnWeaponAmmoConsumeDelegate OnWeaponAmmoConsume {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponAmmoConsume"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponAmmoConsume" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponAmmoConsume += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponAmmoConsume");
        }
    }
    private static void OnWeaponAmmoConsumeInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 totalAmmo ) =>  Agent. _onWeaponAmmoConsume?.Invoke( thisPointer ,  slotIndex ,  totalAmmo );
    
    public delegate void OnShieldDamagedDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 inflictedDamage );
    private static OnShieldDamagedDelegate  _onShieldDamaged;
    public static event OnShieldDamagedDelegate OnShieldDamaged {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnShieldDamaged"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnShieldDamaged" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onShieldDamaged += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnShieldDamaged");
        }
    }
    private static void OnShieldDamagedInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 inflictedDamage ) =>  Agent. _onShieldDamaged?.Invoke( thisPointer ,  slotIndex ,  inflictedDamage );
    
    public delegate void OnWeaponAmmoRemovedDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex );
    private static OnWeaponAmmoRemovedDelegate  _onWeaponAmmoRemoved;
    public static event OnWeaponAmmoRemovedDelegate OnWeaponAmmoRemoved {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponAmmoRemoved"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponAmmoRemoved" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponAmmoRemoved += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponAmmoRemoved");
        }
    }
    private static void OnWeaponAmmoRemovedInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ) =>  Agent. _onWeaponAmmoRemoved?.Invoke( thisPointer ,  slotIndex );
    
    public delegate void OnMountDelegate( Int32 thisPointer ,  Int32 mount );
    private static OnMountDelegate  _onMount;
    public static event OnMountDelegate OnMount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnMount"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnMount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onMount += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnMount");
        }
    }
    private static void OnMountInternal( Int32 thisPointer ,  Int32 mount ) =>  Agent. _onMount?.Invoke( thisPointer ,  mount );
    
    public delegate void OnDismountDelegate( Int32 thisPointer ,  Int32 mount );
    private static OnDismountDelegate  _onDismount;
    public static event OnDismountDelegate OnDismount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnDismount"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnDismount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onDismount += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnDismount");
        }
    }
    private static void OnDismountInternal( Int32 thisPointer ,  Int32 mount ) =>  Agent. _onDismount?.Invoke( thisPointer ,  mount );
    
    public delegate void OnAgentAlarmedStateChangedDelegate( Int32 thisPointer ,  AIStateFlag flag );
    private static OnAgentAlarmedStateChangedDelegate  _onAgentAlarmedStateChanged;
    public static event OnAgentAlarmedStateChangedDelegate OnAgentAlarmedStateChanged {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnAgentAlarmedStateChanged"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnAgentAlarmedStateChanged" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentAlarmedStateChanged += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnAgentAlarmedStateChanged");
        }
    }
    private static void OnAgentAlarmedStateChangedInternal( Int32 thisPointer ,  AIStateFlag flag ) =>  Agent. _onAgentAlarmedStateChanged?.Invoke( thisPointer ,  flag );
    
    public delegate void OnRetreatingDelegate( Int32 thisPointer );
    private static OnRetreatingDelegate  _onRetreating;
    public static event OnRetreatingDelegate OnRetreating {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnRetreating"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnRetreating" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onRetreating += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnRetreating");
        }
    }
    private static void OnRetreatingInternal( Int32 thisPointer ) =>  Agent. _onRetreating?.Invoke( thisPointer );
    
    public delegate void UpdateMountAgentCacheDelegate( Int32 thisPointer ,  Int32 newMountAgent );
    private static UpdateMountAgentCacheDelegate  _updateMountAgentCache;
    public static event UpdateMountAgentCacheDelegate UpdateMountAgentCache {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["UpdateMountAgentCache"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("UpdateMountAgentCache" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _updateMountAgentCache += value;
        }
        remove {
            NativeManager.UnHook("Agent", "UpdateMountAgentCache");
        }
    }
    private static void UpdateMountAgentCacheInternal( Int32 thisPointer ,  Int32 newMountAgent ) =>  Agent. _updateMountAgentCache?.Invoke( thisPointer ,  newMountAgent );
    
    public delegate void UpdateRiderAgentCacheDelegate( Int32 thisPointer ,  Int32 newRiderAgent );
    private static UpdateRiderAgentCacheDelegate  _updateRiderAgentCache;
    public static event UpdateRiderAgentCacheDelegate UpdateRiderAgentCache {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["UpdateRiderAgentCache"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("UpdateRiderAgentCache" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _updateRiderAgentCache += value;
        }
        remove {
            NativeManager.UnHook("Agent", "UpdateRiderAgentCache");
        }
    }
    private static void UpdateRiderAgentCacheInternal( Int32 thisPointer ,  Int32 newRiderAgent ) =>  Agent. _updateRiderAgentCache?.Invoke( thisPointer ,  newRiderAgent );
    
    public delegate void UpdateAgentStatsDelegate( Int32 thisPointer );
    private static UpdateAgentStatsDelegate  _updateAgentStats;
    public static event UpdateAgentStatsDelegate UpdateAgentStats {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["UpdateAgentStats"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("UpdateAgentStats" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _updateAgentStats += value;
        }
        remove {
            NativeManager.UnHook("Agent", "UpdateAgentStats");
        }
    }
    private static void UpdateAgentStatsInternal( Int32 thisPointer ) =>  Agent. _updateAgentStats?.Invoke( thisPointer );
    
    public delegate Single GetWeaponInaccuracyDelegate( Int32 thisPointer ,  EquipmentIndex weaponSlotIndex ,  Int32 weaponUsageIndex );
    private static GetWeaponInaccuracyDelegate  _getWeaponInaccuracy;
    public static event GetWeaponInaccuracyDelegate GetWeaponInaccuracy {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["GetWeaponInaccuracy"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("GetWeaponInaccuracy" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getWeaponInaccuracy += value;
        }
        remove {
            NativeManager.UnHook("Agent", "GetWeaponInaccuracy");
        }
    }
    private static Single GetWeaponInaccuracyInternal( Int32 thisPointer ,  EquipmentIndex weaponSlotIndex ,  Int32 weaponUsageIndex ) =>  (Single)  Agent. _getWeaponInaccuracy?.Invoke( thisPointer ,  weaponSlotIndex ,  weaponUsageIndex );
    
    public delegate Single DebugGetHealthDelegate( Int32 thisPointer );
    private static DebugGetHealthDelegate  _debugGetHealth;
    public static event DebugGetHealthDelegate DebugGetHealth {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["DebugGetHealth"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("DebugGetHealth" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _debugGetHealth += value;
        }
        remove {
            NativeManager.UnHook("Agent", "DebugGetHealth");
        }
    }
    private static Single DebugGetHealthInternal( Int32 thisPointer ) =>  (Single)  Agent. _debugGetHealth?.Invoke( thisPointer );
    
    public delegate void OnWieldedItemIndexChangeDelegate( Int32 thisPointer ,  Boolean isOffHand ,  Boolean isWieldedInstantly ,  Boolean isWieldedOnSpawn );
    private static OnWieldedItemIndexChangeDelegate  _onWieldedItemIndexChange;
    public static event OnWieldedItemIndexChangeDelegate OnWieldedItemIndexChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWieldedItemIndexChange"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWieldedItemIndexChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWieldedItemIndexChange += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWieldedItemIndexChange");
        }
    }
    private static void OnWieldedItemIndexChangeInternal( Int32 thisPointer ,  Boolean isOffHand ,  Boolean isWieldedInstantly ,  Boolean isWieldedOnSpawn ) =>  Agent. _onWieldedItemIndexChange?.Invoke( thisPointer ,  isOffHand ,  isWieldedInstantly ,  isWieldedOnSpawn );
    
    public delegate void OnRemoveWeaponDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex );
    private static OnRemoveWeaponDelegate  _onRemoveWeapon;
    public static event OnRemoveWeaponDelegate OnRemoveWeapon {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnRemoveWeapon"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnRemoveWeapon" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onRemoveWeapon += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnRemoveWeapon");
        }
    }
    private static void OnRemoveWeaponInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ) =>  Agent. _onRemoveWeapon?.Invoke( thisPointer ,  slotIndex );
    
    public delegate void OnWeaponUsageIndexChangeDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 usageIndex );
    private static OnWeaponUsageIndexChangeDelegate  _onWeaponUsageIndexChange;
    public static event OnWeaponUsageIndexChangeDelegate OnWeaponUsageIndexChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponUsageIndexChange"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponUsageIndexChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponUsageIndexChange += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponUsageIndexChange");
        }
    }
    private static void OnWeaponUsageIndexChangeInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int32 usageIndex ) =>  Agent. _onWeaponUsageIndexChange?.Invoke( thisPointer ,  slotIndex ,  usageIndex );
    
    public delegate void OnWeaponAmountChangeDelegate( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 amount );
    private static OnWeaponAmountChangeDelegate  _onWeaponAmountChange;
    public static event OnWeaponAmountChangeDelegate OnWeaponAmountChange {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Agent"]["OnWeaponAmountChange"].Method;
            MethodInfo patch = typeof(Native.Events.Agent).GetMethod("OnWeaponAmountChange" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onWeaponAmountChange += value;
        }
        remove {
            NativeManager.UnHook("Agent", "OnWeaponAmountChange");
        }
    }
    private static void OnWeaponAmountChangeInternal( Int32 thisPointer ,  EquipmentIndex slotIndex ,  Int16 amount ) =>  Agent. _onWeaponAmountChange?.Invoke( thisPointer ,  slotIndex ,  amount );
    
    }
}