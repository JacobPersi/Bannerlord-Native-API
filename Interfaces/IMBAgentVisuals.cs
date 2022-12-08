
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
    public static class IMBAgentVisuals {
    
    public static void ValidateAgentVisualsReseted( UIntPtr scenePointer ,  UIntPtr agentRendererSceneControllerPointer ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ValidateAgentVisualsReseted"]
        .DynamicInvoke(new object[] {  scenePointer ,  agentRendererSceneControllerPointer  } );
    }

    public static UIntPtr CreateAgentRendererSceneController( UIntPtr scenePointer ,  Int32 maxRenderCount ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["IMBAgentVisuals"]["CreateAgentRendererSceneController"]
        .DynamicInvoke(new object[] {  scenePointer ,  maxRenderCount  } );
    }

    public static void DestructAgentRendererSceneController( UIntPtr scenePointer ,  UIntPtr agentRendererSceneControllerPointer ,  Boolean deleteThisFrame ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["DestructAgentRendererSceneController"]
        .DynamicInvoke(new object[] {  scenePointer ,  agentRendererSceneControllerPointer ,  deleteThisFrame  } );
    }

    public static void SetDoTimerBasedForcedSkeletonUpdates( UIntPtr agentRendererSceneControllerPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetDoTimerBasedForcedSkeletonUpdates"]
        .DynamicInvoke(new object[] {  agentRendererSceneControllerPointer ,  value  } );
    }

    public static void SetEnforcedVisibilityForAllAgents( UIntPtr scenePointer ,  UIntPtr agentRendererSceneControllerPointer ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetEnforcedVisibilityForAllAgents"]
        .DynamicInvoke(new object[] {  scenePointer ,  agentRendererSceneControllerPointer  } );
    }

    public static NativeObjectPointer CreateAgentVisuals( UIntPtr scenePtr ,  Byte[] ownerName ,  Vec3 eyeOffset ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["CreateAgentVisuals"]
        .DynamicInvoke(new object[] {  scenePtr ,  ownerName ,  eyeOffset  } );
    }

    public static void Tick( UIntPtr agentVisualsId ,  UIntPtr parentAgentVisualsId ,  Single dt ,  Boolean entityMoving ,  Single speed ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["Tick"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  parentAgentVisualsId ,  dt ,  entityMoving ,  speed  } );
    }

    public static void SetEntity( UIntPtr agentVisualsId ,  UIntPtr entityPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetEntity"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  entityPtr  } );
    }

    public static void SetSkeleton( UIntPtr agentVisualsId ,  UIntPtr skeletonPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetSkeleton"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  skeletonPtr  } );
    }

    public static void FillEntityWithBodyMeshesWithoutAgentVisuals( UIntPtr entityPoinbter ,   ref SkinGenerationParams skinParams ,   ref BodyProperties bodyProperties ,  UIntPtr glovesMesh ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["FillEntityWithBodyMeshesWithoutAgentVisuals"]
        .DynamicInvoke(new object[] {  entityPoinbter ,  skinParams ,  bodyProperties ,  glovesMesh  } );
    }

    public static void AddSkinMeshesToAgentEntity( UIntPtr agentVisualsId ,   ref SkinGenerationParams skinParams ,   ref BodyProperties bodyProperties ,  Boolean useGPUMorph ,  Boolean useFaceCache ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["AddSkinMeshesToAgentEntity"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  skinParams ,  bodyProperties ,  useGPUMorph ,  useFaceCache  } );
    }

    public static void SetLodAtlasShadingIndex( UIntPtr agentVisualsId ,  Int32 index ,  Boolean useTeamColor ,  UInt32 teamColor1 ,  UInt32 teamColor2 ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetLodAtlasShadingIndex"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  index ,  useTeamColor ,  teamColor1 ,  teamColor2  } );
    }

    public static void SetFaceGenerationParams( UIntPtr agentVisualsId ,  FaceGenerationParams faceGenerationParams ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetFaceGenerationParams"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  faceGenerationParams  } );
    }

    public static void StartRhubarbRecord( UIntPtr agentVisualsId ,  Byte[] path ,  Int32 soundId ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["StartRhubarbRecord"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  path ,  soundId  } );
    }

    public static void ClearVisualComponents( UIntPtr agentVisualsId ,  Boolean removeSkeleton ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ClearVisualComponents"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  removeSkeleton  } );
    }

    public static void LazyUpdateAgentRendererData( UIntPtr agentVisualsId ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["LazyUpdateAgentRendererData"]
        .DynamicInvoke(new object[] {  agentVisualsId  } );
    }

    public static void AddMesh( UIntPtr agentVisualsId ,  UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["AddMesh"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  meshPointer  } );
    }

    public static void RemoveMesh( UIntPtr agentVisualsPtr ,  UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["RemoveMesh"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  meshPointer  } );
    }

    public static void AddMultiMesh( UIntPtr agentVisualsPtr ,  UIntPtr multiMeshPointer ,  Int32 bodyMeshIndex ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["AddMultiMesh"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  multiMeshPointer ,  bodyMeshIndex  } );
    }

    public static void AddHorseReinsClothMesh( UIntPtr agentVisualsPtr ,  UIntPtr reinMeshPointer ,  UIntPtr ropeMeshPointer ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["AddHorseReinsClothMesh"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  reinMeshPointer ,  ropeMeshPointer  } );
    }

    public static void UpdateSkeletonScale( UIntPtr agentVisualsId ,  Int32 bodyDeformType ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["UpdateSkeletonScale"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  bodyDeformType  } );
    }

    public static void ApplySkeletonScale( UIntPtr agentVisualsId ,  Vec3 mountSitBoneScale ,  Single mountRadiusAdder ,  Byte boneCount ,  IntPtr boneIndices ,  IntPtr boneScales ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ApplySkeletonScale"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  mountSitBoneScale ,  mountRadiusAdder ,  boneCount ,  boneIndices ,  boneScales  } );
    }

    public static void BatchLastLodMeshes( UIntPtr agentVisualsPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["BatchLastLodMeshes"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void RemoveMultiMesh( UIntPtr agentVisualsPtr ,  UIntPtr multiMeshPointer ,  Int32 bodyMeshIndex ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["RemoveMultiMesh"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  multiMeshPointer ,  bodyMeshIndex  } );
    }

    public static void AddWeaponToAgentEntity( UIntPtr agentVisualsPtr ,  Int32 slotIndex ,   ref WeaponDataAsNative agentEntityData ,  IntPtr weaponStatsData ,  Int32 weaponStatsDataLength ,   ref WeaponDataAsNative agentEntityAmmoData ,  IntPtr ammoWeaponStatsData ,  Int32 ammoWeaponStatsDataLength ,  UIntPtr cachedEntity ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["AddWeaponToAgentEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  slotIndex ,  agentEntityData ,  weaponStatsData ,  weaponStatsDataLength ,  agentEntityAmmoData ,  ammoWeaponStatsData ,  ammoWeaponStatsDataLength ,  cachedEntity  } );
    }

    public static void UpdateQuiverMeshesWithoutAgent( UIntPtr agentVisualsId ,  Int32 weaponIndex ,  Int32 ammoCountToShow ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["UpdateQuiverMeshesWithoutAgent"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  weaponIndex ,  ammoCountToShow  } );
    }

    public static void SetWieldedWeaponIndices( UIntPtr agentVisualsId ,  Int32 slotIndexRightHand ,  Int32 slotIndexLeftHand ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetWieldedWeaponIndices"]
        .DynamicInvoke(new object[] {  agentVisualsId ,  slotIndexRightHand ,  slotIndexLeftHand  } );
    }

    public static void ClearAllWeaponMeshes( UIntPtr agentVisualsPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ClearAllWeaponMeshes"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void ClearWeaponMeshes( UIntPtr agentVisualsPtr ,  Int32 weaponVisualIndex ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ClearWeaponMeshes"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  weaponVisualIndex  } );
    }

    public static void MakeVoice( UIntPtr agentVisualsPtr ,  Int32 voiceId ,   ref Vec3 position ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["MakeVoice"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  voiceId ,  position  } );
    }

    public static void SetSetupMorphNode( UIntPtr agentVisualsPtr ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetSetupMorphNode"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  value  } );
    }

    public static void UseScaledWeapons( UIntPtr agentVisualsPtr ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["UseScaledWeapons"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  value  } );
    }

    public static void SetClothComponentKeepStateOfAllMeshes( UIntPtr agentVisualsPtr ,  Boolean keepState ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetClothComponentKeepStateOfAllMeshes"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  keepState  } );
    }

    public static Vec3 GetCurrentHelmetScalingFactor( UIntPtr agentVisualsPtr ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetCurrentHelmetScalingFactor"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void SetVoiceDefinitionIndex( UIntPtr agentVisualsPtr ,  Int32 voiceDefinitionIndex ,  Single voicePitch ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetVoiceDefinitionIndex"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  voiceDefinitionIndex ,  voicePitch  } );
    }

    public static void SetAgentLodMakeZeroOrMax( UIntPtr agentVisualsPtr ,  Boolean makeZero ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetAgentLodMakeZeroOrMax"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  makeZero  } );
    }

    public static void SetAgentLocalSpeed( UIntPtr agentVisualsPtr ,  Vec2 speed ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetAgentLocalSpeed"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  speed  } );
    }

    public static void SetLookDirection( UIntPtr agentVisualsPtr ,  Vec3 direction ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetLookDirection"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  direction  } );
    }

    public static void Reset( UIntPtr agentVisualsPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["Reset"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void ResetNextFrame( UIntPtr agentVisualsPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["ResetNextFrame"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void SetFrame( UIntPtr agentVisualsPtr ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetFrame"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  frame  } );
    }

    public static void GetFrame( UIntPtr agentVisualsPtr ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["GetFrame"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  outFrame  } );
    }

    public static void GetGlobalFrame( UIntPtr agentVisualsPtr ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["GetGlobalFrame"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  outFrame  } );
    }

    public static void SetVisible( UIntPtr agentVisualsPtr ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetVisible"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  value  } );
    }

    public static Boolean GetVisible( UIntPtr agentVisualsPtr ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetVisible"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static NativeObjectPointer GetSkeleton( UIntPtr agentVisualsPtr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetSkeleton"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static NativeObjectPointer GetEntity( UIntPtr agentVisualsPtr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static Vec3 GetGlobalStableEyePoint( UIntPtr agentVisualsPtr ,  Boolean isHumanoid ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetGlobalStableEyePoint"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  isHumanoid  } );
    }

    public static Vec3 GetGlobalStableNeckPoint( UIntPtr agentVisualsPtr ,  Boolean isHumanoid ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetGlobalStableNeckPoint"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  isHumanoid  } );
    }

    public static SByte GetRealBoneIndex( UIntPtr agentVisualsPtr ,  HumanBone boneType ) {
         return   (SByte)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetRealBoneIndex"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  boneType  } );
    }

    public static NativeObjectPointer AddPrefabToAgentVisualBoneByBoneType( UIntPtr agentVisualsPtr ,  Byte[] prefabName ,  HumanBone boneType ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["AddPrefabToAgentVisualBoneByBoneType"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  prefabName ,  boneType  } );
    }

    public static NativeObjectPointer AddPrefabToAgentVisualBoneByRealBoneIndex( UIntPtr agentVisualsPtr ,  Byte[] prefabName ,  SByte realBoneIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["AddPrefabToAgentVisualBoneByRealBoneIndex"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  prefabName ,  realBoneIndex  } );
    }

    public static NativeObjectPointer GetAttachedWeaponEntity( UIntPtr agentVisualsPtr ,  Int32 attachedWeaponIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBAgentVisuals"]["GetAttachedWeaponEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  attachedWeaponIndex  } );
    }

    public static void CreateParticleSystemAttachedToBone( UIntPtr agentVisualsPtr ,  Int32 runtimeParticleindex ,  SByte boneIndex ,   ref MatrixFrame boneLocalParticleFrame ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["CreateParticleSystemAttachedToBone"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  runtimeParticleindex ,  boneIndex ,  boneLocalParticleFrame  } );
    }

    public static Boolean CheckResources( UIntPtr agentVisualsPtr ,  Boolean addToQueue ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgentVisuals"]["CheckResources"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  addToQueue  } );
    }

    public static Boolean AddChildEntity( UIntPtr agentVisualsPtr ,  UIntPtr EntityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAgentVisuals"]["AddChildEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  EntityId  } );
    }

    public static void SetClothWindToWeaponAtIndex( UIntPtr agentVisualsPtr ,  Vec3 windDirection ,  Boolean isLocal ,  Int32 index ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetClothWindToWeaponAtIndex"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  windDirection ,  isLocal ,  index  } );
    }

    public static void RemoveChildEntity( UIntPtr agentVisualsPtr ,  UIntPtr EntityId ,  Int32 removeReason ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["RemoveChildEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  EntityId ,  removeReason  } );
    }

    public static void DisableContour( UIntPtr agentVisualsPtr ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["DisableContour"]
        .DynamicInvoke(new object[] {  agentVisualsPtr  } );
    }

    public static void SetAsContourEntity( UIntPtr agentVisualsPtr ,  UInt32 color ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetAsContourEntity"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  color  } );
    }

    public static void SetContourState( UIntPtr agentVisualsPtr ,  Boolean alwaysVisible ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetContourState"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  alwaysVisible  } );
    }

    public static void SetEnableOcclusionCulling( UIntPtr agentVisualsPtr ,  Boolean enable ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["SetEnableOcclusionCulling"]
        .DynamicInvoke(new object[] {  agentVisualsPtr ,  enable  } );
    }

    public static void GetBoneTypeData( UIntPtr pointer ,  SByte boneIndex ,   ref BoneBodyTypeData boneBodyTypeData ) {
          NativeManager.OutboundManifest["IMBAgentVisuals"]["GetBoneTypeData"]
        .DynamicInvoke(new object[] {  pointer ,  boneIndex ,  boneBodyTypeData  } );
    }

    }
}