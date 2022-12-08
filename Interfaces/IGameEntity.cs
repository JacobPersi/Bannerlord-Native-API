
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
    public static class IGameEntity {
    
    public static void SetAnimationSoundActivation( UIntPtr entityId ,  Boolean activate ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAnimationSoundActivation"]
        .DynamicInvoke(new object[] {  entityId ,  activate  } );
    }

    public static void CopyComponentsToSkeleton( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["CopyComponentsToSkeleton"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Vec3 GetBoundingBoxMin( UIntPtr entityId ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetBoundingBoxMin"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Vec3 GetBoundingBoxMax( UIntPtr entityId ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetBoundingBoxMax"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean HasFrameChanged( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasFrameChanged"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetExternalReferencesUsage( UIntPtr entityId ,  Boolean value ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetExternalReferencesUsage"]
        .DynamicInvoke(new object[] {  entityId ,  value  } );
    }

    public static void SetMorphFrameOfComponents( UIntPtr entityId ,  Single value ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetMorphFrameOfComponents"]
        .DynamicInvoke(new object[] {  entityId ,  value  } );
    }

    public static void AddEditDataUserToAllMeshes( UIntPtr entityId ,  Boolean entity_components ,  Boolean skeleton_components ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddEditDataUserToAllMeshes"]
        .DynamicInvoke(new object[] {  entityId ,  entity_components ,  skeleton_components  } );
    }

    public static void ReleaseEditDataUserToAllMeshes( UIntPtr entityId ,  Boolean entity_components ,  Boolean skeleton_components ) {
          NativeManager.OutboundManifest["IGameEntity"]["ReleaseEditDataUserToAllMeshes"]
        .DynamicInvoke(new object[] {  entityId ,  entity_components ,  skeleton_components  } );
    }

    public static void GetCameraParamsFromCameraScript( UIntPtr entityId ,  UIntPtr camPtr ,   ref Vec3 dof_params ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetCameraParamsFromCameraScript"]
        .DynamicInvoke(new object[] {  entityId ,  camPtr ,  dof_params  } );
    }

    public static void GetMeshBendedPosition( UIntPtr entityId ,   ref MatrixFrame worldSpacePosition ,   ref MatrixFrame output ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetMeshBendedPosition"]
        .DynamicInvoke(new object[] {  entityId ,  worldSpacePosition ,  output  } );
    }

    public static void BreakPrefab( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["BreakPrefab"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetAnimTreeChannelParameter( UIntPtr entityId ,  Single phase ,  Int32 channel_no ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAnimTreeChannelParameter"]
        .DynamicInvoke(new object[] {  entityId ,  phase ,  channel_no  } );
    }

    public static void DisableContour( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["DisableContour"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetAsContourEntity( UIntPtr entityId ,  UInt32 color ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAsContourEntity"]
        .DynamicInvoke(new object[] {  entityId ,  color  } );
    }

    public static void SetContourState( UIntPtr entityId ,  Boolean alwaysVisible ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetContourState"]
        .DynamicInvoke(new object[] {  entityId ,  alwaysVisible  } );
    }

    public static void RecomputeBoundingBox( UIntPtr entity ) {
          NativeManager.OutboundManifest["IGameEntity"]["RecomputeBoundingBox"]
        .DynamicInvoke(new object[] {  entity  } );
    }

    public static void SetBoundingboxDirty( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetBoundingboxDirty"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Vec3 GetGlobalBoxMax( UIntPtr entityId ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetGlobalBoxMax"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Vec3 GetGlobalBoxMin( UIntPtr entityId ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetGlobalBoxMin"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Single GetRadius( UIntPtr entityId ) {
         return   (Single)  NativeManager.OutboundManifest["IGameEntity"]["GetRadius"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void ChangeMetaMeshOrRemoveItIfNotExists( UIntPtr entityId ,  UIntPtr entityMetaMeshPointer ,  UIntPtr newMetaMeshPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["ChangeMetaMeshOrRemoveItIfNotExists"]
        .DynamicInvoke(new object[] {  entityId ,  entityMetaMeshPointer ,  newMetaMeshPointer  } );
    }

    public static void SetSkeleton( UIntPtr entityId ,  UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetSkeleton"]
        .DynamicInvoke(new object[] {  entityId ,  skeletonPointer  } );
    }

    public static NativeObjectPointer GetSkeleton( UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetSkeleton"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void RemoveAllChildren( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveAllChildren"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean CheckPointWithOrientedBoundingBox( UIntPtr entityId ,  Vec3 point ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["CheckPointWithOrientedBoundingBox"]
        .DynamicInvoke(new object[] {  entityId ,  point  } );
    }

    public static void ResumeParticleSystem( UIntPtr entityId ,  Boolean doChildren ) {
          NativeManager.OutboundManifest["IGameEntity"]["ResumeParticleSystem"]
        .DynamicInvoke(new object[] {  entityId ,  doChildren  } );
    }

    public static void PauseParticleSystem( UIntPtr entityId ,  Boolean doChildren ) {
          NativeManager.OutboundManifest["IGameEntity"]["PauseParticleSystem"]
        .DynamicInvoke(new object[] {  entityId ,  doChildren  } );
    }

    public static void BurstEntityParticle( UIntPtr entityId ,  Boolean doChildren ) {
          NativeManager.OutboundManifest["IGameEntity"]["BurstEntityParticle"]
        .DynamicInvoke(new object[] {  entityId ,  doChildren  } );
    }

    public static void SetRuntimeEmissionRateMultiplier( UIntPtr entityId ,  Single emission_rate_multiplier ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetRuntimeEmissionRateMultiplier"]
        .DynamicInvoke(new object[] {  entityId ,  emission_rate_multiplier  } );
    }

    public static Boolean HasBody( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasBody"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void AttachNavigationMeshFaces( UIntPtr entityId ,  Int32 faceGroupId ,  Boolean isConnected ,  Boolean isBlocker ,  Boolean autoLocalize ) {
          NativeManager.OutboundManifest["IGameEntity"]["AttachNavigationMeshFaces"]
        .DynamicInvoke(new object[] {  entityId ,  faceGroupId ,  isConnected ,  isBlocker ,  autoLocalize  } );
    }

    public static void SetEnforcedMaximumLodLevel( UIntPtr entityId ,  Int32 lodLevel ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetEnforcedMaximumLodLevel"]
        .DynamicInvoke(new object[] {  entityId ,  lodLevel  } );
    }

    public static Single GetLodLevelForDistanceSq( UIntPtr entityId ,  Single distanceSquared ) {
         return   (Single)  NativeManager.OutboundManifest["IGameEntity"]["GetLodLevelForDistanceSq"]
        .DynamicInvoke(new object[] {  entityId ,  distanceSquared  } );
    }

    public static Boolean IsEntitySelectedOnEditor( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsEntitySelectedOnEditor"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SelectEntityOnEditor( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["SelectEntityOnEditor"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void DeselectEntityOnEditor( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["DeselectEntityOnEditor"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetAsPredisplayEntity( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAsPredisplayEntity"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void RemoveFromPredisplayEntity( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveFromPredisplayEntity"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void GetPhysicsMinMax( UIntPtr entityId ,  Boolean includeChildren ,   ref Vec3 bbmin ,   ref Vec3 bbmax ,  Boolean returnLocal ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetPhysicsMinMax"]
        .DynamicInvoke(new object[] {  entityId ,  includeChildren ,  bbmin ,  bbmax ,  returnLocal  } );
    }

    public static Boolean IsDynamicBodyStationary( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsDynamicBodyStationary"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetCullMode( UIntPtr entityPtr ,  MBMeshCullingMode cullMode ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetCullMode"]
        .DynamicInvoke(new object[] {  entityPtr ,  cullMode  } );
    }

    public static NativeObjectPointer GetScene( UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetScene"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static NativeObjectPointer GetFirstMesh( UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetFirstMesh"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static NativeObjectPointer CreateFromPrefab( UIntPtr scenePointer ,  Byte[] prefabid ,  Boolean callScriptCallbacks ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["CreateFromPrefab"]
        .DynamicInvoke(new object[] {  scenePointer ,  prefabid ,  callScriptCallbacks  } );
    }

    public static void CallScriptCallbacks( UIntPtr entityPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["CallScriptCallbacks"]
        .DynamicInvoke(new object[] {  entityPointer  } );
    }

    public static NativeObjectPointer CreateFromPrefabWithInitialFrame( UIntPtr scenePointer ,  Byte[] prefabid ,   ref MatrixFrame frame ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["CreateFromPrefabWithInitialFrame"]
        .DynamicInvoke(new object[] {  scenePointer ,  prefabid ,  frame  } );
    }

    public static void AddComponent( UIntPtr pointer ,  UIntPtr componentPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddComponent"]
        .DynamicInvoke(new object[] {  pointer ,  componentPointer  } );
    }

    public static Boolean RemoveComponent( UIntPtr pointer ,  UIntPtr componentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["RemoveComponent"]
        .DynamicInvoke(new object[] {  pointer ,  componentPointer  } );
    }

    public static Boolean HasComponent( UIntPtr pointer ,  UIntPtr componentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasComponent"]
        .DynamicInvoke(new object[] {  pointer ,  componentPointer  } );
    }

    public static void UpdateGlobalBounds( UIntPtr entityPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["UpdateGlobalBounds"]
        .DynamicInvoke(new object[] {  entityPointer  } );
    }

    public static void ValidateBoundingBox( UIntPtr entityPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["ValidateBoundingBox"]
        .DynamicInvoke(new object[] {  entityPointer  } );
    }

    public static void ClearComponents( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["ClearComponents"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void ClearOnlyOwnComponents( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["ClearOnlyOwnComponents"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void ClearEntityComponents( UIntPtr entityId ,  Boolean resetAll ,  Boolean removeScripts ,  Boolean deleteChildEntities ) {
          NativeManager.OutboundManifest["IGameEntity"]["ClearEntityComponents"]
        .DynamicInvoke(new object[] {  entityId ,  resetAll ,  removeScripts ,  deleteChildEntities  } );
    }

    public static void UpdateVisibilityMask( UIntPtr entityPtr ) {
          NativeManager.OutboundManifest["IGameEntity"]["UpdateVisibilityMask"]
        .DynamicInvoke(new object[] {  entityPtr  } );
    }

    public static Boolean CheckResources( UIntPtr entityId ,  Boolean addToQueue ,  Boolean checkFaceResources ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["CheckResources"]
        .DynamicInvoke(new object[] {  entityId ,  addToQueue ,  checkFaceResources  } );
    }

    public static void SetMobility( UIntPtr entityId ,  Int32 mobility ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetMobility"]
        .DynamicInvoke(new object[] {  entityId ,  mobility  } );
    }

    public static void AddMesh( UIntPtr entityId ,  UIntPtr mesh ,  Boolean recomputeBoundingBox ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddMesh"]
        .DynamicInvoke(new object[] {  entityId ,  mesh ,  recomputeBoundingBox  } );
    }

    public static void AddMultiMeshToSkeleton( UIntPtr gameEntity ,  UIntPtr multiMesh ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddMultiMeshToSkeleton"]
        .DynamicInvoke(new object[] {  gameEntity ,  multiMesh  } );
    }

    public static void AddMultiMeshToSkeletonBone( UIntPtr gameEntity ,  UIntPtr multiMesh ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddMultiMeshToSkeletonBone"]
        .DynamicInvoke(new object[] {  gameEntity ,  multiMesh ,  boneIndex  } );
    }

    public static void SetAsReplayEntity( UIntPtr gameEntity ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAsReplayEntity"]
        .DynamicInvoke(new object[] {  gameEntity  } );
    }

    public static void SetClothMaxDistanceMultiplier( UIntPtr gameEntity ,  Single multiplier ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetClothMaxDistanceMultiplier"]
        .DynamicInvoke(new object[] {  gameEntity ,  multiplier  } );
    }

    public static void SetPreviousFrameInvalid( UIntPtr gameEntity ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetPreviousFrameInvalid"]
        .DynamicInvoke(new object[] {  gameEntity  } );
    }

    public static void RemoveMultiMeshFromSkeleton( UIntPtr gameEntity ,  UIntPtr multiMesh ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveMultiMeshFromSkeleton"]
        .DynamicInvoke(new object[] {  gameEntity ,  multiMesh  } );
    }

    public static void RemoveMultiMeshFromSkeletonBone( UIntPtr gameEntity ,  UIntPtr multiMesh ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveMultiMeshFromSkeletonBone"]
        .DynamicInvoke(new object[] {  gameEntity ,  multiMesh ,  boneIndex  } );
    }

    public static Boolean RemoveComponentWithMesh( UIntPtr entityId ,  UIntPtr mesh ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["RemoveComponentWithMesh"]
        .DynamicInvoke(new object[] {  entityId ,  mesh  } );
    }

    public static Int32 GetGuid( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetGuid"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean IsGuidValid( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsGuidValid"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void AddSphereAsBody( UIntPtr entityId ,  Vec3 center ,  Single radius ,  UInt32 bodyFlags ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddSphereAsBody"]
        .DynamicInvoke(new object[] {  entityId ,  center ,  radius ,  bodyFlags  } );
    }

    public static void GetQuickBoneEntitialFrame( UIntPtr entityId ,  SByte index ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetQuickBoneEntitialFrame"]
        .DynamicInvoke(new object[] {  entityId ,  index ,  frame  } );
    }

    public static NativeObjectPointer CreateEmpty( UIntPtr scenePointer ,  Boolean isModifiableFromEditor ,  UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["CreateEmpty"]
        .DynamicInvoke(new object[] {  scenePointer ,  isModifiableFromEditor ,  entityId  } );
    }

    public static NativeObjectPointer CreateEmptyWithoutScene() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["CreateEmptyWithoutScene"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void Remove( UIntPtr entityId ,  Int32 removeReason ) {
          NativeManager.OutboundManifest["IGameEntity"]["Remove"]
        .DynamicInvoke(new object[] {  entityId ,  removeReason  } );
    }

    public static NativeObjectPointer FindWithName( UIntPtr scenePointer ,  Byte[] name ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["FindWithName"]
        .DynamicInvoke(new object[] {  scenePointer ,  name  } );
    }

    public static void GetFrame( UIntPtr entityId ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetFrame"]
        .DynamicInvoke(new object[] {  entityId ,  outFrame  } );
    }

    public static void SetFrame( UIntPtr entityId ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetFrame"]
        .DynamicInvoke(new object[] {  entityId ,  frame  } );
    }

    public static void SetClothComponentKeepState( UIntPtr entityId ,  UIntPtr metaMesh ,  Boolean keepState ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetClothComponentKeepState"]
        .DynamicInvoke(new object[] {  entityId ,  metaMesh ,  keepState  } );
    }

    public static void SetClothComponentKeepStateOfAllMeshes( UIntPtr entityId ,  Boolean keepState ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetClothComponentKeepStateOfAllMeshes"]
        .DynamicInvoke(new object[] {  entityId ,  keepState  } );
    }

    public static void UpdateTriadFrameForEditor( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["UpdateTriadFrameForEditor"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void GetGlobalFrame( UIntPtr meshPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IGameEntity"]["GetGlobalFrame"]
        .DynamicInvoke(new object[] {  meshPointer ,  outFrame  } );
    }

    public static void SetGlobalFrame( UIntPtr entityId ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetGlobalFrame"]
        .DynamicInvoke(new object[] {  entityId ,  frame  } );
    }

    public static Boolean HasPhysicsBody( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasPhysicsBody"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetLocalPosition( UIntPtr entityId ,  Vec3 position ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetLocalPosition"]
        .DynamicInvoke(new object[] {  entityId ,  position  } );
    }

    public static UInt32 GetEntityFlags( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetEntityFlags"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetEntityFlags( UIntPtr entityId ,  UInt32 entityFlags ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetEntityFlags"]
        .DynamicInvoke(new object[] {  entityId ,  entityFlags  } );
    }

    public static UInt32 GetEntityVisibilityFlags( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetEntityVisibilityFlags"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetEntityVisibilityFlags( UIntPtr entityId ,  UInt32 entityVisibilityFlags ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetEntityVisibilityFlags"]
        .DynamicInvoke(new object[] {  entityId ,  entityVisibilityFlags  } );
    }

    public static UInt32 GetBodyFlags( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetBodyFlags"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetBodyFlags( UIntPtr entityId ,  UInt32 bodyFlags ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetBodyFlags"]
        .DynamicInvoke(new object[] {  entityId ,  bodyFlags  } );
    }

    public static UInt32 GetPhysicsDescBodyFlags( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetPhysicsDescBodyFlags"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Vec3 GetCenterOfMass( UIntPtr entityId ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetCenterOfMass"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Single GetMass( UIntPtr entityId ) {
         return   (Single)  NativeManager.OutboundManifest["IGameEntity"]["GetMass"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetMass( UIntPtr entityId ,  Single mass ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetMass"]
        .DynamicInvoke(new object[] {  entityId ,  mass  } );
    }

    public static void SetMassSpaceInertia( UIntPtr entityId ,   ref Vec3 inertia ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetMassSpaceInertia"]
        .DynamicInvoke(new object[] {  entityId ,  inertia  } );
    }

    public static void SetDamping( UIntPtr entityId ,  Single linearDamping ,  Single angularDamping ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetDamping"]
        .DynamicInvoke(new object[] {  entityId ,  linearDamping ,  angularDamping  } );
    }

    public static void DisableGravity( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["DisableGravity"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetBodyFlagsRecursive( UIntPtr entityId ,  UInt32 bodyFlags ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetBodyFlagsRecursive"]
        .DynamicInvoke(new object[] {  entityId ,  bodyFlags  } );
    }

    public static Vec3 GetGlobalScale( UIntPtr entity ) {
         return   (Vec3)  NativeManager.OutboundManifest["IGameEntity"]["GetGlobalScale"]
        .DynamicInvoke(new object[] {  entity  } );
    }

    public static NativeObjectPointer GetBodyShape( UIntPtr entity ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetBodyShape"]
        .DynamicInvoke(new object[] {  entity  } );
    }

    public static void SetBodyShape( UIntPtr entityId ,  UIntPtr shape ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetBodyShape"]
        .DynamicInvoke(new object[] {  entityId ,  shape  } );
    }

    public static void AddPhysics( UIntPtr entityId ,  UIntPtr body ,  Single mass ,   ref Vec3 localCenterOfMass ,   ref Vec3 initialVelocity ,   ref Vec3 initialAngularVelocity ,  Int32 physicsMaterial ,  Boolean isStatic ,  Int32 collisionGroupID ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddPhysics"]
        .DynamicInvoke(new object[] {  entityId ,  body ,  mass ,  localCenterOfMass ,  initialVelocity ,  initialAngularVelocity ,  physicsMaterial ,  isStatic ,  collisionGroupID  } );
    }

    public static void RemovePhysics( UIntPtr entityId ,  Boolean clearingTheScene ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemovePhysics"]
        .DynamicInvoke(new object[] {  entityId ,  clearingTheScene  } );
    }

    public static void SetPhysicsState( UIntPtr entityId ,  Boolean isEnabled ,  Boolean setChildren ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetPhysicsState"]
        .DynamicInvoke(new object[] {  entityId ,  isEnabled ,  setChildren  } );
    }

    public static Boolean GetPhysicsState( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["GetPhysicsState"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void AddDistanceJoint( UIntPtr entityId ,  UIntPtr otherEntityId ,  Single minDistance ,  Single maxDistance ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddDistanceJoint"]
        .DynamicInvoke(new object[] {  entityId ,  otherEntityId ,  minDistance ,  maxDistance  } );
    }

    public static Boolean HasPhysicsDefinition( UIntPtr entityId ,  Int32 excludeFlags ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasPhysicsDefinition"]
        .DynamicInvoke(new object[] {  entityId ,  excludeFlags  } );
    }

    public static void RemoveEnginePhysics( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveEnginePhysics"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean IsEngineBodySleeping( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsEngineBodySleeping"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void EnableDynamicBody( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["EnableDynamicBody"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void DisableDynamicBodySimulation( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["DisableDynamicBodySimulation"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void ApplyLocalImpulseToDynamicBody( UIntPtr entityId ,   ref Vec3 localPosition ,   ref Vec3 impulse ) {
          NativeManager.OutboundManifest["IGameEntity"]["ApplyLocalImpulseToDynamicBody"]
        .DynamicInvoke(new object[] {  entityId ,  localPosition ,  impulse  } );
    }

    public static void ApplyAccelerationToDynamicBody( UIntPtr entityId ,   ref Vec3 acceleration ) {
          NativeManager.OutboundManifest["IGameEntity"]["ApplyAccelerationToDynamicBody"]
        .DynamicInvoke(new object[] {  entityId ,  acceleration  } );
    }

    public static void ApplyForceToDynamicBody( UIntPtr entityId ,   ref Vec3 force ) {
          NativeManager.OutboundManifest["IGameEntity"]["ApplyForceToDynamicBody"]
        .DynamicInvoke(new object[] {  entityId ,  force  } );
    }

    public static void ApplyLocalForceToDynamicBody( UIntPtr entityId ,   ref Vec3 localPosition ,   ref Vec3 force ) {
          NativeManager.OutboundManifest["IGameEntity"]["ApplyLocalForceToDynamicBody"]
        .DynamicInvoke(new object[] {  entityId ,  localPosition ,  force  } );
    }

    public static void AddChild( UIntPtr parententity ,  UIntPtr childentity ,  Boolean autoLocalizeFrame ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddChild"]
        .DynamicInvoke(new object[] {  parententity ,  childentity ,  autoLocalizeFrame  } );
    }

    public static void RemoveChild( UIntPtr parentEntity ,  UIntPtr childEntity ,  Boolean keepPhysics ,  Boolean keepScenePointer ,  Boolean callScriptCallbacks ,  Int32 removeReason ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveChild"]
        .DynamicInvoke(new object[] {  parentEntity ,  childEntity ,  keepPhysics ,  keepScenePointer ,  callScriptCallbacks ,  removeReason  } );
    }

    public static Int32 GetChildCount( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetChildCount"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static NativeObjectPointer GetChild( UIntPtr entityId ,  Int32 childIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetChild"]
        .DynamicInvoke(new object[] {  entityId ,  childIndex  } );
    }

    public static NativeObjectPointer GetParent( UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetParent"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean HasComplexAnimTree( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasComplexAnimTree"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Int32 GetScriptComponent( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetScriptComponent"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Int32 GetScriptComponentCount( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetScriptComponentCount"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Int32 GetScriptComponentAtIndex( UIntPtr entityId ,  Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetScriptComponentAtIndex"]
        .DynamicInvoke(new object[] {  entityId ,  index  } );
    }

    public static void SetEntityEnvMapVisibility( UIntPtr entityId ,  Boolean value ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetEntityEnvMapVisibility"]
        .DynamicInvoke(new object[] {  entityId ,  value  } );
    }

    public static void CreateAndAddScriptComponent( UIntPtr entityId ,  Byte[] name ) {
          NativeManager.OutboundManifest["IGameEntity"]["CreateAndAddScriptComponent"]
        .DynamicInvoke(new object[] {  entityId ,  name  } );
    }

    public static void RemoveScriptComponent( UIntPtr entityId ,  UIntPtr scriptComponentPtr ,  Int32 removeReason ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveScriptComponent"]
        .DynamicInvoke(new object[] {  entityId ,  scriptComponentPtr ,  removeReason  } );
    }

    public static Boolean PrefabExists( Byte[] prefabName ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["PrefabExists"]
        .DynamicInvoke(new object[] {  prefabName  } );
    }

    public static Boolean IsGhostObject( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsGhostObject"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean HasScriptComponent( UIntPtr entityId ,  Byte[] scName ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasScriptComponent"]
        .DynamicInvoke(new object[] {  entityId ,  scName  } );
    }

    public static Int32 GetName( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetName"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static NativeObjectPointer GetFirstEntityWithTag( UIntPtr scenePointer ,  Byte[] tag ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetFirstEntityWithTag"]
        .DynamicInvoke(new object[] {  scenePointer ,  tag  } );
    }

    public static NativeObjectPointer GetNextEntityWithTag( UIntPtr currententityId ,  Byte[] tag ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetNextEntityWithTag"]
        .DynamicInvoke(new object[] {  currententityId ,  tag  } );
    }

    public static NativeObjectPointer GetFirstEntityWithTagExpression( UIntPtr scenePointer ,  Byte[] tagExpression ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetFirstEntityWithTagExpression"]
        .DynamicInvoke(new object[] {  scenePointer ,  tagExpression  } );
    }

    public static NativeObjectPointer GetNextEntityWithTagExpression( UIntPtr currententityId ,  Byte[] tagExpression ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetNextEntityWithTagExpression"]
        .DynamicInvoke(new object[] {  currententityId ,  tagExpression  } );
    }

    public static NativeObjectPointer GetNextPrefab( UIntPtr currentPrefab ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetNextPrefab"]
        .DynamicInvoke(new object[] {  currentPrefab  } );
    }

    public static NativeObjectPointer CopyFromPrefab( UIntPtr prefab ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["CopyFromPrefab"]
        .DynamicInvoke(new object[] {  prefab  } );
    }

    public static void SetUpgradeLevelMask( UIntPtr prefab ,  UInt32 mask ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetUpgradeLevelMask"]
        .DynamicInvoke(new object[] {  prefab ,  mask  } );
    }

    public static UInt32 GetUpgradeLevelMask( UIntPtr prefab ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetUpgradeLevelMask"]
        .DynamicInvoke(new object[] {  prefab  } );
    }

    public static UInt32 GetUpgradeLevelMaskCumulative( UIntPtr prefab ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetUpgradeLevelMaskCumulative"]
        .DynamicInvoke(new object[] {  prefab  } );
    }

    public static Int32 GetOldPrefabName( UIntPtr prefab ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetOldPrefabName"]
        .DynamicInvoke(new object[] {  prefab  } );
    }

    public static Int32 GetPrefabName( UIntPtr prefab ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetPrefabName"]
        .DynamicInvoke(new object[] {  prefab  } );
    }

    public static void CopyScriptComponentFromAnotherEntity( UIntPtr prefab ,  UIntPtr other_prefab ,  Byte[] script_name ) {
          NativeManager.OutboundManifest["IGameEntity"]["CopyScriptComponentFromAnotherEntity"]
        .DynamicInvoke(new object[] {  prefab ,  other_prefab ,  script_name  } );
    }

    public static void AddMultiMesh( UIntPtr entityId ,  UIntPtr multiMeshPtr ,  Boolean updateVisMask ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddMultiMesh"]
        .DynamicInvoke(new object[] {  entityId ,  multiMeshPtr ,  updateVisMask  } );
    }

    public static Boolean RemoveMultiMesh( UIntPtr entityId ,  UIntPtr multiMeshPtr ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["RemoveMultiMesh"]
        .DynamicInvoke(new object[] {  entityId ,  multiMeshPtr  } );
    }

    public static Int32 GetComponentCount( UIntPtr entityId ,  ComponentType componentType ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetComponentCount"]
        .DynamicInvoke(new object[] {  entityId ,  componentType  } );
    }

    public static NativeObjectPointer GetComponentAtIndex( UIntPtr entityId ,  ComponentType componentType ,  Int32 index ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetComponentAtIndex"]
        .DynamicInvoke(new object[] {  entityId ,  componentType ,  index  } );
    }

    public static void AddAllMeshesOfGameEntity( UIntPtr entityId ,  UIntPtr copiedEntityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddAllMeshesOfGameEntity"]
        .DynamicInvoke(new object[] {  entityId ,  copiedEntityId  } );
    }

    public static void SetFrameChanged( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetFrameChanged"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean IsVisibleIncludeParents( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["IsVisibleIncludeParents"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static UInt32 GetVisibilityLevelMaskIncludingParents( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetVisibilityLevelMaskIncludingParents"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean GetEditModeLevelVisibility( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["GetEditModeLevelVisibility"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean GetVisibilityExcludeParents( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["GetVisibilityExcludeParents"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetVisibilityExcludeParents( UIntPtr entityId ,  Boolean visibility ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetVisibilityExcludeParents"]
        .DynamicInvoke(new object[] {  entityId ,  visibility  } );
    }

    public static void SetAlpha( UIntPtr entityId ,  Single alpha ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetAlpha"]
        .DynamicInvoke(new object[] {  entityId ,  alpha  } );
    }

    public static void SetReadyToRender( UIntPtr entityId ,  Boolean ready ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetReadyToRender"]
        .DynamicInvoke(new object[] {  entityId ,  ready  } );
    }

    public static void AddParticleSystemComponent( UIntPtr entityId ,  Byte[] particleid ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddParticleSystemComponent"]
        .DynamicInvoke(new object[] {  entityId ,  particleid  } );
    }

    public static void RemoveAllParticleSystems( UIntPtr entityId ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveAllParticleSystems"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Int32 GetTags( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IGameEntity"]["GetTags"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static Boolean HasTag( UIntPtr entityId ,  Byte[] tag ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["HasTag"]
        .DynamicInvoke(new object[] {  entityId ,  tag  } );
    }

    public static void AddTag( UIntPtr entityId ,  Byte[] tag ) {
          NativeManager.OutboundManifest["IGameEntity"]["AddTag"]
        .DynamicInvoke(new object[] {  entityId ,  tag  } );
    }

    public static void RemoveTag( UIntPtr entityId ,  Byte[] tag ) {
          NativeManager.OutboundManifest["IGameEntity"]["RemoveTag"]
        .DynamicInvoke(new object[] {  entityId ,  tag  } );
    }

    public static Boolean AddLight( UIntPtr entityId ,  UIntPtr lightPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IGameEntity"]["AddLight"]
        .DynamicInvoke(new object[] {  entityId ,  lightPointer  } );
    }

    public static NativeObjectPointer GetLight( UIntPtr entityId ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntity"]["GetLight"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetMaterialForAllMeshes( UIntPtr entityId ,  UIntPtr materialPointer ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetMaterialForAllMeshes"]
        .DynamicInvoke(new object[] {  entityId ,  materialPointer  } );
    }

    public static void SetName( UIntPtr entityId ,  Byte[] name ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetName"]
        .DynamicInvoke(new object[] {  entityId ,  name  } );
    }

    public static void SetVectorArgument( UIntPtr entityId ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetVectorArgument"]
        .DynamicInvoke(new object[] {  entityId ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void SetFactor2Color( UIntPtr entityId ,  UInt32 factor2Color ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetFactor2Color"]
        .DynamicInvoke(new object[] {  entityId ,  factor2Color  } );
    }

    public static void SetFactorColor( UIntPtr entityId ,  UInt32 factorColor ) {
          NativeManager.OutboundManifest["IGameEntity"]["SetFactorColor"]
        .DynamicInvoke(new object[] {  entityId ,  factorColor  } );
    }

    public static UInt32 GetFactorColor( UIntPtr entityId ) {
         return   (UInt32)  NativeManager.OutboundManifest["IGameEntity"]["GetFactorColor"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    }
}