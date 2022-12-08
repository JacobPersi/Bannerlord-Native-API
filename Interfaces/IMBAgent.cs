
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
    public static class IMBAgent {
    
    public static Int32 GetCurrentActionType( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentActionType"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Int32 GetCurrentActionStage( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentActionStage"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Int32 GetCurrentActionDirection( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentActionDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Vec3 ComputeAnimationDisplacement( UIntPtr agentPointer ,  Single dt ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["ComputeAnimationDisplacement"]
        .DynamicInvoke(new object[] {  agentPointer ,  dt  } );
    }

    public static Int32 GetCurrentActionPriority( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentActionPriority"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Single GetCurrentActionProgress( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentActionProgress"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static void SetCurrentActionProgress( UIntPtr agentPointer ,  Int32 channelNo ,  Single progress ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetCurrentActionProgress"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo ,  progress  } );
    }

    public static Boolean SetActionChannel( UIntPtr agentPointer ,  Int32 channelNo ,  Int32 actionNo ,  UInt64 additionalFlags ,  Boolean ignorePriority ,  Single blendWithNextActionFactor ,  Single actionSpeed ,  Single blendInPeriod ,  Single blendOutPeriodToNoAnim ,  Single startProgress ,  Boolean useLinearSmoothing ,  Single blendOutPeriod ,  Boolean forceFaceMorphRestart ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetActionChannel"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo ,  actionNo ,  additionalFlags ,  ignorePriority ,  blendWithNextActionFactor ,  actionSpeed ,  blendInPeriod ,  blendOutPeriodToNoAnim ,  startProgress ,  useLinearSmoothing ,  blendOutPeriod ,  forceFaceMorphRestart  } );
    }

    public static void SetCurrentActionSpeed( UIntPtr agentPointer ,  Int32 channelNo ,  Single actionSpeed ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetCurrentActionSpeed"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo ,  actionSpeed  } );
    }

    public static void TickActionChannels( UIntPtr agentPointer ,  Single dt ) {
          NativeManager.OutboundManifest["IMBAgent"]["TickActionChannels"]
        .DynamicInvoke(new object[] {  agentPointer ,  dt  } );
    }

    public static Single GetActionChannelWeight( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetActionChannelWeight"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Single GetActionChannelCurrentActionWeight( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetActionChannelCurrentActionWeight"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static void SetActionSet( UIntPtr agentPointer ,   ref AnimationSystemData animationSystemData ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetActionSet"]
        .DynamicInvoke(new object[] {  agentPointer ,  animationSystemData  } );
    }

    public static Int32 GetActionSetNo( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetActionSetNo"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static AgentMovementLockedState GetMovementLockedState( UIntPtr agentPointer ) {
         return   (AgentMovementLockedState)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementLockedState"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetAimingTimer( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetAimingTimer"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec2 GetTargetPosition( UIntPtr agentPointer ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBAgent"]["GetTargetPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetTargetPosition( UIntPtr agentPointer ,   ref Vec2 targetPosition ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetTargetPosition"]
        .DynamicInvoke(new object[] {  agentPointer ,  targetPosition  } );
    }

    public static Vec3 GetTargetDirection( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetTargetDirection"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetTargetPositionAndDirection( UIntPtr agentPointer ,   ref Vec2 targetPosition ,   ref Vec3 targetDirection ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetTargetPositionAndDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  targetPosition ,  targetDirection  } );
    }

    public static void ClearTargetFrame( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ClearTargetFrame"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetIsLookDirectionLocked( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetIsLookDirectionLocked"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetIsLookDirectionLocked( UIntPtr agentPointer ,  Boolean isLocked ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetIsLookDirectionLocked"]
        .DynamicInvoke(new object[] {  agentPointer ,  isLocked  } );
    }

    public static void SetMonoObject( UIntPtr agentPointer ,  Int32 monoObject ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMonoObject"]
        .DynamicInvoke(new object[] {  agentPointer ,  monoObject  } );
    }

    public static Vec3 GetEyeGlobalPosition( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetEyeGlobalPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetChestGlobalPosition( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetChestGlobalPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void AddMeshToBone( UIntPtr agentPointer ,  UIntPtr meshPointer ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["AddMeshToBone"]
        .DynamicInvoke(new object[] {  agentPointer ,  meshPointer ,  boneIndex  } );
    }

    public static void RemoveMeshFromBone( UIntPtr agentPointer ,  UIntPtr meshPointer ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["RemoveMeshFromBone"]
        .DynamicInvoke(new object[] {  agentPointer ,  meshPointer ,  boneIndex  } );
    }

    public static NativeObjectPointer AddPrefabToAgentBone( UIntPtr agentPointer ,  Byte[] prefabName ,  SByte boneIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgent"]["AddPrefabToAgentBone"]
        .DynamicInvoke(new object[] {  agentPointer ,  prefabName ,  boneIndex  } );
    }

    public static void WieldNextWeapon( UIntPtr agentPointer ,  Int32 handIndex ,  Int32 wieldActionType ) {
          NativeManager.OutboundManifest["IMBAgent"]["WieldNextWeapon"]
        .DynamicInvoke(new object[] {  agentPointer ,  handIndex ,  wieldActionType  } );
    }

    public static void PreloadForRendering( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["PreloadForRendering"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetAgentScale( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetAgentScale"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetCrouchMode( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetCrouchMode"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetWalkMode( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetWalkMode"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetVisualPosition( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetVisualPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsLookRotationInSlowMotion( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsLookRotationInSlowMotion"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetLookDirectionAsAngle( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetLookDirectionAsAngle"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetLookDirectionAsAngle( UIntPtr agentPointer ,  Single value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetLookDirectionAsAngle"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static MovementControlFlag AttackDirectionToMovementFlag( UIntPtr agentPointer ,  UsageDirection direction ) {
         return   (MovementControlFlag)  NativeManager.OutboundManifest["IMBAgent"]["AttackDirectionToMovementFlag"]
        .DynamicInvoke(new object[] {  agentPointer ,  direction  } );
    }

    public static MovementControlFlag DefendDirectionToMovementFlag( UIntPtr agentPointer ,  UsageDirection direction ) {
         return   (MovementControlFlag)  NativeManager.OutboundManifest["IMBAgent"]["DefendDirectionToMovementFlag"]
        .DynamicInvoke(new object[] {  agentPointer ,  direction  } );
    }

    public static Boolean GetHeadCameraMode( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetHeadCameraMode"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetHeadCameraMode( UIntPtr agentPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetHeadCameraMode"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static Boolean KickClear( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["KickClear"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void ResetGuard( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ResetGuard"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static GuardMode GetCurrentGuardMode( UIntPtr agentPointer ) {
         return   (GuardMode)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentGuardMode"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static MovementControlFlag GetDefendMovementFlag( UIntPtr agentPointer ) {
         return   (MovementControlFlag)  NativeManager.OutboundManifest["IMBAgent"]["GetDefendMovementFlag"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static UsageDirection GetAttackDirection( UIntPtr agentPointer ,  Boolean doAiCheck ) {
         return   (UsageDirection)  NativeManager.OutboundManifest["IMBAgent"]["GetAttackDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  doAiCheck  } );
    }

    public static UsageDirection PlayerAttackDirection( UIntPtr agentPointer ) {
         return   (UsageDirection)  NativeManager.OutboundManifest["IMBAgent"]["PlayerAttackDirection"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetWieldedWeaponInfo( UIntPtr agentPointer ,  Int32 handIndex ,   ref Boolean isMeleeWeapon ,   ref Boolean isRangedWeapon ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetWieldedWeaponInfo"]
        .DynamicInvoke(new object[] {  agentPointer ,  handIndex ,  isMeleeWeapon ,  isRangedWeapon  } );
    }

    public static Int32 GetImmediateEnemy( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetImmediateEnemy"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean TryGetImmediateEnemyAgentMovementData( UIntPtr agentPointer ,   ref Single maximumForwardUnlimitedSpeed ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["TryGetImmediateEnemyAgentMovementData"]
        .DynamicInvoke(new object[] {  agentPointer ,  maximumForwardUnlimitedSpeed ,  position  } );
    }

    public static Boolean GetIsDoingPassiveAttack( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetIsDoingPassiveAttack"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetIsPassiveUsageConditionsAreMet( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetIsPassiveUsageConditionsAreMet"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetCurrentAimingTurbulance( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentAimingTurbulance"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetCurrentAimingError( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentAimingError"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetBodyRotationConstraint( UIntPtr agentPointer ,  Int32 channelIndex ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetBodyRotationConstraint"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelIndex  } );
    }

    public static UsageDirection GetActionDirection( Int32 actionIndex ) {
         return   (UsageDirection)  NativeManager.OutboundManifest["IMBAgent"]["GetActionDirection"]
        .DynamicInvoke(new object[] {  actionIndex  } );
    }

    public static UsageDirection GetAttackDirectionUsage( UIntPtr agentPointer ) {
         return   (UsageDirection)  NativeManager.OutboundManifest["IMBAgent"]["GetAttackDirectionUsage"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void HandleBlowAux( UIntPtr agentPointer ,   ref Blow blow ) {
          NativeManager.OutboundManifest["IMBAgent"]["HandleBlowAux"]
        .DynamicInvoke(new object[] {  agentPointer ,  blow  } );
    }

    public static void MakeVoice( UIntPtr agentPointer ,  Int32 voiceType ,  Int32 predictionType ) {
          NativeManager.OutboundManifest["IMBAgent"]["MakeVoice"]
        .DynamicInvoke(new object[] {  agentPointer ,  voiceType ,  predictionType  } );
    }

    public static Boolean SetHandInverseKinematicsFrame( UIntPtr agentPointer ,   ref MatrixFrame leftGlobalFrame ,   ref MatrixFrame rightGlobalFrame ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetHandInverseKinematicsFrame"]
        .DynamicInvoke(new object[] {  agentPointer ,  leftGlobalFrame ,  rightGlobalFrame  } );
    }

    public static Boolean SetHandInverseKinematicsFrameForMissionObjectUsage( UIntPtr agentPointer ,   ref MatrixFrame localIKFrame ,   ref MatrixFrame boundEntityGlobalFrame ,  Single animationHeightDifference ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetHandInverseKinematicsFrameForMissionObjectUsage"]
        .DynamicInvoke(new object[] {  agentPointer ,  localIKFrame ,  boundEntityGlobalFrame ,  animationHeightDifference  } );
    }

    public static void ClearHandInverseKinematics( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ClearHandInverseKinematics"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void DebugMore( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["DebugMore"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsOnLand( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsOnLand"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsSliding( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsSliding"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsRunningAway( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsRunningAway"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetCurWeaponOffset( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetCurWeaponOffset"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetWalkSpeedLimitOfMountable( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetWalkSpeedLimitOfMountable"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void CreateBloodBurstAtLimb( UIntPtr agentPointer ,  SByte realBoneIndex ,  Single scale ) {
          NativeManager.OutboundManifest["IMBAgent"]["CreateBloodBurstAtLimb"]
        .DynamicInvoke(new object[] {  agentPointer ,  realBoneIndex ,  scale  } );
    }

    public static Int32 GetNativeActionIndex( Byte[] actionName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetNativeActionIndex"]
        .DynamicInvoke(new object[] {  actionName  } );
    }

    public static void SetGuardedAgentIndex( UIntPtr agentPointer ,  Int32 guardedAgentIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetGuardedAgentIndex"]
        .DynamicInvoke(new object[] {  agentPointer ,  guardedAgentIndex  } );
    }

    public static void SetColumnwiseFollowAgent( UIntPtr agentPointer ,  Int32 followAgentIndex ,   ref Vec2 followPosition ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetColumnwiseFollowAgent"]
        .DynamicInvoke(new object[] {  agentPointer ,  followAgentIndex ,  followPosition  } );
    }

    public static Int32 GetMonsterUsageIndex( Byte[] monsterUsage ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetMonsterUsageIndex"]
        .DynamicInvoke(new object[] {  monsterUsage  } );
    }

    public static Single GetMissileRangeWithHeightDifference( UIntPtr agentPointer ,  Single targetZ ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetMissileRangeWithHeightDifference"]
        .DynamicInvoke(new object[] {  agentPointer ,  targetZ  } );
    }

    public static void SetFormationNo( UIntPtr agentPointer ,  Int32 formationNo ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetFormationNo"]
        .DynamicInvoke(new object[] {  agentPointer ,  formationNo  } );
    }

    public static void EnforceShieldUsage( UIntPtr agentPointer ,  UsageDirection direction ) {
          NativeManager.OutboundManifest["IMBAgent"]["EnforceShieldUsage"]
        .DynamicInvoke(new object[] {  agentPointer ,  direction  } );
    }

    public static void SetFiringOrder( UIntPtr agentPointer ,  Int32 order ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetFiringOrder"]
        .DynamicInvoke(new object[] {  agentPointer ,  order  } );
    }

    public static void SetRidingOrder( UIntPtr agentPointer ,  Int32 order ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetRidingOrder"]
        .DynamicInvoke(new object[] {  agentPointer ,  order  } );
    }

    public static void SetDirectionChangeTendency( UIntPtr agentPointer ,  Single tendency ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetDirectionChangeTendency"]
        .DynamicInvoke(new object[] {  agentPointer ,  tendency  } );
    }

    public static void SetAIBehaviorParams( UIntPtr agentPointer ,  Int32 behavior ,  Single y1 ,  Single x2 ,  Single y2 ,  Single x3 ,  Single y3 ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAIBehaviorParams"]
        .DynamicInvoke(new object[] {  agentPointer ,  behavior ,  y1 ,  x2 ,  y2 ,  x3 ,  y3  } );
    }

    public static void SetAllAIBehaviorParams( UIntPtr agentPointer ,  IntPtr behaviorParams ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAllAIBehaviorParams"]
        .DynamicInvoke(new object[] {  agentPointer ,  behaviorParams  } );
    }

    public static void SetBodyArmorMaterialType( UIntPtr agentPointer ,  ArmorMaterialTypes bodyArmorMaterialType ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetBodyArmorMaterialType"]
        .DynamicInvoke(new object[] {  agentPointer ,  bodyArmorMaterialType  } );
    }

    public static Int32 GetMaximumNumberOfAgents() {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetMaximumNumberOfAgents"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetRunningSimulationDataUntilMaximumSpeedReached( UIntPtr agentPointer ,   ref Single combatAccelerationTime ,   ref Single maxSpeed ,  IntPtr speedValues ) {
          NativeManager.OutboundManifest["IMBAgent"]["GetRunningSimulationDataUntilMaximumSpeedReached"]
        .DynamicInvoke(new object[] {  agentPointer ,  combatAccelerationTime ,  maxSpeed ,  speedValues  } );
    }

    public static Int32 GetLastTargetVisibilityState( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetLastTargetVisibilityState"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetMissileRange( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetMissileRange"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetSoundOcclusion( UIntPtr agentPointer ,  Single value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetSoundOcclusion"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static UInt32 GetMovementFlags( UIntPtr agentPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetMovementFlags( UIntPtr agentPointer ,  MovementControlFlag value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMovementFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static Vec2 GetMovementInputVector( UIntPtr agentPointer ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementInputVector"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetMovementInputVector( UIntPtr agentPointer ,  Vec2 value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMovementInputVector"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static void GetCollisionCapsule( UIntPtr agentPointer ,   ref CapsuleData value ) {
          NativeManager.OutboundManifest["IMBAgent"]["GetCollisionCapsule"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static void SetAttackState( UIntPtr agentPointer ,  Int32 attackState ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAttackState"]
        .DynamicInvoke(new object[] {  agentPointer ,  attackState  } );
    }

    public static NativeObjectPointer GetAgentVisuals( UIntPtr agentPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgent"]["GetAgentVisuals"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static UInt32 GetEventControlFlags( UIntPtr agentPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMBAgent"]["GetEventControlFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetEventControlFlags( UIntPtr agentPointer ,  EventControlFlag eventflag ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetEventControlFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  eventflag  } );
    }

    public static void SetAveragePingInMilliseconds( UIntPtr agentPointer ,  Double averagePingInMilliseconds ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAveragePingInMilliseconds"]
        .DynamicInvoke(new object[] {  agentPointer ,  averagePingInMilliseconds  } );
    }

    public static void SetLookAgent( UIntPtr agentPointer ,  UIntPtr lookAtAgentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetLookAgent"]
        .DynamicInvoke(new object[] {  agentPointer ,  lookAtAgentPointer  } );
    }

    public static Int32 GetLookAgent( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetLookAgent"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Int32 GetTargetAgent( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetTargetAgent"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetInteractionAgent( UIntPtr agentPointer ,  UIntPtr interactionAgentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetInteractionAgent"]
        .DynamicInvoke(new object[] {  agentPointer ,  interactionAgentPointer  } );
    }

    public static void SetLookToPointOfInterest( UIntPtr agentPointer ,  Vec3 point ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetLookToPointOfInterest"]
        .DynamicInvoke(new object[] {  agentPointer ,  point  } );
    }

    public static void DisableLookToPointOfInterest( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["DisableLookToPointOfInterest"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsEnemy( UIntPtr agentPointer1 ,  UIntPtr agentPointer2 ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsEnemy"]
        .DynamicInvoke(new object[] {  agentPointer1 ,  agentPointer2  } );
    }

    public static Boolean IsFriend( UIntPtr agentPointer1 ,  UIntPtr agentPointer2 ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsFriend"]
        .DynamicInvoke(new object[] {  agentPointer1 ,  agentPointer2  } );
    }

    public static UInt32 GetAgentFlags( UIntPtr agentPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMBAgent"]["GetAgentFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetAgentFlags( UIntPtr agentPointer ,  UInt32 agentFlags ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAgentFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  agentFlags  } );
    }

    public static void SetSelectedMountIndex( UIntPtr agentPointer ,  Int32 mount_index ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetSelectedMountIndex"]
        .DynamicInvoke(new object[] {  agentPointer ,  mount_index  } );
    }

    public static Int32 GetSelectedMountIndex( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetSelectedMountIndex"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Int32 GetRidingOrder( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetRidingOrder"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static UIntPtr GetSteppedEntityId( UIntPtr agentPointer ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["IMBAgent"]["GetSteppedEntityId"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetNetworkPeer( UIntPtr agentPointer ,  Int32 networkPeerIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetNetworkPeer"]
        .DynamicInvoke(new object[] {  agentPointer ,  networkPeerIndex  } );
    }

    public static void Die( UIntPtr agentPointer ,   ref Blow b ,  SByte overrideKillInfo ) {
          NativeManager.OutboundManifest["IMBAgent"]["Die"]
        .DynamicInvoke(new object[] {  agentPointer ,  b ,  overrideKillInfo  } );
    }

    public static void MakeDead( UIntPtr agentPointer ,  Boolean isKilled ,  Int32 actionIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["MakeDead"]
        .DynamicInvoke(new object[] {  agentPointer ,  isKilled ,  actionIndex  } );
    }

    public static void SetFormationFrameDisabled( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetFormationFrameDisabled"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean SetFormationFrameEnabled( UIntPtr agentPointer ,  WorldPosition position ,  Vec2 direction ,  Single formationDirectionEnforcingFactor ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetFormationFrameEnabled"]
        .DynamicInvoke(new object[] {  agentPointer ,  position ,  direction ,  formationDirectionEnforcingFactor  } );
    }

    public static void SetShouldCatchUpWithFormation( UIntPtr agentPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetShouldCatchUpWithFormation"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static void SetFormationIntegrityData( UIntPtr agentPointer ,  Vec2 position ,  Vec2 currentFormationDirection ,  Vec2 averageVelocityOfCloseAgents ,  Single averageMaxUnlimitedSpeedOfCloseAgents ,  Single deviationOfPositions ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetFormationIntegrityData"]
        .DynamicInvoke(new object[] {  agentPointer ,  position ,  currentFormationDirection ,  averageVelocityOfCloseAgents ,  averageMaxUnlimitedSpeedOfCloseAgents ,  deviationOfPositions  } );
    }

    public static void SetFormationInfo( UIntPtr agentPointer ,  Int32 fileIndex ,  Int32 rankIndex ,  Int32 fileCount ,  Int32 rankCount ,  Vec2 wallDir ,  Int32 unitSpacing ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetFormationInfo"]
        .DynamicInvoke(new object[] {  agentPointer ,  fileIndex ,  rankIndex ,  fileCount ,  rankCount ,  wallDir ,  unitSpacing  } );
    }

    public static void SetRetreatMode( UIntPtr agentPointer ,  WorldPosition retreatPos ,  Boolean retreat ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetRetreatMode"]
        .DynamicInvoke(new object[] {  agentPointer ,  retreatPos ,  retreat  } );
    }

    public static Boolean IsRetreating( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsRetreating"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean IsFadingOut( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["IsFadingOut"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void StartFadingOut( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["StartFadingOut"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetRenderCheckEnabled( UIntPtr agentPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetRenderCheckEnabled"]
        .DynamicInvoke(new object[] {  agentPointer ,  value  } );
    }

    public static Boolean GetRenderCheckEnabled( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetRenderCheckEnabled"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static WorldPosition GetRetreatPos( UIntPtr agentPointer ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBAgent"]["GetRetreatPos"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Int32 GetTeam( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetTeam"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetTeam( UIntPtr agentPointer ,  Int32 teamIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetTeam"]
        .DynamicInvoke(new object[] {  agentPointer ,  teamIndex  } );
    }

    public static void SetCourage( UIntPtr agentPointer ,  Single courage ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetCourage"]
        .DynamicInvoke(new object[] {  agentPointer ,  courage  } );
    }

    public static void UpdateDrivenProperties( UIntPtr agentPointer ,  IntPtr values ) {
          NativeManager.OutboundManifest["IMBAgent"]["UpdateDrivenProperties"]
        .DynamicInvoke(new object[] {  agentPointer ,  values  } );
    }

    public static Vec3 GetLookDirection( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetLookDirection"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetLookDirection( UIntPtr agentPointer ,  Vec3 lookDirection ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetLookDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  lookDirection  } );
    }

    public static Single GetLookDownLimit( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetLookDownLimit"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetPosition( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetPosition( UIntPtr agentPointer ,   ref Vec3 position ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetPosition"]
        .DynamicInvoke(new object[] {  agentPointer ,  position  } );
    }

    public static void GetRotationFrame( UIntPtr agentPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBAgent"]["GetRotationFrame"]
        .DynamicInvoke(new object[] {  agentPointer ,  outFrame  } );
    }

    public static Single GetEyeGlobalHeight( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetEyeGlobalHeight"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec2 GetMovementVelocity( UIntPtr agentPointer ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementVelocity"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec3 GetAverageVelocity( UIntPtr agentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgent"]["GetAverageVelocity"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean GetIsLeftStance( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["GetIsLeftStance"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void InvalidateTargetAgent( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["InvalidateTargetAgent"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void InvalidateAIWeaponSelections( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["InvalidateAIWeaponSelections"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void ResetEnemyCaches( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ResetEnemyCaches"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static AIStateFlag GetAIStateFlags( UIntPtr agentPointer ) {
         return   (AIStateFlag)  NativeManager.OutboundManifest["IMBAgent"]["GetAIStateFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetAIStateFlags( UIntPtr agentPointer ,  AIStateFlag aiStateFlags ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAIStateFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  aiStateFlags  } );
    }

    public static AgentState GetStateFlags( UIntPtr agentPointer ) {
         return   (AgentState)  NativeManager.OutboundManifest["IMBAgent"]["GetStateFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetStateFlags( UIntPtr agentPointer ,  AgentState StateFlags ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetStateFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  StateFlags  } );
    }

    public static Int32 GetMountAgent( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetMountAgent"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetMountAgent( UIntPtr agentPointer ,  Int32 mountAgentIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMountAgent"]
        .DynamicInvoke(new object[] {  agentPointer ,  mountAgentIndex  } );
    }

    public static void SetAlwaysAttackInMelee( UIntPtr agentPointer ,  Boolean attack ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAlwaysAttackInMelee"]
        .DynamicInvoke(new object[] {  agentPointer ,  attack  } );
    }

    public static Int32 GetRiderAgent( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetRiderAgent"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetController( UIntPtr agentPointer ,  ControllerType controller ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetController"]
        .DynamicInvoke(new object[] {  agentPointer ,  controller  } );
    }

    public static ControllerType GetController( UIntPtr agentPointer ) {
         return   (ControllerType)  NativeManager.OutboundManifest["IMBAgent"]["GetController"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetInitialFrame( UIntPtr agentPointer ,   ref Vec3 initialPosition ,   ref Vec2 initialDirection ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetInitialFrame"]
        .DynamicInvoke(new object[] {  agentPointer ,  initialPosition ,  initialDirection  } );
    }

    public static void WeaponEquipped( UIntPtr agentPointer ,  Int32 equipmentSlot ,   ref WeaponDataAsNative weaponData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,   ref WeaponDataAsNative ammoWeaponData ,  IntPtr ammoWeaponStatsData ,  Int32 ammoWeaponStatsDataLength ,  UIntPtr weaponEntity ,  Boolean removeOldWeaponFromScene ,  Boolean isWieldedOnSpawn ) {
          NativeManager.OutboundManifest["IMBAgent"]["WeaponEquipped"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentSlot ,  weaponData ,  weaponStatsData ,  weaponStatsDataLength ,  ammoWeaponData ,  ammoWeaponStatsData ,  ammoWeaponStatsDataLength ,  weaponEntity ,  removeOldWeaponFromScene ,  isWieldedOnSpawn  } );
    }

    public static void DropItem( UIntPtr agentPointer ,  Int32 itemIndex ,  Int32 pickedUpItemType ) {
          NativeManager.OutboundManifest["IMBAgent"]["DropItem"]
        .DynamicInvoke(new object[] {  agentPointer ,  itemIndex ,  pickedUpItemType  } );
    }

    public static void SetWeaponAmountInSlot( UIntPtr agentPointer ,  Int32 equipmentSlot ,  Int16 amount ,  Boolean enforcePrimaryItem ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetWeaponAmountInSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentSlot ,  amount ,  enforcePrimaryItem  } );
    }

    public static void ClearEquipment( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ClearEquipment"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static EquipmentIndex GetWieldedItemIndex( UIntPtr agentPointer ,  Int32 handIndex ) {
         return   (EquipmentIndex)  NativeManager.OutboundManifest["IMBAgent"]["GetWieldedItemIndex"]
        .DynamicInvoke(new object[] {  agentPointer ,  handIndex  } );
    }

    public static void SetWieldedItemIndexAsClient( UIntPtr agentPointer ,  Int32 handIndex ,  Int32 wieldedItemIndex ,  Boolean isWieldedInstantly ,  Boolean isWieldedOnSpawn ,  Int32 mainHandCurrentUsageIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetWieldedItemIndexAsClient"]
        .DynamicInvoke(new object[] {  agentPointer ,  handIndex ,  wieldedItemIndex ,  isWieldedInstantly ,  isWieldedOnSpawn ,  mainHandCurrentUsageIndex  } );
    }

    public static void SetUsageIndexOfWeaponInSlotAsClient( UIntPtr agentPointer ,  Int32 slotIndex ,  Int32 usageIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetUsageIndexOfWeaponInSlotAsClient"]
        .DynamicInvoke(new object[] {  agentPointer ,  slotIndex ,  usageIndex  } );
    }

    public static void SetWeaponHitPointsInSlot( UIntPtr agentPointer ,  Int32 wieldedItemIndex ,  Int16 hitPoints ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetWeaponHitPointsInSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  wieldedItemIndex ,  hitPoints  } );
    }

    public static void SetWeaponAmmoAsClient( UIntPtr agentPointer ,  Int32 equipmentIndex ,  Int32 ammoEquipmentIndex ,  Int16 ammo ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetWeaponAmmoAsClient"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentIndex ,  ammoEquipmentIndex ,  ammo  } );
    }

    public static void SetWeaponReloadPhaseAsClient( UIntPtr agentPointer ,  Int32 wieldedItemIndex ,  Int16 reloadPhase ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetWeaponReloadPhaseAsClient"]
        .DynamicInvoke(new object[] {  agentPointer ,  wieldedItemIndex ,  reloadPhase  } );
    }

    public static void SetReloadAmmoInSlot( UIntPtr agentPointer ,  Int32 slotIndex ,  Int32 ammoSlotIndex ,  Int16 reloadedAmmo ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetReloadAmmoInSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  slotIndex ,  ammoSlotIndex ,  reloadedAmmo  } );
    }

    public static void StartSwitchingWeaponUsageIndexAsClient( UIntPtr agentPointer ,  Int32 wieldedItemIndex ,  Int32 usageIndex ,  UsageDirection currentMovementFlagUsageDirection ) {
          NativeManager.OutboundManifest["IMBAgent"]["StartSwitchingWeaponUsageIndexAsClient"]
        .DynamicInvoke(new object[] {  agentPointer ,  wieldedItemIndex ,  usageIndex ,  currentMovementFlagUsageDirection  } );
    }

    public static void TryToWieldWeaponInSlot( UIntPtr agentPointer ,  Int32 equipmentSlot ,  Int32 type ,  Boolean isWieldedOnSpawn ) {
          NativeManager.OutboundManifest["IMBAgent"]["TryToWieldWeaponInSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentSlot ,  type ,  isWieldedOnSpawn  } );
    }

    public static UIntPtr GetWeaponEntityFromEquipmentSlot( UIntPtr agentPointer ,  Int32 equipmentSlot ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["IMBAgent"]["GetWeaponEntityFromEquipmentSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentSlot  } );
    }

    public static void PrepareWeaponForDropInEquipmentSlot( UIntPtr agentPointer ,  Int32 equipmentSlot ,  Boolean dropWithHolster ) {
          NativeManager.OutboundManifest["IMBAgent"]["PrepareWeaponForDropInEquipmentSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  equipmentSlot ,  dropWithHolster  } );
    }

    public static void TryToSheathWeaponInHand( UIntPtr agentPointer ,  Int32 handIndex ,  Int32 type ) {
          NativeManager.OutboundManifest["IMBAgent"]["TryToSheathWeaponInHand"]
        .DynamicInvoke(new object[] {  agentPointer ,  handIndex ,  type  } );
    }

    public static void UpdateWeapons( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["UpdateWeapons"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void AttachWeaponToBone( UIntPtr agentPointer ,   ref WeaponDataAsNative weaponData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,  UIntPtr weaponEntity ,  SByte boneIndex ,   ref MatrixFrame attachLocalFrame ) {
          NativeManager.OutboundManifest["IMBAgent"]["AttachWeaponToBone"]
        .DynamicInvoke(new object[] {  agentPointer ,  weaponData ,  weaponStatsData ,  weaponStatsDataLength ,  weaponEntity ,  boneIndex ,  attachLocalFrame  } );
    }

    public static void DeleteAttachedWeaponFromBone( UIntPtr agentPointer ,  Int32 attachedWeaponIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["DeleteAttachedWeaponFromBone"]
        .DynamicInvoke(new object[] {  agentPointer ,  attachedWeaponIndex  } );
    }

    public static void AttachWeaponToWeaponInSlot( UIntPtr agentPointer ,   ref WeaponDataAsNative weaponData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,  UIntPtr weaponEntity ,  Int32 slotIndex ,   ref MatrixFrame attachLocalFrame ) {
          NativeManager.OutboundManifest["IMBAgent"]["AttachWeaponToWeaponInSlot"]
        .DynamicInvoke(new object[] {  agentPointer ,  weaponData ,  weaponStatsData ,  weaponStatsDataLength ,  weaponEntity ,  slotIndex ,  attachLocalFrame  } );
    }

    public static void Build( UIntPtr agentPointer ,  Vec3 eyeOffsetWrtHead ) {
          NativeManager.OutboundManifest["IMBAgent"]["Build"]
        .DynamicInvoke(new object[] {  agentPointer ,  eyeOffsetWrtHead  } );
    }

    public static void LockAgentReplicationTableDataWithCurrentReliableSequenceNo( UIntPtr agentPointer ,  Int32 peerIndex ) {
          NativeManager.OutboundManifest["IMBAgent"]["LockAgentReplicationTableDataWithCurrentReliableSequenceNo"]
        .DynamicInvoke(new object[] {  agentPointer ,  peerIndex  } );
    }

    public static void SetAgentExcludeStateForFaceGroupId( UIntPtr agentPointer ,  Int32 faceGroupId ,  Boolean isExcluded ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAgentExcludeStateForFaceGroupId"]
        .DynamicInvoke(new object[] {  agentPointer ,  faceGroupId ,  isExcluded  } );
    }

    public static void SetAgentScale( UIntPtr agentPointer ,  Single scale ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAgentScale"]
        .DynamicInvoke(new object[] {  agentPointer ,  scale  } );
    }

    public static void InitializeAgentRecord( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["InitializeAgentRecord"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec2 GetCurrentVelocity( UIntPtr agentPointer ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentVelocity"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetTurnSpeed( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetTurnSpeed"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetMovementDirectionAsAngle( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementDirectionAsAngle"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Vec2 GetMovementDirection( UIntPtr agentPointer ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBAgent"]["GetMovementDirection"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetMovementDirection( UIntPtr agentPointer ,   ref Vec2 direction ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMovementDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  direction  } );
    }

    public static Single GetCurrentSpeedLimit( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentSpeedLimit"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetMinimumSpeed( UIntPtr agentPointer ,  Single speed ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMinimumSpeed"]
        .DynamicInvoke(new object[] {  agentPointer ,  speed  } );
    }

    public static void SetMaximumSpeedLimit( UIntPtr agentPointer ,  Single maximumSpeedLimit ,  Boolean isMultiplier ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetMaximumSpeedLimit"]
        .DynamicInvoke(new object[] {  agentPointer ,  maximumSpeedLimit ,  isMultiplier  } );
    }

    public static Single GetMaximumSpeedLimit( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetMaximumSpeedLimit"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Single GetMaximumForwardUnlimitedSpeed( UIntPtr agentPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetMaximumForwardUnlimitedSpeed"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void FadeOut( UIntPtr agentPointer ,  Boolean hideInstantly ) {
          NativeManager.OutboundManifest["IMBAgent"]["FadeOut"]
        .DynamicInvoke(new object[] {  agentPointer ,  hideInstantly  } );
    }

    public static void FadeIn( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["FadeIn"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Int32 GetScriptedFlags( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetScriptedFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetScriptedFlags( UIntPtr agentPointer ,  Int32 flags ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetScriptedFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  flags  } );
    }

    public static void GetDebugValues( UIntPtr agentPointer ,  IntPtr values ,   ref Int32 valueCount ) {
          NativeManager.OutboundManifest["IMBAgent"]["GetDebugValues"]
        .DynamicInvoke(new object[] {  agentPointer ,  values ,  valueCount  } );
    }

    public static Int32 GetScriptedCombatFlags( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetScriptedCombatFlags"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetScriptedCombatFlags( UIntPtr agentPointer ,  Int32 flags ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetScriptedCombatFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  flags  } );
    }

    public static Boolean SetScriptedPositionAndDirection( UIntPtr agentPointer ,   ref WorldPosition targetPosition ,  Single targetDirection ,  Boolean addHumanLikeDelay ,  Int32 additionalFlags ,  Byte[] debugString ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetScriptedPositionAndDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  targetPosition ,  targetDirection ,  addHumanLikeDelay ,  additionalFlags ,  debugString  } );
    }

    public static Boolean SetScriptedPosition( UIntPtr agentPointer ,   ref WorldPosition targetPosition ,  Boolean addHumanLikeDelay ,  Int32 additionalFlags ,  Byte[] debugString ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["SetScriptedPosition"]
        .DynamicInvoke(new object[] {  agentPointer ,  targetPosition ,  addHumanLikeDelay ,  additionalFlags ,  debugString  } );
    }

    public static void SetScriptedTargetEntity( UIntPtr agentPointer ,  UIntPtr entityId ,   ref WorldPosition specialPosition ,  Int32 additionalFlags ,  Boolean ignoreIfAlreadyAttacking ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetScriptedTargetEntity"]
        .DynamicInvoke(new object[] {  agentPointer ,  entityId ,  specialPosition ,  additionalFlags ,  ignoreIfAlreadyAttacking  } );
    }

    public static void DisableScriptedMovement( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["DisableScriptedMovement"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void DisableScriptedCombatMovement( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["DisableScriptedCombatMovement"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void ForceAiBehaviorSelection( UIntPtr agentPointer ) {
          NativeManager.OutboundManifest["IMBAgent"]["ForceAiBehaviorSelection"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean HasPathThroughNavigationFaceIdFromDirection( UIntPtr agentPointer ,  Int32 navigationFaceId ,   ref Vec2 direction ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["HasPathThroughNavigationFaceIdFromDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  navigationFaceId ,  direction  } );
    }

    public static Boolean HasPathThroughNavigationFacesIDFromDirection( UIntPtr agentPointer ,  Int32 navigationFaceID_1 ,  Int32 navigationFaceID_2 ,  Int32 navigationFaceID_3 ,   ref Vec2 direction ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["HasPathThroughNavigationFacesIDFromDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  navigationFaceID_1 ,  navigationFaceID_2 ,  navigationFaceID_3 ,  direction  } );
    }

    public static Boolean CanMoveDirectlyToPosition( UIntPtr agentPointer ,   ref WorldPosition position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["CanMoveDirectlyToPosition"]
        .DynamicInvoke(new object[] {  agentPointer ,  position  } );
    }

    public static Boolean CheckPathToAITargetAgentPassesThroughNavigationFaceIdFromDirection( UIntPtr agentPointer ,  Int32 navigationFaceId ,   ref Vec3 direction ,  Single overridenCostForFaceId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["CheckPathToAITargetAgentPassesThroughNavigationFaceIdFromDirection"]
        .DynamicInvoke(new object[] {  agentPointer ,  navigationFaceId ,  direction ,  overridenCostForFaceId  } );
    }

    public static Single GetPathDistanceToPoint( UIntPtr agentPointer ,   ref Vec3 direction ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAgent"]["GetPathDistanceToPoint"]
        .DynamicInvoke(new object[] {  agentPointer ,  direction  } );
    }

    public static Int32 GetCurrentNavigationFaceId( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentNavigationFaceId"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static WorldPosition GetWorldPosition( UIntPtr agentPointer ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBAgent"]["GetWorldPosition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static void SetAgentFacialAnimation( UIntPtr agentPointer ,  Int32 channel ,  Byte[] animationName ,  Boolean loop ) {
          NativeManager.OutboundManifest["IMBAgent"]["SetAgentFacialAnimation"]
        .DynamicInvoke(new object[] {  agentPointer ,  channel ,  animationName ,  loop  } );
    }

    public static Int32 GetAgentFacialAnimation( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetAgentFacialAnimation"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Int32 GetAgentVoiceDefinition( UIntPtr agentPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetAgentVoiceDefinition"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static Boolean AllowFirstPersonWideRotation( UIntPtr agentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgent"]["AllowFirstPersonWideRotation"]
        .DynamicInvoke(new object[] {  agentPointer  } );
    }

    public static UInt64 GetCurrentAnimationFlags( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (UInt64)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentAnimationFlags"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    public static Int32 GetCurrentAction( UIntPtr agentPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAgent"]["GetCurrentAction"]
        .DynamicInvoke(new object[] {  agentPointer ,  channelNo  } );
    }

    }
}