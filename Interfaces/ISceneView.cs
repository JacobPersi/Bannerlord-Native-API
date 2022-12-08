
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
    public static class ISceneView {
    
    public static NativeObjectPointer CreateSceneView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISceneView"]["CreateSceneView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetScene( UIntPtr ptr ,  UIntPtr scenePtr ) {
          NativeManager.OutboundManifest["ISceneView"]["SetScene"]
        .DynamicInvoke(new object[] {  ptr ,  scenePtr  } );
    }

    public static void SetAcceptGlobalDebugRenderObjects( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetAcceptGlobalDebugRenderObjects"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetRenderWithPostfx( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetRenderWithPostfx"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetForceShaderCompilation( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetForceShaderCompilation"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static Boolean CheckSceneReadyToRender( UIntPtr ptr ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISceneView"]["CheckSceneReadyToRender"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void SetPostfxConfigParams( UIntPtr ptr ,  Int32 value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetPostfxConfigParams"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetCamera( UIntPtr ptr ,  UIntPtr cameraPtr ) {
          NativeManager.OutboundManifest["ISceneView"]["SetCamera"]
        .DynamicInvoke(new object[] {  ptr ,  cameraPtr  } );
    }

    public static void SetResolutionScaling( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetResolutionScaling"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetPostfxFromConfig( UIntPtr ptr ) {
          NativeManager.OutboundManifest["ISceneView"]["SetPostfxFromConfig"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static Vec2 WorldPointToScreenPoint( UIntPtr ptr ,  Vec3 position ) {
         return   (Vec2)  NativeManager.OutboundManifest["ISceneView"]["WorldPointToScreenPoint"]
        .DynamicInvoke(new object[] {  ptr ,  position  } );
    }

    public static Vec2 ScreenPointToViewportPoint( UIntPtr ptr ,  Single position_x ,  Single position_y ) {
         return   (Vec2)  NativeManager.OutboundManifest["ISceneView"]["ScreenPointToViewportPoint"]
        .DynamicInvoke(new object[] {  ptr ,  position_x ,  position_y  } );
    }

    public static Boolean ProjectedMousePositionOnGround( UIntPtr pointer ,   ref Vec3 groundPosition ,   ref Vec3 groundNormal ,  Boolean mouseVisible ,  BodyFlags excludeBodyOwnerFlags ,  Boolean checkOccludedSurface ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISceneView"]["ProjectedMousePositionOnGround"]
        .DynamicInvoke(new object[] {  pointer ,  groundPosition ,  groundNormal ,  mouseVisible ,  excludeBodyOwnerFlags ,  checkOccludedSurface  } );
    }

    public static void TranslateMouse( UIntPtr pointer ,   ref Vec3 worldMouseNear ,   ref Vec3 worldMouseFar ,  Single maxDistance ) {
          NativeManager.OutboundManifest["ISceneView"]["TranslateMouse"]
        .DynamicInvoke(new object[] {  pointer ,  worldMouseNear ,  worldMouseFar ,  maxDistance  } );
    }

    public static void SetSceneUsesSkybox( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetSceneUsesSkybox"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetSceneUsesShadows( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetSceneUsesShadows"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetSceneUsesContour( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetSceneUsesContour"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void DoNotClear( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["DoNotClear"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void AddClearTask( UIntPtr ptr ,  Boolean clearOnlySceneview ) {
          NativeManager.OutboundManifest["ISceneView"]["AddClearTask"]
        .DynamicInvoke(new object[] {  ptr ,  clearOnlySceneview  } );
    }

    public static Boolean ReadyToRender( UIntPtr pointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISceneView"]["ReadyToRender"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void SetClearAndDisableAfterSucessfullRender( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetClearAndDisableAfterSucessfullRender"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetClearGbuffer( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetClearGbuffer"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetShadowmapResolutionMultiplier( UIntPtr pointer ,  Single value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetShadowmapResolutionMultiplier"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetPointlightResolutionMultiplier( UIntPtr pointer ,  Single value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetPointlightResolutionMultiplier"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetCleanScreenUntilLoadingDone( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISceneView"]["SetCleanScreenUntilLoadingDone"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void ClearAll( UIntPtr pointer ,  Boolean clear_scene ,  Boolean remove_terrain ) {
          NativeManager.OutboundManifest["ISceneView"]["ClearAll"]
        .DynamicInvoke(new object[] {  pointer ,  clear_scene ,  remove_terrain  } );
    }

    public static void SetFocusedShadowmap( UIntPtr ptr ,  Boolean enable ,   ref Vec3 center ,  Single radius ) {
          NativeManager.OutboundManifest["ISceneView"]["SetFocusedShadowmap"]
        .DynamicInvoke(new object[] {  ptr ,  enable ,  center ,  radius  } );
    }

    public static NativeObjectPointer GetScene( UIntPtr ptr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISceneView"]["GetScene"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    }
}