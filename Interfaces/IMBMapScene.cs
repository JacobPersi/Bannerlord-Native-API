
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
    public static class IMBMapScene {
    
    public static Vec3 GetAccessiblePointNearPosition( UIntPtr scenePointer ,  Vec2 position ,  Single radius ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBMapScene"]["GetAccessiblePointNearPosition"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  radius  } );
    }

    public static void RemoveZeroCornerBodies( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IMBMapScene"]["RemoveZeroCornerBodies"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void LoadAtmosphereData( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IMBMapScene"]["LoadAtmosphereData"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void GetFaceIndexForMultiplePositions( UIntPtr scenePointer ,  Int32 movedPartyCount ,  IntPtr positionArray ,  IntPtr resultArray ,  Boolean check_if_disabled ,  Boolean check_height ) {
          NativeManager.OutboundManifest["IMBMapScene"]["GetFaceIndexForMultiplePositions"]
        .DynamicInvoke(new object[] {  scenePointer ,  movedPartyCount ,  positionArray ,  resultArray ,  check_if_disabled ,  check_height  } );
    }

    public static void SetSoundParameters( UIntPtr scenePointer ,  Single tod ,  Int32 season ,  Single cameraHeight ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetSoundParameters"]
        .DynamicInvoke(new object[] {  scenePointer ,  tod ,  season ,  cameraHeight  } );
    }

    public static void TickStepSound( UIntPtr scenePointer ,  UIntPtr strategicEntityId ,  Int32 faceIndexterrainType ,  Int32 soundType ) {
          NativeManager.OutboundManifest["IMBMapScene"]["TickStepSound"]
        .DynamicInvoke(new object[] {  scenePointer ,  strategicEntityId ,  faceIndexterrainType ,  soundType  } );
    }

    public static void TickAmbientSounds( UIntPtr scenePointer ,  Int32 terrainType ) {
          NativeManager.OutboundManifest["IMBMapScene"]["TickAmbientSounds"]
        .DynamicInvoke(new object[] {  scenePointer ,  terrainType  } );
    }

    public static void TickVisuals( UIntPtr scenePointer ,  Single tod ,  IntPtr ticked_map_meshes ,  Int32 tickedMapMeshesCount ) {
          NativeManager.OutboundManifest["IMBMapScene"]["TickVisuals"]
        .DynamicInvoke(new object[] {  scenePointer ,  tod ,  ticked_map_meshes ,  tickedMapMeshesCount  } );
    }

    public static void ValidateTerrainSoundIds() {
          NativeManager.OutboundManifest["IMBMapScene"]["ValidateTerrainSoundIds"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetPoliticalColor( UIntPtr scenePointer ,  Byte[] value ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetPoliticalColor"]
        .DynamicInvoke(new object[] {  scenePointer ,  value  } );
    }

    public static void SetFrameForAtmosphere( UIntPtr scenePointer ,  Single tod ,  Single cameraElevation ,  Boolean forceLoadTextures ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetFrameForAtmosphere"]
        .DynamicInvoke(new object[] {  scenePointer ,  tod ,  cameraElevation ,  forceLoadTextures  } );
    }

    public static void GetColorGradeGridData( UIntPtr scenePointer ,  ManagedArray snowData ,  Byte[] textureName ) {
          NativeManager.OutboundManifest["IMBMapScene"]["GetColorGradeGridData"]
        .DynamicInvoke(new object[] {  scenePointer ,  snowData ,  textureName  } );
    }

    public static void GetBattleSceneIndexMapResolution( UIntPtr scenePointer ,   ref Int32 width ,   ref Int32 height ) {
          NativeManager.OutboundManifest["IMBMapScene"]["GetBattleSceneIndexMapResolution"]
        .DynamicInvoke(new object[] {  scenePointer ,  width ,  height  } );
    }

    public static void GetBattleSceneIndexMap( UIntPtr scenePointer ,  ManagedArray indexData ) {
          NativeManager.OutboundManifest["IMBMapScene"]["GetBattleSceneIndexMap"]
        .DynamicInvoke(new object[] {  scenePointer ,  indexData  } );
    }

    public static void SetTerrainDynamicParams( UIntPtr scenePointer ,  Vec3 dynamic_params ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetTerrainDynamicParams"]
        .DynamicInvoke(new object[] {  scenePointer ,  dynamic_params  } );
    }

    public static void SetSeasonTimeFactor( UIntPtr scenePointer ,  Single seasonTimeFactor ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetSeasonTimeFactor"]
        .DynamicInvoke(new object[] {  scenePointer ,  seasonTimeFactor  } );
    }

    public static Single GetSeasonTimeFactor( UIntPtr scenePointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMBMapScene"]["GetSeasonTimeFactor"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static Boolean GetMouseVisible() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBMapScene"]["GetMouseVisible"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SendMouseKeyEvent( Int32 keyId ,  Boolean isDown ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SendMouseKeyEvent"]
        .DynamicInvoke(new object[] {  keyId ,  isDown  } );
    }

    public static void SetMouseVisible( Boolean value ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetMouseVisible"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetMousePos( Int32 posX ,  Int32 posY ) {
          NativeManager.OutboundManifest["IMBMapScene"]["SetMousePos"]
        .DynamicInvoke(new object[] {  posX ,  posY  } );
    }

    }
}