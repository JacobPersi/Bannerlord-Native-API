
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
    public static class Mission {
    
    public delegate void ChargeDamageCallbackDelegate( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Blow blow ,  Int32 attacker ,  Int32 victim );
    private static ChargeDamageCallbackDelegate  _chargeDamageCallback;
    public static event ChargeDamageCallbackDelegate ChargeDamageCallback {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["ChargeDamageCallback"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("ChargeDamageCallback" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _chargeDamageCallback += value;
        }
        remove {
            NativeManager.UnHook("Mission", "ChargeDamageCallback");
        }
    }
    private static void ChargeDamageCallbackInternal( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Blow blow ,  Int32 attacker ,  Int32 victim ) =>  Mission. _chargeDamageCallback?.Invoke( thisPointer ,  ref collisionData ,  blow ,  attacker ,  victim );
    
    public delegate void FallDamageCallbackDelegate( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Blow b ,  Int32 attacker ,  Int32 victim );
    private static FallDamageCallbackDelegate  _fallDamageCallback;
    public static event FallDamageCallbackDelegate FallDamageCallback {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["FallDamageCallback"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("FallDamageCallback" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _fallDamageCallback += value;
        }
        remove {
            NativeManager.UnHook("Mission", "FallDamageCallback");
        }
    }
    private static void FallDamageCallbackInternal( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Blow b ,  Int32 attacker ,  Int32 victim ) =>  Mission. _fallDamageCallback?.Invoke( thisPointer ,  ref collisionData ,  b ,  attacker ,  victim );
    
    public delegate void GetDefendCollisionResultsDelegate( Int32 thisPointer ,  Int32 attackerAgent ,  Int32 defenderAgent ,  CombatCollisionResult collisionResult ,  Int32 attackerWeaponSlotIndex ,  Boolean isAlternativeAttack ,  StrikeType strikeType ,  UsageDirection attackDirection ,  Single collisionDistanceOnWeapon ,  Single attackProgress ,  Boolean attackIsParried ,  Boolean isPassiveUsageHit ,  Boolean isHeavyAttack ,   ref Single defenderStunPeriod ,   ref Single attackerStunPeriod ,   ref Boolean crushedThrough );
    private static GetDefendCollisionResultsDelegate  _getDefendCollisionResults;
    public static event GetDefendCollisionResultsDelegate GetDefendCollisionResults {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["GetDefendCollisionResults"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("GetDefendCollisionResults" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getDefendCollisionResults += value;
        }
        remove {
            NativeManager.UnHook("Mission", "GetDefendCollisionResults");
        }
    }
    private static void GetDefendCollisionResultsInternal( Int32 thisPointer ,  Int32 attackerAgent ,  Int32 defenderAgent ,  CombatCollisionResult collisionResult ,  Int32 attackerWeaponSlotIndex ,  Boolean isAlternativeAttack ,  StrikeType strikeType ,  UsageDirection attackDirection ,  Single collisionDistanceOnWeapon ,  Single attackProgress ,  Boolean attackIsParried ,  Boolean isPassiveUsageHit ,  Boolean isHeavyAttack ,   ref Single defenderStunPeriod ,   ref Single attackerStunPeriod ,   ref Boolean crushedThrough ) =>  Mission. _getDefendCollisionResults?.Invoke( thisPointer ,  attackerAgent ,  defenderAgent ,  collisionResult ,  attackerWeaponSlotIndex ,  isAlternativeAttack ,  strikeType ,  attackDirection ,  collisionDistanceOnWeapon ,  attackProgress ,  attackIsParried ,  isPassiveUsageHit ,  isHeavyAttack ,  ref defenderStunPeriod ,  ref attackerStunPeriod ,  ref crushedThrough );
    
    public delegate void DebugLogNativeMissionNetworkEventDelegate( Int32 eventEnum ,  IntPtr eventName ,  Int32 bitCount );
    private static DebugLogNativeMissionNetworkEventDelegate  _debugLogNativeMissionNetworkEvent;
    public static event DebugLogNativeMissionNetworkEventDelegate DebugLogNativeMissionNetworkEvent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["DebugLogNativeMissionNetworkEvent"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("DebugLogNativeMissionNetworkEvent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _debugLogNativeMissionNetworkEvent += value;
        }
        remove {
            NativeManager.UnHook("Mission", "DebugLogNativeMissionNetworkEvent");
        }
    }
    private static void DebugLogNativeMissionNetworkEventInternal( Int32 eventEnum ,  IntPtr eventName ,  Int32 bitCount ) =>  Mission. _debugLogNativeMissionNetworkEvent?.Invoke( eventEnum ,  eventName ,  bitCount );
    
    public delegate void PauseMissionDelegate( Int32 thisPointer );
    private static PauseMissionDelegate  _pauseMission;
    public static event PauseMissionDelegate PauseMission {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["PauseMission"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("PauseMission" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _pauseMission += value;
        }
        remove {
            NativeManager.UnHook("Mission", "PauseMission");
        }
    }
    private static void PauseMissionInternal( Int32 thisPointer ) =>  Mission. _pauseMission?.Invoke( thisPointer );
    
    public delegate void OnAgentAddedAsCorpseDelegate( Int32 thisPointer ,  Int32 affectedAgent );
    private static OnAgentAddedAsCorpseDelegate  _onAgentAddedAsCorpse;
    public static event OnAgentAddedAsCorpseDelegate OnAgentAddedAsCorpse {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnAgentAddedAsCorpse"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnAgentAddedAsCorpse" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentAddedAsCorpse += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnAgentAddedAsCorpse");
        }
    }
    private static void OnAgentAddedAsCorpseInternal( Int32 thisPointer ,  Int32 affectedAgent ) =>  Mission. _onAgentAddedAsCorpse?.Invoke( thisPointer ,  affectedAgent );
    
    public delegate void OnAgentDeletedDelegate( Int32 thisPointer ,  Int32 affectedAgent );
    private static OnAgentDeletedDelegate  _onAgentDeleted;
    public static event OnAgentDeletedDelegate OnAgentDeleted {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnAgentDeleted"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnAgentDeleted" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentDeleted += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnAgentDeleted");
        }
    }
    private static void OnAgentDeletedInternal( Int32 thisPointer ,  Int32 affectedAgent ) =>  Mission. _onAgentDeleted?.Invoke( thisPointer ,  affectedAgent );
    
    public delegate void OnAgentRemovedDelegate( Int32 thisPointer ,  Int32 affectedAgent ,  Int32 affectorAgent ,  AgentState agentState ,  KillingBlow killingBlow );
    private static OnAgentRemovedDelegate  _onAgentRemoved;
    public static event OnAgentRemovedDelegate OnAgentRemoved {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnAgentRemoved"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnAgentRemoved" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentRemoved += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnAgentRemoved");
        }
    }
    private static void OnAgentRemovedInternal( Int32 thisPointer ,  Int32 affectedAgent ,  Int32 affectorAgent ,  AgentState agentState ,  KillingBlow killingBlow ) =>  Mission. _onAgentRemoved?.Invoke( thisPointer ,  affectedAgent ,  affectorAgent ,  agentState ,  killingBlow );
    
    public delegate void SpawnWeaponAsDropFromAgentDelegate( Int32 thisPointer ,  Int32 agent ,  EquipmentIndex equipmentIndex ,   ref Vec3 velocity ,   ref Vec3 angularVelocity ,  WeaponSpawnFlags spawnFlags );
    private static SpawnWeaponAsDropFromAgentDelegate  _spawnWeaponAsDropFromAgent;
    public static event SpawnWeaponAsDropFromAgentDelegate SpawnWeaponAsDropFromAgent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["SpawnWeaponAsDropFromAgent"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("SpawnWeaponAsDropFromAgent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _spawnWeaponAsDropFromAgent += value;
        }
        remove {
            NativeManager.UnHook("Mission", "SpawnWeaponAsDropFromAgent");
        }
    }
    private static void SpawnWeaponAsDropFromAgentInternal( Int32 thisPointer ,  Int32 agent ,  EquipmentIndex equipmentIndex ,   ref Vec3 velocity ,   ref Vec3 angularVelocity ,  WeaponSpawnFlags spawnFlags ) =>  Mission. _spawnWeaponAsDropFromAgent?.Invoke( thisPointer ,  agent ,  equipmentIndex ,  ref velocity ,  ref angularVelocity ,  spawnFlags );
    
    public delegate void OnPreTickDelegate( Int32 thisPointer ,  Single dt );
    private static OnPreTickDelegate  _onPreTick;
    public static event OnPreTickDelegate OnPreTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnPreTick"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnPreTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onPreTick += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnPreTick");
        }
    }
    private static void OnPreTickInternal( Int32 thisPointer ,  Single dt ) =>  Mission. _onPreTick?.Invoke( thisPointer ,  dt );
    
    public delegate void ApplySkeletonScaleToAllEquippedItemsDelegate( Int32 thisPointer ,  IntPtr itemName );
    private static ApplySkeletonScaleToAllEquippedItemsDelegate  _applySkeletonScaleToAllEquippedItems;
    public static event ApplySkeletonScaleToAllEquippedItemsDelegate ApplySkeletonScaleToAllEquippedItems {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["ApplySkeletonScaleToAllEquippedItems"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("ApplySkeletonScaleToAllEquippedItems" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _applySkeletonScaleToAllEquippedItems += value;
        }
        remove {
            NativeManager.UnHook("Mission", "ApplySkeletonScaleToAllEquippedItems");
        }
    }
    private static void ApplySkeletonScaleToAllEquippedItemsInternal( Int32 thisPointer ,  IntPtr itemName ) =>  Mission. _applySkeletonScaleToAllEquippedItems?.Invoke( thisPointer ,  itemName );
    
    public delegate void EndMissionDelegate( Int32 thisPointer );
    private static EndMissionDelegate  _endMission;
    public static event EndMissionDelegate EndMission {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["EndMission"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("EndMission" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _endMission += value;
        }
        remove {
            NativeManager.UnHook("Mission", "EndMission");
        }
    }
    private static void EndMissionInternal( Int32 thisPointer ) =>  Mission. _endMission?.Invoke( thisPointer );
    
    public delegate void OnAgentShootMissileDelegate( Int32 thisPointer ,  Int32 shooterAgent ,  EquipmentIndex weaponIndex ,  Vec3 position ,  Vec3 velocity ,  Mat3 orientation ,  Boolean hasRigidBody ,  Boolean isPrimaryWeaponShot ,  Int32 forcedMissileIndex );
    private static OnAgentShootMissileDelegate  _onAgentShootMissile;
    public static event OnAgentShootMissileDelegate OnAgentShootMissile {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnAgentShootMissile"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnAgentShootMissile" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentShootMissile += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnAgentShootMissile");
        }
    }
    private static void OnAgentShootMissileInternal( Int32 thisPointer ,  Int32 shooterAgent ,  EquipmentIndex weaponIndex ,  Vec3 position ,  Vec3 velocity ,  Mat3 orientation ,  Boolean hasRigidBody ,  Boolean isPrimaryWeaponShot ,  Int32 forcedMissileIndex ) =>  Mission. _onAgentShootMissile?.Invoke( thisPointer ,  shooterAgent ,  weaponIndex ,  position ,  velocity ,  orientation ,  hasRigidBody ,  isPrimaryWeaponShot ,  forcedMissileIndex );
    
    public delegate AgentState GetAgentStateDelegate( Int32 thisPointer ,  Int32 affectorAgent ,  Int32 agent ,  DamageTypes damageType );
    private static GetAgentStateDelegate  _getAgentState;
    public static event GetAgentStateDelegate GetAgentState {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["GetAgentState"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("GetAgentState" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getAgentState += value;
        }
        remove {
            NativeManager.UnHook("Mission", "GetAgentState");
        }
    }
    private static AgentState GetAgentStateInternal( Int32 thisPointer ,  Int32 affectorAgent ,  Int32 agent ,  DamageTypes damageType ) =>  (AgentState)  Mission. _getAgentState?.Invoke( thisPointer ,  affectorAgent ,  agent ,  damageType );
    
    public delegate void MeleeHitCallbackDelegate( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Int32 attacker ,  Int32 victim ,  NativeObjectPointer realHitEntity ,   ref Single inOutMomentumRemaining ,   ref MeleeCollisionReaction colReaction ,  CrushThroughState crushThroughState ,  Vec3 blowDir ,  Vec3 swingDir ,   ref HitParticleResultData hitParticleResultData ,  Boolean crushedThroughWithoutAgentCollision );
    private static MeleeHitCallbackDelegate  _meleeHitCallback;
    public static event MeleeHitCallbackDelegate MeleeHitCallback {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["MeleeHitCallback"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("MeleeHitCallback" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _meleeHitCallback += value;
        }
        remove {
            NativeManager.UnHook("Mission", "MeleeHitCallback");
        }
    }
    private static void MeleeHitCallbackInternal( Int32 thisPointer ,   ref AttackCollisionData collisionData ,  Int32 attacker ,  Int32 victim ,  NativeObjectPointer realHitEntity ,   ref Single inOutMomentumRemaining ,   ref MeleeCollisionReaction colReaction ,  CrushThroughState crushThroughState ,  Vec3 blowDir ,  Vec3 swingDir ,   ref HitParticleResultData hitParticleResultData ,  Boolean crushedThroughWithoutAgentCollision ) =>  Mission. _meleeHitCallback?.Invoke( thisPointer ,  ref collisionData ,  attacker ,  victim ,  realHitEntity ,  ref inOutMomentumRemaining ,  ref colReaction ,  crushThroughState ,  blowDir ,  swingDir ,  ref hitParticleResultData ,  crushedThroughWithoutAgentCollision );
    
    public delegate Single OnAgentHitBlockedDelegate( Int32 thisPointer ,  Int32 affectedAgent ,  Int32 affectorAgent ,   ref AttackCollisionData collisionData ,  Vec3 blowDirection ,  Vec3 swingDirection ,  Boolean isMissile );
    private static OnAgentHitBlockedDelegate  _onAgentHitBlocked;
    public static event OnAgentHitBlockedDelegate OnAgentHitBlocked {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnAgentHitBlocked"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnAgentHitBlocked" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onAgentHitBlocked += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnAgentHitBlocked");
        }
    }
    private static Single OnAgentHitBlockedInternal( Int32 thisPointer ,  Int32 affectedAgent ,  Int32 affectorAgent ,   ref AttackCollisionData collisionData ,  Vec3 blowDirection ,  Vec3 swingDirection ,  Boolean isMissile ) =>  (Single)  Mission. _onAgentHitBlocked?.Invoke( thisPointer ,  affectedAgent ,  affectorAgent ,  ref collisionData ,  blowDirection ,  swingDirection ,  isMissile );
    
    public delegate void MissileAreaDamageCallbackDelegate( Int32 thisPointer ,   ref AttackCollisionData collisionDataInput ,   ref Blow blowInput ,  Int32 alreadyDamagedAgent ,  Int32 shooterAgent ,  Boolean isBigExplosion );
    private static MissileAreaDamageCallbackDelegate  _missileAreaDamageCallback;
    public static event MissileAreaDamageCallbackDelegate MissileAreaDamageCallback {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["MissileAreaDamageCallback"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("MissileAreaDamageCallback" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _missileAreaDamageCallback += value;
        }
        remove {
            NativeManager.UnHook("Mission", "MissileAreaDamageCallback");
        }
    }
    private static void MissileAreaDamageCallbackInternal( Int32 thisPointer ,   ref AttackCollisionData collisionDataInput ,   ref Blow blowInput ,  Int32 alreadyDamagedAgent ,  Int32 shooterAgent ,  Boolean isBigExplosion ) =>  Mission. _missileAreaDamageCallback?.Invoke( thisPointer ,  ref collisionDataInput ,  ref blowInput ,  alreadyDamagedAgent ,  shooterAgent ,  isBigExplosion );
    
    public delegate void OnMissileRemovedDelegate( Int32 thisPointer ,  Int32 missileIndex );
    private static OnMissileRemovedDelegate  _onMissileRemoved;
    public static event OnMissileRemovedDelegate OnMissileRemoved {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnMissileRemoved"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnMissileRemoved" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onMissileRemoved += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnMissileRemoved");
        }
    }
    private static void OnMissileRemovedInternal( Int32 thisPointer ,  Int32 missileIndex ) =>  Mission. _onMissileRemoved?.Invoke( thisPointer ,  missileIndex );
    
    public delegate Boolean MissileHitCallbackDelegate( Int32 thisPointer ,   ref Int32 extraHitParticleIndex ,   ref AttackCollisionData collisionData ,  Vec3 missileStartingPosition ,  Vec3 missilePosition ,  Vec3 missileAngularVelocity ,  Vec3 movementVelocity ,  MatrixFrame attachGlobalFrame ,  MatrixFrame affectedShieldGlobalFrame ,  Int32 numDamagedAgents ,  Int32 attacker ,  Int32 victim ,  NativeObjectPointer hitEntity );
    private static MissileHitCallbackDelegate  _missileHitCallback;
    public static event MissileHitCallbackDelegate MissileHitCallback {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["MissileHitCallback"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("MissileHitCallback" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _missileHitCallback += value;
        }
        remove {
            NativeManager.UnHook("Mission", "MissileHitCallback");
        }
    }
    private static Boolean MissileHitCallbackInternal( Int32 thisPointer ,   ref Int32 extraHitParticleIndex ,   ref AttackCollisionData collisionData ,  Vec3 missileStartingPosition ,  Vec3 missilePosition ,  Vec3 missileAngularVelocity ,  Vec3 movementVelocity ,  MatrixFrame attachGlobalFrame ,  MatrixFrame affectedShieldGlobalFrame ,  Int32 numDamagedAgents ,  Int32 attacker ,  Int32 victim ,  NativeObjectPointer hitEntity ) =>  (Boolean)  Mission. _missileHitCallback?.Invoke( thisPointer ,  ref extraHitParticleIndex ,  ref collisionData ,  missileStartingPosition ,  missilePosition ,  missileAngularVelocity ,  movementVelocity ,  attachGlobalFrame ,  affectedShieldGlobalFrame ,  numDamagedAgents ,  attacker ,  victim ,  hitEntity );
    
    public delegate void MissileCalculatePassbySoundParametersCallbackMTDelegate( Int32 thisPointer ,  Int32 missileIndex ,   ref SoundEventParameter soundEventParameter );
    private static MissileCalculatePassbySoundParametersCallbackMTDelegate  _missileCalculatePassbySoundParametersCallbackMT;
    public static event MissileCalculatePassbySoundParametersCallbackMTDelegate MissileCalculatePassbySoundParametersCallbackMT {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["MissileCalculatePassbySoundParametersCallbackMT"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("MissileCalculatePassbySoundParametersCallbackMT" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _missileCalculatePassbySoundParametersCallbackMT += value;
        }
        remove {
            NativeManager.UnHook("Mission", "MissileCalculatePassbySoundParametersCallbackMT");
        }
    }
    private static void MissileCalculatePassbySoundParametersCallbackMTInternal( Int32 thisPointer ,  Int32 missileIndex ,   ref SoundEventParameter soundEventParameter ) =>  Mission. _missileCalculatePassbySoundParametersCallbackMT?.Invoke( thisPointer ,  missileIndex ,  ref soundEventParameter );
    
    public delegate void UpdateMissionTimeCacheDelegate( Int32 thisPointer ,  Single curTime );
    private static UpdateMissionTimeCacheDelegate  _updateMissionTimeCache;
    public static event UpdateMissionTimeCacheDelegate UpdateMissionTimeCache {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["UpdateMissionTimeCache"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("UpdateMissionTimeCache" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _updateMissionTimeCache += value;
        }
        remove {
            NativeManager.UnHook("Mission", "UpdateMissionTimeCache");
        }
    }
    private static void UpdateMissionTimeCacheInternal( Int32 thisPointer ,  Single curTime ) =>  Mission. _updateMissionTimeCache?.Invoke( thisPointer ,  curTime );
    
    public delegate void ResetMissionDelegate( Int32 thisPointer );
    private static ResetMissionDelegate  _resetMission;
    public static event ResetMissionDelegate ResetMission {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["ResetMission"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("ResetMission" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _resetMission += value;
        }
        remove {
            NativeManager.UnHook("Mission", "ResetMission");
        }
    }
    private static void ResetMissionInternal( Int32 thisPointer ) =>  Mission. _resetMission?.Invoke( thisPointer );
    
    public delegate void OnSceneCreatedDelegate( Int32 thisPointer ,  NativeObjectPointer scene );
    private static OnSceneCreatedDelegate  _onSceneCreated;
    public static event OnSceneCreatedDelegate OnSceneCreated {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["OnSceneCreated"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("OnSceneCreated" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onSceneCreated += value;
        }
        remove {
            NativeManager.UnHook("Mission", "OnSceneCreated");
        }
    }
    private static void OnSceneCreatedInternal( Int32 thisPointer ,  NativeObjectPointer scene ) =>  Mission. _onSceneCreated?.Invoke( thisPointer ,  scene );
    
    public delegate void TickAgentsAndTeamsDelegate( Int32 thisPointer ,  Single dt );
    private static TickAgentsAndTeamsDelegate  _tickAgentsAndTeams;
    public static event TickAgentsAndTeamsDelegate TickAgentsAndTeams {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Mission"]["TickAgentsAndTeams"].Method;
            MethodInfo patch = typeof(Native.Events.Mission).GetMethod("TickAgentsAndTeams" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _tickAgentsAndTeams += value;
        }
        remove {
            NativeManager.UnHook("Mission", "TickAgentsAndTeams");
        }
    }
    private static void TickAgentsAndTeamsInternal( Int32 thisPointer ,  Single dt ) =>  Mission. _tickAgentsAndTeams?.Invoke( thisPointer ,  dt );
    
    }
}