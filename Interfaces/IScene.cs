
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
    public static class IScene {
    
    public static void SetHexagonVignetteColor( UIntPtr scenePointer ,   ref Vec3 p_hexagon_vignette_color ) {
          NativeManager.OutboundManifest["IScene"]["SetHexagonVignetteColor"]
        .DynamicInvoke(new object[] {  scenePointer ,  p_hexagon_vignette_color  } );
    }

    public static void SetHexagonVignetteAlpha( UIntPtr scenePointer ,  Single Alpha ) {
          NativeManager.OutboundManifest["IScene"]["SetHexagonVignetteAlpha"]
        .DynamicInvoke(new object[] {  scenePointer ,  Alpha  } );
    }

    public static void SetVignetteInnerRadius( UIntPtr scenePointer ,  Single vignetteInnerRadius ) {
          NativeManager.OutboundManifest["IScene"]["SetVignetteInnerRadius"]
        .DynamicInvoke(new object[] {  scenePointer ,  vignetteInnerRadius  } );
    }

    public static void SetVignetteOuterRadius( UIntPtr scenePointer ,  Single vignetteOuterRadius ) {
          NativeManager.OutboundManifest["IScene"]["SetVignetteOuterRadius"]
        .DynamicInvoke(new object[] {  scenePointer ,  vignetteOuterRadius  } );
    }

    public static void SetVignetteOpacity( UIntPtr scenePointer ,  Single vignetteOpacity ) {
          NativeManager.OutboundManifest["IScene"]["SetVignetteOpacity"]
        .DynamicInvoke(new object[] {  scenePointer ,  vignetteOpacity  } );
    }

    public static void SetAberrationOffset( UIntPtr scenePointer ,  Single aberrationOffset ) {
          NativeManager.OutboundManifest["IScene"]["SetAberrationOffset"]
        .DynamicInvoke(new object[] {  scenePointer ,  aberrationOffset  } );
    }

    public static void SetAberrationSize( UIntPtr scenePointer ,  Single aberrationSize ) {
          NativeManager.OutboundManifest["IScene"]["SetAberrationSize"]
        .DynamicInvoke(new object[] {  scenePointer ,  aberrationSize  } );
    }

    public static void SetAberrationSmooth( UIntPtr scenePointer ,  Single aberrationSmooth ) {
          NativeManager.OutboundManifest["IScene"]["SetAberrationSmooth"]
        .DynamicInvoke(new object[] {  scenePointer ,  aberrationSmooth  } );
    }

    public static void SetLensDistortion( UIntPtr scenePointer ,  Single lensDistortion ) {
          NativeManager.OutboundManifest["IScene"]["SetLensDistortion"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensDistortion  } );
    }

    public static Boolean GetHeightAtPoint( UIntPtr scenePointer ,  Vec2 point ,  BodyFlags excludeBodyFlags ,   ref Single height ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetHeightAtPoint"]
        .DynamicInvoke(new object[] {  scenePointer ,  point ,  excludeBodyFlags ,  height  } );
    }

    public static Int32 GetEntityCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetEntityCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void GetEntities( UIntPtr scenePointer ,  UIntPtr entityObjectsArrayPointer ) {
          NativeManager.OutboundManifest["IScene"]["GetEntities"]
        .DynamicInvoke(new object[] {  scenePointer ,  entityObjectsArrayPointer  } );
    }

    public static Int32 GetRootEntityCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetRootEntityCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void GetRootEntities( UIntPtr scene ,  UIntPtr output ) {
          NativeManager.OutboundManifest["IScene"]["GetRootEntities"]
        .DynamicInvoke(new object[] {  scene ,  output  } );
    }

    public static NativeObjectPointer GetEntityWithGuid( UIntPtr scenePointer ,  Byte[] guid ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetEntityWithGuid"]
        .DynamicInvoke(new object[] {  scenePointer ,  guid  } );
    }

    public static Int32 SelectEntitiesInBoxWithScriptComponent( UIntPtr scenePointer ,   ref Vec3 boundingBoxMin ,   ref Vec3 boundingBoxMax ,  IntPtr entitiesOutput ,  Int32 maxCount ,  Byte[] scriptComponentName ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["SelectEntitiesInBoxWithScriptComponent"]
        .DynamicInvoke(new object[] {  scenePointer ,  boundingBoxMin ,  boundingBoxMax ,  entitiesOutput ,  maxCount ,  scriptComponentName  } );
    }

    public static Int32 SelectEntitiesCollidedWith( UIntPtr scenePointer ,   ref Ray ray ,  IntPtr entityIds ,  IntPtr intersections ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["SelectEntitiesCollidedWith"]
        .DynamicInvoke(new object[] {  scenePointer ,  ray ,  entityIds ,  intersections  } );
    }

    public static Int32 GenerateContactsWithCapsule( UIntPtr scenePointer ,   ref CapsuleData cap ,  BodyFlags exclude_flags ,  IntPtr intersections ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GenerateContactsWithCapsule"]
        .DynamicInvoke(new object[] {  scenePointer ,  cap ,  exclude_flags ,  intersections  } );
    }

    public static void InvalidateTerrainPhysicsMaterials( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["InvalidateTerrainPhysicsMaterials"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void Read( UIntPtr scenePointer ,  Byte[] sceneName ,   ref SceneInitializationData initData ,  Byte[] forcedAtmoName ) {
          NativeManager.OutboundManifest["IScene"]["Read"]
        .DynamicInvoke(new object[] {  scenePointer ,  sceneName ,  initData ,  forcedAtmoName  } );
    }

    public static void ReadAndCalculateInitialCamera( UIntPtr scenePointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IScene"]["ReadAndCalculateInitialCamera"]
        .DynamicInvoke(new object[] {  scenePointer ,  outFrame  } );
    }

    public static void OptimizeScene( UIntPtr scenePointer ,  Boolean optimizeFlora ,  Boolean optimizeOro ) {
          NativeManager.OutboundManifest["IScene"]["OptimizeScene"]
        .DynamicInvoke(new object[] {  scenePointer ,  optimizeFlora ,  optimizeOro  } );
    }

    public static Single GetTerrainHeight( UIntPtr scenePointer ,  Vec2 position ,  Boolean checkHoles ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetTerrainHeight"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  checkHoles  } );
    }

    public static Vec3 GetNormalAt( UIntPtr scenePointer ,  Vec2 position ) {
         return   (Vec3)  NativeManager.OutboundManifest["IScene"]["GetNormalAt"]
        .DynamicInvoke(new object[] {  scenePointer ,  position  } );
    }

    public static Boolean HasTerrainHeightmap( UIntPtr scenePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["HasTerrainHeightmap"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Boolean ContainsTerrain( UIntPtr scenePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["ContainsTerrain"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetDofFocus( UIntPtr scenePointer ,  Single dofFocus ) {
          NativeManager.OutboundManifest["IScene"]["SetDofFocus"]
        .DynamicInvoke(new object[] {  scenePointer ,  dofFocus  } );
    }

    public static void SetDofParams( UIntPtr scenePointer ,  Single dofFocusStart ,  Single dofFocusEnd ,  Boolean isVignetteOn ) {
          NativeManager.OutboundManifest["IScene"]["SetDofParams"]
        .DynamicInvoke(new object[] {  scenePointer ,  dofFocusStart ,  dofFocusEnd ,  isVignetteOn  } );
    }

    public static Vec3 GetLastFinalRenderCameraPosition( UIntPtr scenePointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IScene"]["GetLastFinalRenderCameraPosition"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void GetLastFinalRenderCameraFrame( UIntPtr scenePointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IScene"]["GetLastFinalRenderCameraFrame"]
        .DynamicInvoke(new object[] {  scenePointer ,  outFrame  } );
    }

    public static Single GetTimeOfDay( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetTimeOfDay"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetTimeOfDay( UIntPtr scenePointer ,  Single value ) {
          NativeManager.OutboundManifest["IScene"]["SetTimeOfDay"]
        .DynamicInvoke(new object[] {  scenePointer ,  value  } );
    }

    public static Boolean IsAtmosphereIndoor( UIntPtr scenePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsAtmosphereIndoor"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetColorGradeBlend( UIntPtr scenePointer ,  Byte[] texture1 ,  Byte[] texture2 ,  Single alpha ) {
          NativeManager.OutboundManifest["IScene"]["SetColorGradeBlend"]
        .DynamicInvoke(new object[] {  scenePointer ,  texture1 ,  texture2 ,  alpha  } );
    }

    public static void PreloadForRendering( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["PreloadForRendering"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void ResumeSceneSounds( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["ResumeSceneSounds"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void FinishSceneSounds( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["FinishSceneSounds"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void PauseSceneSounds( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["PauseSceneSounds"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Single GetGroundHeightAtPosition( UIntPtr scenePointer ,  Vec3 position ,  UInt32 excludeFlags ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetGroundHeightAtPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  excludeFlags  } );
    }

    public static Single GetGroundHeightAndNormalAtPosition( UIntPtr scenePointer ,  Vec3 position ,   ref Vec3 normal ,  UInt32 excludeFlags ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetGroundHeightAndNormalAtPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  normal ,  excludeFlags  } );
    }

    public static Boolean CheckPointCanSeePoint( UIntPtr scenePointer ,  Vec3 sourcePoint ,  Vec3 targetPoint ,  Single distanceToCheck ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["CheckPointCanSeePoint"]
        .DynamicInvoke(new object[] {  scenePointer ,  sourcePoint ,  targetPoint ,  distanceToCheck  } );
    }

    public static Boolean RayCastForClosestEntityOrTerrain( UIntPtr scenePointer ,   ref Vec3 sourcePoint ,   ref Vec3 targetPoint ,  Single rayThickness ,   ref Single collisionDistance ,   ref Vec3 closestPoint ,   ref UIntPtr entityIndex ,  BodyFlags bodyExcludeFlags ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["RayCastForClosestEntityOrTerrain"]
        .DynamicInvoke(new object[] {  scenePointer ,  sourcePoint ,  targetPoint ,  rayThickness ,  collisionDistance ,  closestPoint ,  entityIndex ,  bodyExcludeFlags  } );
    }

    public static Boolean BoxCastOnlyForCamera( UIntPtr scenePointer ,  IntPtr boxPoints ,   ref Vec3 centerPoint ,   ref Vec3 dir ,  Single distance ,   ref Single collisionDistance ,   ref Vec3 closestPoint ,   ref UIntPtr entityIndex ,  BodyFlags bodyExcludeFlags ,  Boolean preFilter ,  Boolean postFilter ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["BoxCastOnlyForCamera"]
        .DynamicInvoke(new object[] {  scenePointer ,  boxPoints ,  centerPoint ,  dir ,  distance ,  collisionDistance ,  closestPoint ,  entityIndex ,  bodyExcludeFlags ,  preFilter ,  postFilter  } );
    }

    public static void MarkFacesWithIdAsLadder( UIntPtr scenePointer ,  Int32 faceGroupId ,  Boolean isLadder ) {
          NativeManager.OutboundManifest["IScene"]["MarkFacesWithIdAsLadder"]
        .DynamicInvoke(new object[] {  scenePointer ,  faceGroupId ,  isLadder  } );
    }

    public static Boolean BoxCast( UIntPtr scenePointer ,   ref Vec3 boxPointBegin ,   ref Vec3 boxPointEnd ,   ref Vec3 dir ,  Single distance ,   ref Single collisionDistance ,   ref Vec3 closestPoint ,   ref UIntPtr entityIndex ,  BodyFlags bodyExcludeFlags ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["BoxCast"]
        .DynamicInvoke(new object[] {  scenePointer ,  boxPointBegin ,  boxPointEnd ,  dir ,  distance ,  collisionDistance ,  closestPoint ,  entityIndex ,  bodyExcludeFlags  } );
    }

    public static void SetAbilityOfFacesWithId( UIntPtr scenePointer ,  Int32 faceGroupId ,  Boolean isEnabled ) {
          NativeManager.OutboundManifest["IScene"]["SetAbilityOfFacesWithId"]
        .DynamicInvoke(new object[] {  scenePointer ,  faceGroupId ,  isEnabled  } );
    }

    public static void SwapFaceConnectionsWithId( UIntPtr scenePointer ,  Int32 hubFaceGroupID ,  Int32 toBeSeparatedFaceGroupId ,  Int32 toBeMergedFaceGroupId ) {
          NativeManager.OutboundManifest["IScene"]["SwapFaceConnectionsWithId"]
        .DynamicInvoke(new object[] {  scenePointer ,  hubFaceGroupID ,  toBeSeparatedFaceGroupId ,  toBeMergedFaceGroupId  } );
    }

    public static void MergeFacesWithId( UIntPtr scenePointer ,  Int32 faceGroupId0 ,  Int32 faceGroupId1 ,  Int32 newFaceGroupId ) {
          NativeManager.OutboundManifest["IScene"]["MergeFacesWithId"]
        .DynamicInvoke(new object[] {  scenePointer ,  faceGroupId0 ,  faceGroupId1 ,  newFaceGroupId  } );
    }

    public static void SeparateFacesWithId( UIntPtr scenePointer ,  Int32 faceGroupId0 ,  Int32 faceGroupId1 ) {
          NativeManager.OutboundManifest["IScene"]["SeparateFacesWithId"]
        .DynamicInvoke(new object[] {  scenePointer ,  faceGroupId0 ,  faceGroupId1  } );
    }

    public static Boolean IsAnyFaceWithId( UIntPtr scenePointer ,  Int32 faceGroupId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsAnyFaceWithId"]
        .DynamicInvoke(new object[] {  scenePointer ,  faceGroupId  } );
    }

    public static void LoadNavMeshPrefab( UIntPtr scenePointer ,  Byte[] navMeshPrefabName ,  Int32 navMeshGroupIdShift ) {
          NativeManager.OutboundManifest["IScene"]["LoadNavMeshPrefab"]
        .DynamicInvoke(new object[] {  scenePointer ,  navMeshPrefabName ,  navMeshGroupIdShift  } );
    }

    public static Boolean GetNavigationMeshFaceForPosition( UIntPtr scenePointer ,   ref Vec3 position ,   ref Int32 faceGroupId ,  Single heightDifferenceLimit ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetNavigationMeshFaceForPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  faceGroupId ,  heightDifferenceLimit  } );
    }

    public static Boolean GetPathDistanceBetweenPositions( UIntPtr scenePointer ,   ref WorldPosition position ,   ref WorldPosition destination ,  Single agentRadius ,   ref Single pathLength ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPathDistanceBetweenPositions"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  destination ,  agentRadius ,  pathLength  } );
    }

    public static Boolean IsLineToPointClear( UIntPtr scenePointer ,  Int32 startingFace ,  Vec2 position ,  Vec2 destination ,  Single agentRadius ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsLineToPointClear"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingFace ,  position ,  destination ,  agentRadius  } );
    }

    public static Boolean IsLineToPointClear2( UIntPtr scenePointer ,  UIntPtr startingFace ,  Vec2 position ,  Vec2 destination ,  Single agentRadius ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsLineToPointClear2"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingFace ,  position ,  destination ,  agentRadius  } );
    }

    public static Vec2 GetLastPointOnNavigationMeshFromPositionToDestination( UIntPtr scenePointer ,  Int32 startingFace ,  Vec2 position ,  Vec2 destination ) {
         return   (Vec2)  NativeManager.OutboundManifest["IScene"]["GetLastPointOnNavigationMeshFromPositionToDestination"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingFace ,  position ,  destination  } );
    }

    public static Vec3 GetLastPointOnNavigationMeshFromWorldPositionToDestination( UIntPtr scenePointer ,   ref WorldPosition position ,  Vec2 destination ) {
         return   (Vec3)  NativeManager.OutboundManifest["IScene"]["GetLastPointOnNavigationMeshFromWorldPositionToDestination"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  destination  } );
    }

    public static Boolean DoesPathExistBetweenPositions( UIntPtr scenePointer ,  WorldPosition position ,  WorldPosition destination ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["DoesPathExistBetweenPositions"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  destination  } );
    }

    public static Boolean DoesPathExistBetweenFaces( UIntPtr scenePointer ,  Int32 firstNavMeshFace ,  Int32 secondNavMeshFace ,  Boolean ignoreDisabled ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["DoesPathExistBetweenFaces"]
        .DynamicInvoke(new object[] {  scenePointer ,  firstNavMeshFace ,  secondNavMeshFace ,  ignoreDisabled  } );
    }

    public static void EnsurePostfxSystem( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["EnsurePostfxSystem"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetBloom( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetBloom"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static void SetDofMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetDofMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static void SetOcclusionMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetOcclusionMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static void SetExternalInjectionTexture( UIntPtr scenePointer ,  UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["IScene"]["SetExternalInjectionTexture"]
        .DynamicInvoke(new object[] {  scenePointer ,  texturePointer  } );
    }

    public static void SetSunshaftMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetSunshaftMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static Vec3 GetSunDirection( UIntPtr scenePointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IScene"]["GetSunDirection"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Single GetNorthAngle( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetNorthAngle"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Boolean GetTerrainMinMaxHeight( UIntPtr scene ,   ref Single min ,   ref Single max ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetTerrainMinMaxHeight"]
        .DynamicInvoke(new object[] {  scene ,  min ,  max  } );
    }

    public static void GetPhysicsMinMax( UIntPtr scenePointer ,   ref Vec3 min_max ) {
          NativeManager.OutboundManifest["IScene"]["GetPhysicsMinMax"]
        .DynamicInvoke(new object[] {  scenePointer ,  min_max  } );
    }

    public static Boolean IsEditorScene( UIntPtr scenePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsEditorScene"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetMotionBlurMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetMotionBlurMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static void SetAntialiasingMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetAntialiasingMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static void SetDLSSMode( UIntPtr scenePointer ,  Boolean mode ) {
          NativeManager.OutboundManifest["IScene"]["SetDLSSMode"]
        .DynamicInvoke(new object[] {  scenePointer ,  mode  } );
    }

    public static NativeObjectPointer GetPathWithName( UIntPtr scenePointer ,  Byte[] name ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetPathWithName"]
        .DynamicInvoke(new object[] {  scenePointer ,  name  } );
    }

    public static Int32 GetSoftBoundaryVertexCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetSoftBoundaryVertexCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void DeletePathWithName( UIntPtr scenePointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["IScene"]["DeletePathWithName"]
        .DynamicInvoke(new object[] {  scenePointer ,  name  } );
    }

    public static Int32 GetHardBoundaryVertexCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetHardBoundaryVertexCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Vec2 GetHardBoundaryVertex( UIntPtr scenePointer ,  Int32 index ) {
         return   (Vec2)  NativeManager.OutboundManifest["IScene"]["GetHardBoundaryVertex"]
        .DynamicInvoke(new object[] {  scenePointer ,  index  } );
    }

    public static void AddPath( UIntPtr scenePointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["IScene"]["AddPath"]
        .DynamicInvoke(new object[] {  scenePointer ,  name  } );
    }

    public static Vec2 GetSoftBoundaryVertex( UIntPtr scenePointer ,  Int32 index ) {
         return   (Vec2)  NativeManager.OutboundManifest["IScene"]["GetSoftBoundaryVertex"]
        .DynamicInvoke(new object[] {  scenePointer ,  index  } );
    }

    public static void AddPathPoint( UIntPtr scenePointer ,  Byte[] name ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IScene"]["AddPathPoint"]
        .DynamicInvoke(new object[] {  scenePointer ,  name ,  frame  } );
    }

    public static void GetBoundingBox( UIntPtr scenePointer ,   ref Vec3 min ,   ref Vec3 max ) {
          NativeManager.OutboundManifest["IScene"]["GetBoundingBox"]
        .DynamicInvoke(new object[] {  scenePointer ,  min ,  max  } );
    }

    public static void SetName( UIntPtr scenePointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["IScene"]["SetName"]
        .DynamicInvoke(new object[] {  scenePointer ,  name  } );
    }

    public static Int32 GetName( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetName"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetModulePath( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetModulePath"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetTimeSpeed( UIntPtr scenePointer ,  Single value ) {
          NativeManager.OutboundManifest["IScene"]["SetTimeSpeed"]
        .DynamicInvoke(new object[] {  scenePointer ,  value  } );
    }

    public static Single GetTimeSpeed( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetTimeSpeed"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetOwnerThread( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["SetOwnerThread"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetNumberOfPathsWithNamePrefix( UIntPtr ptr ,  Byte[] prefix ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetNumberOfPathsWithNamePrefix"]
        .DynamicInvoke(new object[] {  ptr ,  prefix  } );
    }

    public static void GetPathsWithNamePrefix( UIntPtr ptr ,  IntPtr points ,  Byte[] prefix ) {
          NativeManager.OutboundManifest["IScene"]["GetPathsWithNamePrefix"]
        .DynamicInvoke(new object[] {  ptr ,  points ,  prefix  } );
    }

    public static void SetUseConstantTime( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IScene"]["SetUseConstantTime"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetPlaySoundEventsAfterReadyToRender( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IScene"]["SetPlaySoundEventsAfterReadyToRender"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void DisableStaticShadows( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IScene"]["DisableStaticShadows"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static NativeObjectPointer GetSkyboxMesh( UIntPtr ptr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetSkyboxMesh"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void SetAtmosphereWithName( UIntPtr ptr ,  Byte[] name ) {
          NativeManager.OutboundManifest["IScene"]["SetAtmosphereWithName"]
        .DynamicInvoke(new object[] {  ptr ,  name  } );
    }

    public static void FillEntityWithHardBorderPhysicsBarrier( UIntPtr scenePointer ,  UIntPtr entityPointer ) {
          NativeManager.OutboundManifest["IScene"]["FillEntityWithHardBorderPhysicsBarrier"]
        .DynamicInvoke(new object[] {  scenePointer ,  entityPointer  } );
    }

    public static void ClearDecals( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["ClearDecals"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetScriptedEntityCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetScriptedEntityCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static NativeObjectPointer GetScriptedEntity( UIntPtr scenePointer ,  Int32 index ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetScriptedEntity"]
        .DynamicInvoke(new object[] {  scenePointer ,  index  } );
    }

    public static void WorldPositionValidateZ(  ref WorldPosition position ,  Int32 minimumValidityState ) {
          NativeManager.OutboundManifest["IScene"]["WorldPositionValidateZ"]
        .DynamicInvoke(new object[] {  position ,  minimumValidityState  } );
    }

    public static void WorldPositionComputeNearestNavMesh(  ref WorldPosition position ) {
          NativeManager.OutboundManifest["IScene"]["WorldPositionComputeNearestNavMesh"]
        .DynamicInvoke(new object[] {  position  } );
    }

    public static Int32 GetNodeDataCount( UIntPtr scene ,  Int32 xIndex ,  Int32 yIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetNodeDataCount"]
        .DynamicInvoke(new object[] {  scene ,  xIndex ,  yIndex  } );
    }

    public static void FillTerrainHeightData( UIntPtr scene ,  Int32 xIndex ,  Int32 yIndex ,  IntPtr heightArray ) {
          NativeManager.OutboundManifest["IScene"]["FillTerrainHeightData"]
        .DynamicInvoke(new object[] {  scene ,  xIndex ,  yIndex ,  heightArray  } );
    }

    public static void FillTerrainPhysicsMaterialIndexData( UIntPtr scene ,  Int32 xIndex ,  Int32 yIndex ,  IntPtr materialIndexArray ) {
          NativeManager.OutboundManifest["IScene"]["FillTerrainPhysicsMaterialIndexData"]
        .DynamicInvoke(new object[] {  scene ,  xIndex ,  yIndex ,  materialIndexArray  } );
    }

    public static void GetTerrainData( UIntPtr scene ,   ref Vec2i nodeDimension ,   ref Single nodeSize ,   ref Int32 layerCount ,   ref Int32 layerVersion ) {
          NativeManager.OutboundManifest["IScene"]["GetTerrainData"]
        .DynamicInvoke(new object[] {  scene ,  nodeDimension ,  nodeSize ,  layerCount ,  layerVersion  } );
    }

    public static void GetTerrainNodeData( UIntPtr scene ,  Int32 xIndex ,  Int32 yIndex ,   ref Int32 vertexCountAlongAxis ,   ref Single quadLength ,   ref Single minHeight ,   ref Single maxHeight ) {
          NativeManager.OutboundManifest["IScene"]["GetTerrainNodeData"]
        .DynamicInvoke(new object[] {  scene ,  xIndex ,  yIndex ,  vertexCountAlongAxis ,  quadLength ,  minHeight ,  maxHeight  } );
    }

    public static NativeObjectPointer CreateNewScene( Boolean initialize_physics ,  Boolean enable_decals ,  Int32 atlasGroup ,  Byte[] sceneName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["CreateNewScene"]
        .DynamicInvoke(new object[] {  initialize_physics ,  enable_decals ,  atlasGroup ,  sceneName  } );
    }

    public static Boolean GetPathBetweenAIFacePointers( UIntPtr scenePointer ,  UIntPtr startingAiFace ,  UIntPtr endingAiFace ,  Vec2 startingPosition ,  Vec2 endingPosition ,  Single agentRadius ,  IntPtr result ,   ref Int32 pathSize ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPathBetweenAIFacePointers"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingAiFace ,  endingAiFace ,  startingPosition ,  endingPosition ,  agentRadius ,  result ,  pathSize  } );
    }

    public static Boolean GetPathBetweenAIFaceIndices( UIntPtr scenePointer ,  Int32 startingAiFace ,  Int32 endingAiFace ,  Vec2 startingPosition ,  Vec2 endingPosition ,  Single agentRadius ,  IntPtr result ,   ref Int32 pathSize ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPathBetweenAIFaceIndices"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingAiFace ,  endingAiFace ,  startingPosition ,  endingPosition ,  agentRadius ,  result ,  pathSize  } );
    }

    public static Boolean GetPathDistanceBetweenAIFaces( UIntPtr scenePointer ,  Int32 startingAiFace ,  Int32 endingAiFace ,  Vec2 startingPosition ,  Vec2 endingPosition ,  Single agentRadius ,  Single distanceLimit ,   ref Single distance ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPathDistanceBetweenAIFaces"]
        .DynamicInvoke(new object[] {  scenePointer ,  startingAiFace ,  endingAiFace ,  startingPosition ,  endingPosition ,  agentRadius ,  distanceLimit ,  distance  } );
    }

    public static void GetNavMeshFaceIndex( UIntPtr scenePointer ,   ref PathFaceRecord record ,  Vec2 position ,  Boolean checkIfDisabled ,  Boolean ignoreHeight ) {
          NativeManager.OutboundManifest["IScene"]["GetNavMeshFaceIndex"]
        .DynamicInvoke(new object[] {  scenePointer ,  record ,  position ,  checkIfDisabled ,  ignoreHeight  } );
    }

    public static Boolean IsMultiplayerScene( UIntPtr scene ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["IsMultiplayerScene"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Int32 TakePhotoModePicture( UIntPtr scene ,  Boolean saveAmbientOcclusionPass ,  Boolean saveObjectIdPass ,  Boolean saveShadowPass ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["TakePhotoModePicture"]
        .DynamicInvoke(new object[] {  scene ,  saveAmbientOcclusionPass ,  saveObjectIdPass ,  saveShadowPass  } );
    }

    public static Int32 GetAllColorGradeNames( UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetAllColorGradeNames"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Int32 GetAllFilterNames( UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetAllFilterNames"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Single GetPhotoModeRoll( UIntPtr scene ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetPhotoModeRoll"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Single GetPhotoModeFov( UIntPtr scene ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetPhotoModeFov"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Boolean GetPhotoModeOrbit( UIntPtr scene ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPhotoModeOrbit"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Boolean GetPhotoModeOn( UIntPtr scene ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["GetPhotoModeOn"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static void GetPhotoModeFocus( UIntPtr scene ,   ref Single focus ,   ref Single focusStart ,   ref Single focusEnd ,   ref Single exposure ,   ref Boolean vignetteOn ) {
          NativeManager.OutboundManifest["IScene"]["GetPhotoModeFocus"]
        .DynamicInvoke(new object[] {  scene ,  focus ,  focusStart ,  focusEnd ,  exposure ,  vignetteOn  } );
    }

    public static Int32 GetSceneColorGradeIndex( UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetSceneColorGradeIndex"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Int32 GetSceneFilterIndex( UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetSceneFilterIndex"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Int32 GetLoadingStateName( UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetLoadingStateName"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static void SetPhotoModeRoll( UIntPtr scene ,  Single roll ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeRoll"]
        .DynamicInvoke(new object[] {  scene ,  roll  } );
    }

    public static void SetPhotoModeFov( UIntPtr scene ,  Single verticalFov ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeFov"]
        .DynamicInvoke(new object[] {  scene ,  verticalFov  } );
    }

    public static void SetPhotoModeOrbit( UIntPtr scene ,  Boolean orbit ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeOrbit"]
        .DynamicInvoke(new object[] {  scene ,  orbit  } );
    }

    public static void SetPhotoModeOn( UIntPtr scene ,  Boolean on ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeOn"]
        .DynamicInvoke(new object[] {  scene ,  on  } );
    }

    public static void SetPhotoModeFocus( UIntPtr scene ,  Single focusStart ,  Single focusEnd ,  Single focus ,  Single exposure ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeFocus"]
        .DynamicInvoke(new object[] {  scene ,  focusStart ,  focusEnd ,  focus ,  exposure  } );
    }

    public static void SetPhotoModeVignette( UIntPtr scene ,  Boolean vignetteOn ) {
          NativeManager.OutboundManifest["IScene"]["SetPhotoModeVignette"]
        .DynamicInvoke(new object[] {  scene ,  vignetteOn  } );
    }

    public static void SetSceneColorGradeIndex( UIntPtr scene ,  Int32 index ) {
          NativeManager.OutboundManifest["IScene"]["SetSceneColorGradeIndex"]
        .DynamicInvoke(new object[] {  scene ,  index  } );
    }

    public static Int32 SetSceneFilterIndex( UIntPtr scene ,  Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["SetSceneFilterIndex"]
        .DynamicInvoke(new object[] {  scene ,  index  } );
    }

    public static void SetSceneColorGrade( UIntPtr scene ,  Byte[] textureName ) {
          NativeManager.OutboundManifest["IScene"]["SetSceneColorGrade"]
        .DynamicInvoke(new object[] {  scene ,  textureName  } );
    }

    public static Single GetWaterLevel( UIntPtr scene ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetWaterLevel"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Single GetWaterLevelAtPosition( UIntPtr scene ,  Vec2 position ,  Boolean checkWaterBodyEntities ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetWaterLevelAtPosition"]
        .DynamicInvoke(new object[] {  scene ,  position ,  checkWaterBodyEntities  } );
    }

    public static Int32 GetTerrainPhysicsMaterialIndexAtLayer( UIntPtr scene ,  Int32 layerIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetTerrainPhysicsMaterialIndexAtLayer"]
        .DynamicInvoke(new object[] {  scene ,  layerIndex  } );
    }

    public static void CreateBurstParticle( UIntPtr scene ,  Int32 particleId ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IScene"]["CreateBurstParticle"]
        .DynamicInvoke(new object[] {  scene ,  particleId ,  frame  } );
    }

    public static void GetNavMeshFaceIndex3( UIntPtr scenePointer ,   ref PathFaceRecord record ,  Vec3 position ,  Boolean checkIfDisabled ) {
          NativeManager.OutboundManifest["IScene"]["GetNavMeshFaceIndex3"]
        .DynamicInvoke(new object[] {  scenePointer ,  record ,  position ,  checkIfDisabled  } );
    }

    public static void SetUpgradeLevel( UIntPtr scenePointer ,  Int32 level ) {
          NativeManager.OutboundManifest["IScene"]["SetUpgradeLevel"]
        .DynamicInvoke(new object[] {  scenePointer ,  level  } );
    }

    public static NativeObjectPointer CreatePathMesh( UIntPtr scenePointer ,  Byte[] baseEntityName ,  Boolean isWaterPath ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["CreatePathMesh"]
        .DynamicInvoke(new object[] {  scenePointer ,  baseEntityName ,  isWaterPath  } );
    }

    public static void SetActiveVisibilityLevels( UIntPtr scenePointer ,  Byte[] levelsAppended ) {
          NativeManager.OutboundManifest["IScene"]["SetActiveVisibilityLevels"]
        .DynamicInvoke(new object[] {  scenePointer ,  levelsAppended  } );
    }

    public static void SetTerrainDynamicParams( UIntPtr scenePointer ,  Vec3 dynamic_params ) {
          NativeManager.OutboundManifest["IScene"]["SetTerrainDynamicParams"]
        .DynamicInvoke(new object[] {  scenePointer ,  dynamic_params  } );
    }

    public static void SetDoNotWaitForLoadingStatesToRender( UIntPtr scenePointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IScene"]["SetDoNotWaitForLoadingStatesToRender"]
        .DynamicInvoke(new object[] {  scenePointer ,  value  } );
    }

    public static NativeObjectPointer CreatePathMesh2( UIntPtr scenePointer ,  IntPtr pathNodes ,  Int32 pathNodeCount ,  Boolean isWaterPath ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["CreatePathMesh2"]
        .DynamicInvoke(new object[] {  scenePointer ,  pathNodes ,  pathNodeCount ,  isWaterPath  } );
    }

    public static void ClearAll( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["ClearAll"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void CheckResources( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["CheckResources"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void ForceLoadResources( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["ForceLoadResources"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Boolean CheckPathEntitiesFrameChanged( UIntPtr scenePointer ,  Byte[] containsName ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["CheckPathEntitiesFrameChanged"]
        .DynamicInvoke(new object[] {  scenePointer ,  containsName  } );
    }

    public static void Tick( UIntPtr scenePointer ,  Single deltaTime ) {
          NativeManager.OutboundManifest["IScene"]["Tick"]
        .DynamicInvoke(new object[] {  scenePointer ,  deltaTime  } );
    }

    public static void AddEntityWithMesh( UIntPtr scenePointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IScene"]["AddEntityWithMesh"]
        .DynamicInvoke(new object[] {  scenePointer ,  meshPointer ,  frame  } );
    }

    public static void AddEntityWithMultiMesh( UIntPtr scenePointer ,  UIntPtr multiMeshPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IScene"]["AddEntityWithMultiMesh"]
        .DynamicInvoke(new object[] {  scenePointer ,  multiMeshPointer ,  frame  } );
    }

    public static NativeObjectPointer AddItemEntity( UIntPtr scenePointer ,   ref MatrixFrame frame ,  UIntPtr meshPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["AddItemEntity"]
        .DynamicInvoke(new object[] {  scenePointer ,  frame ,  meshPointer  } );
    }

    public static void RemoveEntity( UIntPtr scenePointer ,  UIntPtr entityId ,  Int32 removeReason ) {
          NativeManager.OutboundManifest["IScene"]["RemoveEntity"]
        .DynamicInvoke(new object[] {  scenePointer ,  entityId ,  removeReason  } );
    }

    public static Boolean AttachEntity( UIntPtr scenePointer ,  UIntPtr entity ,  Boolean showWarnings ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["AttachEntity"]
        .DynamicInvoke(new object[] {  scenePointer ,  entity ,  showWarnings  } );
    }

    public static void GetTerrainHeightAndNormal( UIntPtr scenePointer ,  Vec2 position ,   ref Single height ,   ref Vec3 normal ) {
          NativeManager.OutboundManifest["IScene"]["GetTerrainHeightAndNormal"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  height ,  normal  } );
    }

    public static void ResumeLoadingRenderings( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["ResumeLoadingRenderings"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static UInt32 GetUpgradeLevelMask( UIntPtr scenePointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IScene"]["GetUpgradeLevelMask"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetUpgradeLevelVisibility( UIntPtr scenePointer ,  Byte[] concatLevels ) {
          NativeManager.OutboundManifest["IScene"]["SetUpgradeLevelVisibility"]
        .DynamicInvoke(new object[] {  scenePointer ,  concatLevels  } );
    }

    public static void SetUpgradeLevelVisibilityWithMask( UIntPtr scenePointer ,  UInt32 mask ) {
          NativeManager.OutboundManifest["IScene"]["SetUpgradeLevelVisibilityWithMask"]
        .DynamicInvoke(new object[] {  scenePointer ,  mask  } );
    }

    public static void StallLoadingRenderingsUntilFurtherNotice( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IScene"]["StallLoadingRenderingsUntilFurtherNotice"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetFloraInstanceCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetFloraInstanceCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetFloraRendererTextureUsage( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetFloraRendererTextureUsage"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetTerrainMemoryUsage( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetTerrainMemoryUsage"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Int32 GetNavMeshFaceCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetNavMeshFaceCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void GetNavMeshFaceCenterPosition( UIntPtr scenePointer ,  Int32 navMeshFace ,   ref Vec3 centerPos ) {
          NativeManager.OutboundManifest["IScene"]["GetNavMeshFaceCenterPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  navMeshFace ,  centerPos  } );
    }

    public static Int32 GetIdOfNavMeshFace( UIntPtr scenePointer ,  Int32 navMeshFace ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetIdOfNavMeshFace"]
        .DynamicInvoke(new object[] {  scenePointer ,  navMeshFace  } );
    }

    public static void SetClothSimulationState( UIntPtr scenePointer ,  Boolean state ) {
          NativeManager.OutboundManifest["IScene"]["SetClothSimulationState"]
        .DynamicInvoke(new object[] {  scenePointer ,  state  } );
    }

    public static NativeObjectPointer GetFirstEntityWithName( UIntPtr scenePointer ,  Byte[] entityName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetFirstEntityWithName"]
        .DynamicInvoke(new object[] {  scenePointer ,  entityName  } );
    }

    public static NativeObjectPointer GetCampaignEntityWithName( UIntPtr scenePointer ,  Byte[] entityName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetCampaignEntityWithName"]
        .DynamicInvoke(new object[] {  scenePointer ,  entityName  } );
    }

    public static void GetAllEntitiesWithScriptComponent( UIntPtr scenePointer ,  Byte[] scriptComponentName ,  UIntPtr output ) {
          NativeManager.OutboundManifest["IScene"]["GetAllEntitiesWithScriptComponent"]
        .DynamicInvoke(new object[] {  scenePointer ,  scriptComponentName ,  output  } );
    }

    public static NativeObjectPointer GetFirstEntityWithScriptComponent( UIntPtr scenePointer ,  Byte[] scriptComponentName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IScene"]["GetFirstEntityWithScriptComponent"]
        .DynamicInvoke(new object[] {  scenePointer ,  scriptComponentName  } );
    }

    public static UInt32 GetUpgradeLevelMaskOfLevelName( UIntPtr scenePointer ,  Byte[] levelName ) {
         return   (UInt32)  NativeManager.OutboundManifest["IScene"]["GetUpgradeLevelMaskOfLevelName"]
        .DynamicInvoke(new object[] {  scenePointer ,  levelName  } );
    }

    public static Int32 GetUpgradeLevelNameOfIndex( UIntPtr scenePointer ,  Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetUpgradeLevelNameOfIndex"]
        .DynamicInvoke(new object[] {  scenePointer ,  index  } );
    }

    public static Int32 GetUpgradeLevelCount( UIntPtr scenePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["GetUpgradeLevelCount"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Single GetWinterTimeFactor( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetWinterTimeFactor"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Single GetNavMeshFaceFirstVertexZ( UIntPtr scenePointer ,  Int32 navMeshFaceIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetNavMeshFaceFirstVertexZ"]
        .DynamicInvoke(new object[] {  scenePointer ,  navMeshFaceIndex  } );
    }

    public static void SetWinterTimeFactor( UIntPtr scenePointer ,  Single winterTimeFactor ) {
          NativeManager.OutboundManifest["IScene"]["SetWinterTimeFactor"]
        .DynamicInvoke(new object[] {  scenePointer ,  winterTimeFactor  } );
    }

    public static void SetDrynessFactor( UIntPtr scenePointer ,  Single drynessFactor ) {
          NativeManager.OutboundManifest["IScene"]["SetDrynessFactor"]
        .DynamicInvoke(new object[] {  scenePointer ,  drynessFactor  } );
    }

    public static Single GetFog( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetFog"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetFog( UIntPtr scenePointer ,  Single fogDensity ,   ref Vec3 fogColor ,  Single fogFalloff ) {
          NativeManager.OutboundManifest["IScene"]["SetFog"]
        .DynamicInvoke(new object[] {  scenePointer ,  fogDensity ,  fogColor ,  fogFalloff  } );
    }

    public static void SetFogAdvanced( UIntPtr scenePointer ,  Single fogFalloffOffset ,  Single fogFalloffMinFog ,  Single fogFalloffStartDist ) {
          NativeManager.OutboundManifest["IScene"]["SetFogAdvanced"]
        .DynamicInvoke(new object[] {  scenePointer ,  fogFalloffOffset ,  fogFalloffMinFog ,  fogFalloffStartDist  } );
    }

    public static void SetFogAmbientColor( UIntPtr scenePointer ,   ref Vec3 fogAmbientColor ) {
          NativeManager.OutboundManifest["IScene"]["SetFogAmbientColor"]
        .DynamicInvoke(new object[] {  scenePointer ,  fogAmbientColor  } );
    }

    public static void SetTemperature( UIntPtr scenePointer ,  Single temperature ) {
          NativeManager.OutboundManifest["IScene"]["SetTemperature"]
        .DynamicInvoke(new object[] {  scenePointer ,  temperature  } );
    }

    public static void SetHumidity( UIntPtr scenePointer ,  Single humidity ) {
          NativeManager.OutboundManifest["IScene"]["SetHumidity"]
        .DynamicInvoke(new object[] {  scenePointer ,  humidity  } );
    }

    public static void SetDynamicShadowmapCascadesRadiusMultiplier( UIntPtr scenePointer ,  Single extraRadius ) {
          NativeManager.OutboundManifest["IScene"]["SetDynamicShadowmapCascadesRadiusMultiplier"]
        .DynamicInvoke(new object[] {  scenePointer ,  extraRadius  } );
    }

    public static void SetEnvironmentMultiplier( UIntPtr scenePointer ,  Boolean useMultiplier ,  Single multiplier ) {
          NativeManager.OutboundManifest["IScene"]["SetEnvironmentMultiplier"]
        .DynamicInvoke(new object[] {  scenePointer ,  useMultiplier ,  multiplier  } );
    }

    public static void SetSkyRotation( UIntPtr scenePointer ,  Single rotation ) {
          NativeManager.OutboundManifest["IScene"]["SetSkyRotation"]
        .DynamicInvoke(new object[] {  scenePointer ,  rotation  } );
    }

    public static void SetSkyBrightness( UIntPtr scenePointer ,  Single brightness ) {
          NativeManager.OutboundManifest["IScene"]["SetSkyBrightness"]
        .DynamicInvoke(new object[] {  scenePointer ,  brightness  } );
    }

    public static void SetForcedSnow( UIntPtr scenePointer ,  Boolean value ) {
          NativeManager.OutboundManifest["IScene"]["SetForcedSnow"]
        .DynamicInvoke(new object[] {  scenePointer ,  value  } );
    }

    public static void SetSun( UIntPtr scenePointer ,  Vec3 color ,  Single altitude ,  Single angle ,  Single intensity ) {
          NativeManager.OutboundManifest["IScene"]["SetSun"]
        .DynamicInvoke(new object[] {  scenePointer ,  color ,  altitude ,  angle ,  intensity  } );
    }

    public static void SetSunAngleAltitude( UIntPtr scenePointer ,  Single angle ,  Single altitude ) {
          NativeManager.OutboundManifest["IScene"]["SetSunAngleAltitude"]
        .DynamicInvoke(new object[] {  scenePointer ,  angle ,  altitude  } );
    }

    public static void SetSunLight( UIntPtr scenePointer ,  Vec3 color ,  Vec3 direction ) {
          NativeManager.OutboundManifest["IScene"]["SetSunLight"]
        .DynamicInvoke(new object[] {  scenePointer ,  color ,  direction  } );
    }

    public static void SetSunDirection( UIntPtr scenePointer ,  Vec3 direction ) {
          NativeManager.OutboundManifest["IScene"]["SetSunDirection"]
        .DynamicInvoke(new object[] {  scenePointer ,  direction  } );
    }

    public static void SetSunSize( UIntPtr scenePointer ,  Single size ) {
          NativeManager.OutboundManifest["IScene"]["SetSunSize"]
        .DynamicInvoke(new object[] {  scenePointer ,  size  } );
    }

    public static void SetSunShaftStrength( UIntPtr scenePointer ,  Single strength ) {
          NativeManager.OutboundManifest["IScene"]["SetSunShaftStrength"]
        .DynamicInvoke(new object[] {  scenePointer ,  strength  } );
    }

    public static Single GetRainDensity( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetRainDensity"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetRainDensity( UIntPtr scenePointer ,  Single density ) {
          NativeManager.OutboundManifest["IScene"]["SetRainDensity"]
        .DynamicInvoke(new object[] {  scenePointer ,  density  } );
    }

    public static Single GetSnowDensity( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IScene"]["GetSnowDensity"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetSnowDensity( UIntPtr scenePointer ,  Single density ) {
          NativeManager.OutboundManifest["IScene"]["SetSnowDensity"]
        .DynamicInvoke(new object[] {  scenePointer ,  density  } );
    }

    public static void AddDecalInstance( UIntPtr scenePointer ,  UIntPtr decalMeshPointer ,  Byte[] decalSetID ,  Boolean deletable ) {
          NativeManager.OutboundManifest["IScene"]["AddDecalInstance"]
        .DynamicInvoke(new object[] {  scenePointer ,  decalMeshPointer ,  decalSetID ,  deletable  } );
    }

    public static void SetShadow( UIntPtr scenePointer ,  Boolean shadowEnabled ) {
          NativeManager.OutboundManifest["IScene"]["SetShadow"]
        .DynamicInvoke(new object[] {  scenePointer ,  shadowEnabled  } );
    }

    public static Int32 AddPointLight( UIntPtr scenePointer ,  Vec3 position ,  Single radius ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["AddPointLight"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  radius  } );
    }

    public static Int32 AddDirectionalLight( UIntPtr scenePointer ,  Vec3 position ,  Vec3 direction ,  Single radius ) {
         return   (Int32)  NativeManager.OutboundManifest["IScene"]["AddDirectionalLight"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  direction ,  radius  } );
    }

    public static void SetLightPosition( UIntPtr scenePointer ,  Int32 lightIndex ,  Vec3 position ) {
          NativeManager.OutboundManifest["IScene"]["SetLightPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  lightIndex ,  position  } );
    }

    public static void SetLightDiffuseColor( UIntPtr scenePointer ,  Int32 lightIndex ,  Vec3 diffuseColor ) {
          NativeManager.OutboundManifest["IScene"]["SetLightDiffuseColor"]
        .DynamicInvoke(new object[] {  scenePointer ,  lightIndex ,  diffuseColor  } );
    }

    public static void SetLightDirection( UIntPtr scenePointer ,  Int32 lightIndex ,  Vec3 direction ) {
          NativeManager.OutboundManifest["IScene"]["SetLightDirection"]
        .DynamicInvoke(new object[] {  scenePointer ,  lightIndex ,  direction  } );
    }

    public static Boolean CalculateEffectiveLighting( UIntPtr scenePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IScene"]["CalculateEffectiveLighting"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetMieScatterStrength( UIntPtr scenePointer ,  Single strength ) {
          NativeManager.OutboundManifest["IScene"]["SetMieScatterStrength"]
        .DynamicInvoke(new object[] {  scenePointer ,  strength  } );
    }

    public static void SetMieScatterFocus( UIntPtr scenePointer ,  Single strength ) {
          NativeManager.OutboundManifest["IScene"]["SetMieScatterFocus"]
        .DynamicInvoke(new object[] {  scenePointer ,  strength  } );
    }

    public static void SetBrightpassTreshold( UIntPtr scenePointer ,  Single threshold ) {
          NativeManager.OutboundManifest["IScene"]["SetBrightpassTreshold"]
        .DynamicInvoke(new object[] {  scenePointer ,  threshold  } );
    }

    public static void SetMinExposure( UIntPtr scenePointer ,  Single minExposure ) {
          NativeManager.OutboundManifest["IScene"]["SetMinExposure"]
        .DynamicInvoke(new object[] {  scenePointer ,  minExposure  } );
    }

    public static void SetMaxExposure( UIntPtr scenePointer ,  Single maxExposure ) {
          NativeManager.OutboundManifest["IScene"]["SetMaxExposure"]
        .DynamicInvoke(new object[] {  scenePointer ,  maxExposure  } );
    }

    public static void SetTargetExposure( UIntPtr scenePointer ,  Single targetExposure ) {
          NativeManager.OutboundManifest["IScene"]["SetTargetExposure"]
        .DynamicInvoke(new object[] {  scenePointer ,  targetExposure  } );
    }

    public static void SetMiddleGray( UIntPtr scenePointer ,  Single middleGray ) {
          NativeManager.OutboundManifest["IScene"]["SetMiddleGray"]
        .DynamicInvoke(new object[] {  scenePointer ,  middleGray  } );
    }

    public static void SetBloomStrength( UIntPtr scenePointer ,  Single bloomStrength ) {
          NativeManager.OutboundManifest["IScene"]["SetBloomStrength"]
        .DynamicInvoke(new object[] {  scenePointer ,  bloomStrength  } );
    }

    public static void SetBloomAmount( UIntPtr scenePointer ,  Single bloomAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetBloomAmount"]
        .DynamicInvoke(new object[] {  scenePointer ,  bloomAmount  } );
    }

    public static void SetGrainAmount( UIntPtr scenePointer ,  Single grainAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetGrainAmount"]
        .DynamicInvoke(new object[] {  scenePointer ,  grainAmount  } );
    }

    public static void SetLensFlareAmount( UIntPtr scenePointer ,  Single lensFlareAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareAmount"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareAmount  } );
    }

    public static void SetLensFlareThreshold( UIntPtr scenePointer ,  Single lensFlareThreshold ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareThreshold"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareThreshold  } );
    }

    public static void SetLensFlareStrength( UIntPtr scenePointer ,  Single lensFlareStrength ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareStrength"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareStrength  } );
    }

    public static void SetLensFlareDirtWeight( UIntPtr scenePointer ,  Single lensFlareDirtWeight ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareDirtWeight"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareDirtWeight  } );
    }

    public static void SetLensFlareDiffractionWeight( UIntPtr scenePointer ,  Single lensFlareDiffractionWeight ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareDiffractionWeight"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareDiffractionWeight  } );
    }

    public static void SetLensFlareHaloWeight( UIntPtr scenePointer ,  Single lensFlareHaloWeight ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareHaloWeight"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareHaloWeight  } );
    }

    public static void SetLensFlareGhostWeight( UIntPtr scenePointer ,  Single lensFlareGhostWeight ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareGhostWeight"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareGhostWeight  } );
    }

    public static void SetLensFlareHaloWidth( UIntPtr scenePointer ,  Single lensFlareHaloWidth ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareHaloWidth"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareHaloWidth  } );
    }

    public static void SetLensFlareGhostSamples( UIntPtr scenePointer ,  Int32 lensFlareGhostSamples ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareGhostSamples"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareGhostSamples  } );
    }

    public static void SetLensFlareAberrationOffset( UIntPtr scenePointer ,  Single lensFlareAberrationOffset ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareAberrationOffset"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareAberrationOffset  } );
    }

    public static void SetLensFlareBlurSize( UIntPtr scenePointer ,  Int32 lensFlareBlurSize ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareBlurSize"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareBlurSize  } );
    }

    public static void SetLensFlareBlurSigma( UIntPtr scenePointer ,  Single lensFlareBlurSigma ) {
          NativeManager.OutboundManifest["IScene"]["SetLensFlareBlurSigma"]
        .DynamicInvoke(new object[] {  scenePointer ,  lensFlareBlurSigma  } );
    }

    public static void SetStreakAmount( UIntPtr scenePointer ,  Single streakAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakAmount"]
        .DynamicInvoke(new object[] {  scenePointer ,  streakAmount  } );
    }

    public static void SetStreakThreshold( UIntPtr scenePointer ,  Single streakThreshold ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakThreshold"]
        .DynamicInvoke(new object[] {  scenePointer ,  streakThreshold  } );
    }

    public static void SetStreakStrength( UIntPtr scenePointer ,  Single strengthAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakStrength"]
        .DynamicInvoke(new object[] {  scenePointer ,  strengthAmount  } );
    }

    public static void SetStreakStretch( UIntPtr scenePointer ,  Single stretchAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakStretch"]
        .DynamicInvoke(new object[] {  scenePointer ,  stretchAmount  } );
    }

    public static void SetStreakIntensity( UIntPtr scenePointer ,  Single stretchAmount ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakIntensity"]
        .DynamicInvoke(new object[] {  scenePointer ,  stretchAmount  } );
    }

    public static void SetStreakTint( UIntPtr scenePointer ,   ref Vec3 p_streak_tint_color ) {
          NativeManager.OutboundManifest["IScene"]["SetStreakTint"]
        .DynamicInvoke(new object[] {  scenePointer ,  p_streak_tint_color  } );
    }

    }
}