
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
    public static class IMBMission {
    
    public static void ClearResources( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearResources"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static UIntPtr CreateMission( Int32 mission ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["IMBMission"]["CreateMission"]
        .DynamicInvoke(new object[] {  mission  } );
    }

    public static void tickAgentsAndTeamsAsync( UIntPtr missionPointer ,  Single dt ) {
          NativeManager.OutboundManifest["IMBMission"]["tickAgentsAndTeamsAsync"]
        .DynamicInvoke(new object[] {  missionPointer ,  dt  } );
    }

    public static void ClearAgentActions( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearAgentActions"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ClearMissiles( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearMissiles"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ClearCorpses( UIntPtr missionPointer ,  Boolean isMissionReset ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearCorpses"]
        .DynamicInvoke(new object[] {  missionPointer ,  isMissionReset  } );
    }

    public static Boolean GetPauseAITick( UIntPtr missionPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["GetPauseAITick"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void SetPauseAITick( UIntPtr missionPointer ,  Boolean I ) {
          NativeManager.OutboundManifest["IMBMission"]["SetPauseAITick"]
        .DynamicInvoke(new object[] {  missionPointer ,  I  } );
    }

    public static Single GetClearSceneTimerElapsedTime( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetClearSceneTimerElapsedTime"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ResetFirstThirdPersonView( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ResetFirstThirdPersonView"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void SetCameraIsFirstPerson( Boolean value ) {
          NativeManager.OutboundManifest["IMBMission"]["SetCameraIsFirstPerson"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetCameraFrame( UIntPtr missionPointer ,   ref MatrixFrame cameraFrame ,  Single zoomFactor ,   ref Vec3 attenuationPosition ) {
          NativeManager.OutboundManifest["IMBMission"]["SetCameraFrame"]
        .DynamicInvoke(new object[] {  missionPointer ,  cameraFrame ,  zoomFactor ,  attenuationPosition  } );
    }

    public static MatrixFrame GetCameraFrame( UIntPtr missionPointer ) {
         return   (MatrixFrame)  NativeManager.OutboundManifest["IMBMission"]["GetCameraFrame"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Boolean GetIsLoadingFinished( UIntPtr missionPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["GetIsLoadingFinished"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ClearScene( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearScene"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void InitializeMission( UIntPtr missionPointer ,   ref MissionInitializerRecord rec ) {
          NativeManager.OutboundManifest["IMBMission"]["InitializeMission"]
        .DynamicInvoke(new object[] {  missionPointer ,  rec  } );
    }

    public static void FinalizeMission( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["FinalizeMission"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Single GetTime( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetTime"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Single GetAverageFps( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetAverageFps"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Int32 GetCombatType( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetCombatType"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void SetCombatType( UIntPtr missionPointer ,  Int32 combatType ) {
          NativeManager.OutboundManifest["IMBMission"]["SetCombatType"]
        .DynamicInvoke(new object[] {  missionPointer ,  combatType  } );
    }

    public static Int32 RayCastForClosestAgent( UIntPtr missionPointer ,  Vec3 SourcePoint ,  Vec3 RayFinishPoint ,  Int32 ExcludeAgentIndex ,   ref Single CollisionDistance ,  Single RayThickness ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["RayCastForClosestAgent"]
        .DynamicInvoke(new object[] {  missionPointer ,  SourcePoint ,  RayFinishPoint ,  ExcludeAgentIndex ,  CollisionDistance ,  RayThickness  } );
    }

    public static Boolean RayCastForClosestAgentsLimbs( UIntPtr missionPointer ,  Vec3 SourcePoint ,  Vec3 RayFinishPoint ,  Int32 ExcludeAgentIndex ,   ref Single CollisionDistance ,   ref Int32 AgentIndex ,   ref SByte BoneIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["RayCastForClosestAgentsLimbs"]
        .DynamicInvoke(new object[] {  missionPointer ,  SourcePoint ,  RayFinishPoint ,  ExcludeAgentIndex ,  CollisionDistance ,  AgentIndex ,  BoneIndex  } );
    }

    public static Boolean RayCastForGivenAgentsLimbs( UIntPtr missionPointer ,  Vec3 SourcePoint ,  Vec3 RayFinishPoint ,  Int32 GivenAgentIndex ,   ref Single CollisionDistance ,   ref SByte BoneIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["RayCastForGivenAgentsLimbs"]
        .DynamicInvoke(new object[] {  missionPointer ,  SourcePoint ,  RayFinishPoint ,  GivenAgentIndex ,  CollisionDistance ,  BoneIndex  } );
    }

    public static Int32 GetNumberOfTeams( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetNumberOfTeams"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ResetTeams( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ResetTeams"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Int32 AddTeam( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["AddTeam"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void RestartRecord( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["RestartRecord"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Boolean IsPositionInsideBoundaries( UIntPtr missionPointer ,  Vec2 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["IsPositionInsideBoundaries"]
        .DynamicInvoke(new object[] {  missionPointer ,  position  } );
    }

    public static WorldPosition GetAlternatePositionForNavmeshlessOrOutOfBoundsPosition( UIntPtr ptr ,   ref Vec2 directionTowards ,   ref WorldPosition originalPosition ,   ref Single positionPenalty ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBMission"]["GetAlternatePositionForNavmeshlessOrOutOfBoundsPosition"]
        .DynamicInvoke(new object[] {  ptr ,  directionTowards ,  originalPosition ,  positionPenalty  } );
    }

    public static Int32 AddMissile( UIntPtr missionPointer ,  Boolean isPrediction ,  Int32 shooterAgentIndex ,   ref WeaponDataAsNative weaponData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,  Single damageBonus ,   ref Vec3 position ,   ref Vec3 direction ,   ref Mat3 orientation ,  Single baseSpeed ,  Single speed ,  Boolean addRigidBody ,  UIntPtr entityPointer ,  Int32 forcedMissileIndex ,  Boolean isPrimaryWeaponShot ,   ref UIntPtr missileEntity ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["AddMissile"]
        .DynamicInvoke(new object[] {  missionPointer ,  isPrediction ,  shooterAgentIndex ,  weaponData ,  weaponStatsData ,  weaponStatsDataLength ,  damageBonus ,  position ,  direction ,  orientation ,  baseSpeed ,  speed ,  addRigidBody ,  entityPointer ,  forcedMissileIndex ,  isPrimaryWeaponShot ,  missileEntity  } );
    }

    public static Int32 AddMissileSingleUsage( UIntPtr missionPointer ,  Boolean isPrediction ,  Int32 shooterAgentIndex ,   ref WeaponDataAsNative weaponData ,   ref WeaponStatsData weaponStatsData ,  Single damageBonus ,   ref Vec3 position ,   ref Vec3 direction ,   ref Mat3 orientation ,  Single baseSpeed ,  Single speed ,  Boolean addRigidBody ,  UIntPtr entityPointer ,  Int32 forcedMissileIndex ,  Boolean isPrimaryWeaponShot ,   ref UIntPtr missileEntity ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["AddMissileSingleUsage"]
        .DynamicInvoke(new object[] {  missionPointer ,  isPrediction ,  shooterAgentIndex ,  weaponData ,  weaponStatsData ,  damageBonus ,  position ,  direction ,  orientation ,  baseSpeed ,  speed ,  addRigidBody ,  entityPointer ,  forcedMissileIndex ,  isPrimaryWeaponShot ,  missileEntity  } );
    }

    public static Vec3 GetMissileCollisionPoint( UIntPtr missionPointer ,  Vec3 missileStartingPosition ,  Vec3 missileDirection ,  Single missileStartingSpeed ,   ref WeaponDataAsNative weaponData ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBMission"]["GetMissileCollisionPoint"]
        .DynamicInvoke(new object[] {  missionPointer ,  missileStartingPosition ,  missileDirection ,  missileStartingSpeed ,  weaponData  } );
    }

    public static void RemoveMissile( UIntPtr missionPointer ,  Int32 missileIndex ) {
          NativeManager.OutboundManifest["IMBMission"]["RemoveMissile"]
        .DynamicInvoke(new object[] {  missionPointer ,  missileIndex  } );
    }

    public static Single GetMissileVerticalAimCorrection( Vec3 vecToTarget ,  Single missileStartingSpeed ,   ref WeaponStatsData weaponStatsData ,  Single airFrictionConstant ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetMissileVerticalAimCorrection"]
        .DynamicInvoke(new object[] {  vecToTarget ,  missileStartingSpeed ,  weaponStatsData ,  airFrictionConstant  } );
    }

    public static Single GetMissileRange( Single missileStartingSpeed ,  Single heightDifference ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetMissileRange"]
        .DynamicInvoke(new object[] {  missileStartingSpeed ,  heightDifference  } );
    }

    public static void PrepareMissileWeaponForDrop( UIntPtr missionPointer ,  Int32 missileIndex ) {
          NativeManager.OutboundManifest["IMBMission"]["PrepareMissileWeaponForDrop"]
        .DynamicInvoke(new object[] {  missionPointer ,  missileIndex  } );
    }

    public static void AddParticleSystemBurstByName( UIntPtr missionPointer ,  Byte[] particleSystem ,   ref MatrixFrame frame ,  Boolean synchThroughNetwork ) {
          NativeManager.OutboundManifest["IMBMission"]["AddParticleSystemBurstByName"]
        .DynamicInvoke(new object[] {  missionPointer ,  particleSystem ,  frame ,  synchThroughNetwork  } );
    }

    public static void Tick( UIntPtr missionPointer ,  Single dt ) {
          NativeManager.OutboundManifest["IMBMission"]["Tick"]
        .DynamicInvoke(new object[] {  missionPointer ,  dt  } );
    }

    public static void IdleTick( UIntPtr missionPointer ,  Single dt ) {
          NativeManager.OutboundManifest["IMBMission"]["IdleTick"]
        .DynamicInvoke(new object[] {  missionPointer ,  dt  } );
    }

    public static void MakeSound( UIntPtr pointer ,  Int32 nativeSoundCode ,  Vec3 position ,  Boolean soundCanBePredicted ,  Boolean isReliable ,  Int32 relatedAgent1 ,  Int32 relatedAgent2 ) {
          NativeManager.OutboundManifest["IMBMission"]["MakeSound"]
        .DynamicInvoke(new object[] {  pointer ,  nativeSoundCode ,  position ,  soundCanBePredicted ,  isReliable ,  relatedAgent1 ,  relatedAgent2  } );
    }

    public static void MakeSoundWithParameter( UIntPtr pointer ,  Int32 nativeSoundCode ,  Vec3 position ,  Boolean soundCanBePredicted ,  Boolean isReliable ,  Int32 relatedAgent1 ,  Int32 relatedAgent2 ,  SoundEventParameter parameter ) {
          NativeManager.OutboundManifest["IMBMission"]["MakeSoundWithParameter"]
        .DynamicInvoke(new object[] {  pointer ,  nativeSoundCode ,  position ,  soundCanBePredicted ,  isReliable ,  relatedAgent1 ,  relatedAgent2 ,  parameter  } );
    }

    public static void MakeSoundOnlyOnRelatedPeer( UIntPtr pointer ,  Int32 nativeSoundCode ,  Vec3 position ,  Int32 relatedAgent ) {
          NativeManager.OutboundManifest["IMBMission"]["MakeSoundOnlyOnRelatedPeer"]
        .DynamicInvoke(new object[] {  pointer ,  nativeSoundCode ,  position ,  relatedAgent  } );
    }

    public static void AddSoundAlarmFactorToAgents( UIntPtr pointer ,  Int32 ownerId ,  Vec3 position ,  Single alarmFactor ) {
          NativeManager.OutboundManifest["IMBMission"]["AddSoundAlarmFactorToAgents"]
        .DynamicInvoke(new object[] {  pointer ,  ownerId ,  position ,  alarmFactor  } );
    }

    public static Int32 GetEnemyAlarmStateIndicator( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetEnemyAlarmStateIndicator"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Single GetPlayerAlarmIndicator( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetPlayerAlarmIndicator"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static AgentCreationResult CreateAgent( UIntPtr missionPointer ,  UInt64 monsterFlag ,  Int32 forcedAgentIndex ,  Boolean isFemale ,   ref AgentSpawnData spawnData ,   ref CapsuleData bodyCapsule ,   ref CapsuleData crouchedBodyCapsule ,   ref AnimationSystemData animationSystemData ,  Int32 instanceNo ) {
         return   (AgentCreationResult)  NativeManager.OutboundManifest["IMBMission"]["CreateAgent"]
        .DynamicInvoke(new object[] {  missionPointer ,  monsterFlag ,  forcedAgentIndex ,  isFemale ,  spawnData ,  bodyCapsule ,  crouchedBodyCapsule ,  animationSystemData ,  instanceNo  } );
    }

    public static Vec3 GetPositionOfMissile( UIntPtr missionPointer ,  Int32 index ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBMission"]["GetPositionOfMissile"]
        .DynamicInvoke(new object[] {  missionPointer ,  index  } );
    }

    public static Vec3 GetVelocityOfMissile( UIntPtr missionPointer ,  Int32 index ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBMission"]["GetVelocityOfMissile"]
        .DynamicInvoke(new object[] {  missionPointer ,  index  } );
    }

    public static Boolean GetMissileHasRigidBody( UIntPtr missionPointer ,  Int32 index ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["GetMissileHasRigidBody"]
        .DynamicInvoke(new object[] {  missionPointer ,  index  } );
    }

    public static Boolean AddBoundary( UIntPtr missionPointer ,  Byte[] name ,  IntPtr boundaryPoints ,  Int32 boundaryPointCount ,  Boolean isAllowanceInside ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["AddBoundary"]
        .DynamicInvoke(new object[] {  missionPointer ,  name ,  boundaryPoints ,  boundaryPointCount ,  isAllowanceInside  } );
    }

    public static Boolean RemoveBoundary( UIntPtr missionPointer ,  Byte[] name ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["RemoveBoundary"]
        .DynamicInvoke(new object[] {  missionPointer ,  name  } );
    }

    public static void GetBoundaryPoints( UIntPtr missionPointer ,  Byte[] name ,  Int32 boundaryPointOffset ,  IntPtr boundaryPoints ,  Int32 boundaryPointsSize ,   ref Int32 retrievedPointCount ) {
          NativeManager.OutboundManifest["IMBMission"]["GetBoundaryPoints"]
        .DynamicInvoke(new object[] {  missionPointer ,  name ,  boundaryPointOffset ,  boundaryPoints ,  boundaryPointsSize ,  retrievedPointCount  } );
    }

    public static Int32 GetBoundaryCount( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetBoundaryCount"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Single GetBoundaryRadius( UIntPtr missionPointer ,  Byte[] name ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetBoundaryRadius"]
        .DynamicInvoke(new object[] {  missionPointer ,  name  } );
    }

    public static Int32 GetBoundaryName( UIntPtr missionPointer ,  Int32 boundaryIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetBoundaryName"]
        .DynamicInvoke(new object[] {  missionPointer ,  boundaryIndex  } );
    }

    public static Vec2 GetClosestBoundaryPosition( UIntPtr missionPointer ,  Vec2 position ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBMission"]["GetClosestBoundaryPosition"]
        .DynamicInvoke(new object[] {  missionPointer ,  position  } );
    }

    public static Boolean GetNavigationPoints( UIntPtr missionPointer ,   ref NavigationData navigationData ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["GetNavigationPoints"]
        .DynamicInvoke(new object[] {  missionPointer ,  navigationData  } );
    }

    public static void SetNavigationFaceCostWithIdAroundPosition( UIntPtr missionPointer ,  Int32 navigationFaceId ,  Vec3 position ,  Single cost ) {
          NativeManager.OutboundManifest["IMBMission"]["SetNavigationFaceCostWithIdAroundPosition"]
        .DynamicInvoke(new object[] {  missionPointer ,  navigationFaceId ,  position ,  cost  } );
    }

    public static void PauseMissionSceneSounds( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["PauseMissionSceneSounds"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ResumeMissionSceneSounds( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ResumeMissionSceneSounds"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void ProcessRecordUntilTime( UIntPtr missionPointer ,  Single time ) {
          NativeManager.OutboundManifest["IMBMission"]["ProcessRecordUntilTime"]
        .DynamicInvoke(new object[] {  missionPointer ,  time  } );
    }

    public static Boolean EndOfRecord( UIntPtr missionPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["EndOfRecord"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void RecordCurrentState( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["RecordCurrentState"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void StartRecording() {
          NativeManager.OutboundManifest["IMBMission"]["StartRecording"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void BackupRecordToFile( UIntPtr missionPointer ,  Byte[] fileName ,  Byte[] gameType ,  Byte[] sceneLevels ) {
          NativeManager.OutboundManifest["IMBMission"]["BackupRecordToFile"]
        .DynamicInvoke(new object[] {  missionPointer ,  fileName ,  gameType ,  sceneLevels  } );
    }

    public static void RestoreRecordFromFile( UIntPtr missionPointer ,  Byte[] fileName ) {
          NativeManager.OutboundManifest["IMBMission"]["RestoreRecordFromFile"]
        .DynamicInvoke(new object[] {  missionPointer ,  fileName  } );
    }

    public static void ClearRecordBuffers( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBMission"]["ClearRecordBuffers"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Int32 GetSceneNameForReplay( PlatformFilePath replayName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetSceneNameForReplay"]
        .DynamicInvoke(new object[] {  replayName  } );
    }

    public static Int32 GetGameTypeForReplay( PlatformFilePath replayName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetGameTypeForReplay"]
        .DynamicInvoke(new object[] {  replayName  } );
    }

    public static Int32 GetSceneLevelsForReplay( PlatformFilePath replayName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetSceneLevelsForReplay"]
        .DynamicInvoke(new object[] {  replayName  } );
    }

    public static Int32 GetAtmosphereNameForReplay( PlatformFilePath replayName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetAtmosphereNameForReplay"]
        .DynamicInvoke(new object[] {  replayName  } );
    }

    public static Int32 GetAtmosphereSeasonForReplay( PlatformFilePath replayName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetAtmosphereSeasonForReplay"]
        .DynamicInvoke(new object[] {  replayName  } );
    }

    public static Int32 GetClosestEnemy( UIntPtr missionPointer ,  Int32 teamIndex ,  Vec3 position ,  Single radius ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetClosestEnemy"]
        .DynamicInvoke(new object[] {  missionPointer ,  teamIndex ,  position ,  radius  } );
    }

    public static Int32 GetClosestAlly( UIntPtr missionPointer ,  Int32 teamIndex ,  Vec3 position ,  Single radius ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetClosestAlly"]
        .DynamicInvoke(new object[] {  missionPointer ,  teamIndex ,  position ,  radius  } );
    }

    public static Boolean IsAgentInProximityMap( UIntPtr missionPointer ,  Int32 agentIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["IsAgentInProximityMap"]
        .DynamicInvoke(new object[] {  missionPointer ,  agentIndex  } );
    }

    public static Boolean HasAnyAgentsOfTeamAround( UIntPtr missionPointer ,  Vec3 origin ,  Single radius ,  Int32 teamNo ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["HasAnyAgentsOfTeamAround"]
        .DynamicInvoke(new object[] {  missionPointer ,  origin ,  radius ,  teamNo  } );
    }

    public static void GetAgentCountAroundPosition( UIntPtr missionPointer ,  Int32 teamIndex ,  Vec2 position ,  Single radius ,   ref Int32 allyCount ,   ref Int32 enemyCount ) {
          NativeManager.OutboundManifest["IMBMission"]["GetAgentCountAroundPosition"]
        .DynamicInvoke(new object[] {  missionPointer ,  teamIndex ,  position ,  radius ,  allyCount ,  enemyCount  } );
    }

    public static Int32 FindAgentWithIndex( UIntPtr missionPointer ,  Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["FindAgentWithIndex"]
        .DynamicInvoke(new object[] {  missionPointer ,  index  } );
    }

    public static void SetRandomDecideTimeOfAgents( UIntPtr missionPointer ,  Int32 agentCount ,  IntPtr agentIndices ,  Single minAIReactionTime ,  Single maxAIReactionTime ) {
          NativeManager.OutboundManifest["IMBMission"]["SetRandomDecideTimeOfAgents"]
        .DynamicInvoke(new object[] {  missionPointer ,  agentCount ,  agentIndices ,  minAIReactionTime ,  maxAIReactionTime  } );
    }

    public static Single GetAverageMoraleOfAgents( UIntPtr missionPointer ,  Int32 agentCount ,  IntPtr agentIndices ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetAverageMoraleOfAgents"]
        .DynamicInvoke(new object[] {  missionPointer ,  agentCount ,  agentIndices  } );
    }

    public static WorldPosition GetBestSlopeTowardsDirection( UIntPtr missionPointer ,   ref WorldPosition centerPosition ,  Single halfsize ,   ref WorldPosition referencePosition ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBMission"]["GetBestSlopeTowardsDirection"]
        .DynamicInvoke(new object[] {  missionPointer ,  centerPosition ,  halfsize ,  referencePosition  } );
    }

    public static WorldPosition GetBestSlopeAngleHeightPosForDefending( UIntPtr missionPointer ,  WorldPosition enemyPosition ,  WorldPosition defendingPosition ,  Int32 sampleSize ,  Single distanceRatioAllowedFromDefendedPos ,  Single distanceSqrdAllowedFromBoundary ,  Single cosinusOfBestSlope ,  Single cosinusOfMaxAcceptedSlope ,  Single minSlopeScore ,  Single maxSlopeScore ,  Single excessiveSlopePenalty ,  Single nearConeCenterRatio ,  Single nearConeCenterBonus ,  Single heightDifferenceCeiling ,  Single maxDisplacementPenalty ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBMission"]["GetBestSlopeAngleHeightPosForDefending"]
        .DynamicInvoke(new object[] {  missionPointer ,  enemyPosition ,  defendingPosition ,  sampleSize ,  distanceRatioAllowedFromDefendedPos ,  distanceSqrdAllowedFromBoundary ,  cosinusOfBestSlope ,  cosinusOfMaxAcceptedSlope ,  minSlopeScore ,  maxSlopeScore ,  excessiveSlopePenalty ,  nearConeCenterRatio ,  nearConeCenterBonus ,  heightDifferenceCeiling ,  maxDisplacementPenalty  } );
    }

    public static void GetNearbyAgentsAux( UIntPtr missionPointer ,  Vec2 center ,  Single radius ,  Int32 teamIndex ,  Int32 friendOrEnemyOrAll ,  Int32 agentsArrayOffset ,   ref StackArray40Int agentIds ,   ref Int32 retrievedAgentCount ) {
          NativeManager.OutboundManifest["IMBMission"]["GetNearbyAgentsAux"]
        .DynamicInvoke(new object[] {  missionPointer ,  center ,  radius ,  teamIndex ,  friendOrEnemyOrAll ,  agentsArrayOffset ,  agentIds ,  retrievedAgentCount  } );
    }

    public static Vec2 GetWeightedPointOfEnemies( UIntPtr missionPointer ,  Int32 agentIndex ,  Vec2 basePoint ) {
         return   (Vec2)  NativeManager.OutboundManifest["IMBMission"]["GetWeightedPointOfEnemies"]
        .DynamicInvoke(new object[] {  missionPointer ,  agentIndex ,  basePoint  } );
    }

    public static Boolean IsFormationUnitPositionAvailable( UIntPtr missionPointer ,   ref WorldPosition orderPosition ,   ref WorldPosition unitPosition ,   ref WorldPosition nearestAvailableUnitPosition ,  Single manhattanDistance ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["IsFormationUnitPositionAvailable"]
        .DynamicInvoke(new object[] {  missionPointer ,  orderPosition ,  unitPosition ,  nearestAvailableUnitPosition ,  manhattanDistance  } );
    }

    public static WorldPosition GetStraightPathToTarget( UIntPtr scenePointer ,  Vec2 targetPosition ,  WorldPosition startingPosition ,  Single samplingDistance ,  Boolean stopAtObstacle ) {
         return   (WorldPosition)  NativeManager.OutboundManifest["IMBMission"]["GetStraightPathToTarget"]
        .DynamicInvoke(new object[] {  scenePointer ,  targetPosition ,  startingPosition ,  samplingDistance ,  stopAtObstacle  } );
    }

    public static void SetBowMissileSpeedModifier( UIntPtr missionPointer ,  Single modifier ) {
          NativeManager.OutboundManifest["IMBMission"]["SetBowMissileSpeedModifier"]
        .DynamicInvoke(new object[] {  missionPointer ,  modifier  } );
    }

    public static void SetCrossbowMissileSpeedModifier( UIntPtr missionPointer ,  Single modifier ) {
          NativeManager.OutboundManifest["IMBMission"]["SetCrossbowMissileSpeedModifier"]
        .DynamicInvoke(new object[] {  missionPointer ,  modifier  } );
    }

    public static void SetThrowingMissileSpeedModifier( UIntPtr missionPointer ,  Single modifier ) {
          NativeManager.OutboundManifest["IMBMission"]["SetThrowingMissileSpeedModifier"]
        .DynamicInvoke(new object[] {  missionPointer ,  modifier  } );
    }

    public static void SetMissileRangeModifier( UIntPtr missionPointer ,  Single modifier ) {
          NativeManager.OutboundManifest["IMBMission"]["SetMissileRangeModifier"]
        .DynamicInvoke(new object[] {  missionPointer ,  modifier  } );
    }

    public static void SetLastMovementKeyPressed( UIntPtr missionPointer ,  MovementControlFlag lastMovementKeyPressed ) {
          NativeManager.OutboundManifest["IMBMission"]["SetLastMovementKeyPressed"]
        .DynamicInvoke(new object[] {  missionPointer ,  lastMovementKeyPressed  } );
    }

    public static void FastForwardMission( UIntPtr missionPointer ,  Single startTime ,  Single endTime ) {
          NativeManager.OutboundManifest["IMBMission"]["FastForwardMission"]
        .DynamicInvoke(new object[] {  missionPointer ,  startTime ,  endTime  } );
    }

    public static Int32 GetDebugAgent( UIntPtr missionPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBMission"]["GetDebugAgent"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void SetDebugAgent( UIntPtr missionPointer ,  Int32 index ) {
          NativeManager.OutboundManifest["IMBMission"]["SetDebugAgent"]
        .DynamicInvoke(new object[] {  missionPointer ,  index  } );
    }

    public static void AddAiDebugText( UIntPtr missionPointer ,  Byte[] text ) {
          NativeManager.OutboundManifest["IMBMission"]["AddAiDebugText"]
        .DynamicInvoke(new object[] {  missionPointer ,  text  } );
    }

    public static ProximityMapSearchStructInternal ProximityMapBeginSearch( UIntPtr missionPointer ,  Vec2 searchPos ,  Single searchRadius ) {
         return   (ProximityMapSearchStructInternal)  NativeManager.OutboundManifest["IMBMission"]["ProximityMapBeginSearch"]
        .DynamicInvoke(new object[] {  missionPointer ,  searchPos ,  searchRadius  } );
    }

    public static void ProximityMapFindNext( UIntPtr missionPointer ,   ref ProximityMapSearchStructInternal searchStruct ) {
          NativeManager.OutboundManifest["IMBMission"]["ProximityMapFindNext"]
        .DynamicInvoke(new object[] {  missionPointer ,  searchStruct  } );
    }

    public static Single ProximityMapMaxSearchRadius( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["ProximityMapMaxSearchRadius"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static Single GetBiggestAgentCollisionPadding( UIntPtr missionPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetBiggestAgentCollisionPadding"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void SetMissionCorpseFadeOutTimeInSeconds( UIntPtr missionPointer ,  Single corpseFadeOutTimeInSeconds ) {
          NativeManager.OutboundManifest["IMBMission"]["SetMissionCorpseFadeOutTimeInSeconds"]
        .DynamicInvoke(new object[] {  missionPointer ,  corpseFadeOutTimeInSeconds  } );
    }

    public static void SetReportStuckAgentsMode( UIntPtr missionPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBMission"]["SetReportStuckAgentsMode"]
        .DynamicInvoke(new object[] {  missionPointer ,  value  } );
    }

    public static void BatchFormationUnitPositions( UIntPtr missionPointer ,  IntPtr orderedPositionIndices ,  IntPtr orderedLocalPositions ,  IntPtr availabilityTable ,  IntPtr globalPositionTable ,  WorldPosition orderPosition ,  Vec2 direction ,  Int32 fileCount ,  Int32 rankCount ) {
          NativeManager.OutboundManifest["IMBMission"]["BatchFormationUnitPositions"]
        .DynamicInvoke(new object[] {  missionPointer ,  orderedPositionIndices ,  orderedLocalPositions ,  availabilityTable ,  globalPositionTable ,  orderPosition ,  direction ,  fileCount ,  rankCount  } );
    }

    public static Boolean ToggleDisableFallAvoid() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMission"]["ToggleDisableFallAvoid"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetWaterLevelAtPosition( UIntPtr missionPointer ,  Vec2 position ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMission"]["GetWaterLevelAtPosition"]
        .DynamicInvoke(new object[] {  missionPointer ,  position  } );
    }

    }
}