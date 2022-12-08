
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
    public static class ICamera {
    
    public static void Release( UIntPtr cameraPointer ) {
          NativeManager.OutboundManifest["ICamera"]["Release"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static void SetEntity( UIntPtr cameraPointer ,  UIntPtr entityId ) {
          NativeManager.OutboundManifest["ICamera"]["SetEntity"]
        .DynamicInvoke(new object[] {  cameraPointer ,  entityId  } );
    }

    public static NativeObjectPointer GetEntity( UIntPtr cameraPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ICamera"]["GetEntity"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static NativeObjectPointer CreateCamera() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ICamera"]["CreateCamera"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ReleaseCameraEntity( UIntPtr cameraPointer ) {
          NativeManager.OutboundManifest["ICamera"]["ReleaseCameraEntity"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static void LookAt( UIntPtr cameraPointer ,  Vec3 position ,  Vec3 target ,  Vec3 upVector ) {
          NativeManager.OutboundManifest["ICamera"]["LookAt"]
        .DynamicInvoke(new object[] {  cameraPointer ,  position ,  target ,  upVector  } );
    }

    public static void ScreenSpaceRayProjection( UIntPtr cameraPointer ,  Vec2 screenPosition ,   ref Vec3 rayBegin ,   ref Vec3 rayEnd ) {
          NativeManager.OutboundManifest["ICamera"]["ScreenSpaceRayProjection"]
        .DynamicInvoke(new object[] {  cameraPointer ,  screenPosition ,  rayBegin ,  rayEnd  } );
    }

    public static Boolean CheckEntityVisibility( UIntPtr cameraPointer ,  UIntPtr entityPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ICamera"]["CheckEntityVisibility"]
        .DynamicInvoke(new object[] {  cameraPointer ,  entityPointer  } );
    }

    public static void SetPosition( UIntPtr cameraPointer ,  Vec3 position ) {
          NativeManager.OutboundManifest["ICamera"]["SetPosition"]
        .DynamicInvoke(new object[] {  cameraPointer ,  position  } );
    }

    public static void SetViewVolume( UIntPtr cameraPointer ,  Boolean perspective ,  Single dLeft ,  Single dRight ,  Single dBottom ,  Single dTop ,  Single dNear ,  Single dFar ) {
          NativeManager.OutboundManifest["ICamera"]["SetViewVolume"]
        .DynamicInvoke(new object[] {  cameraPointer ,  perspective ,  dLeft ,  dRight ,  dBottom ,  dTop ,  dNear ,  dFar  } );
    }

    public static void GetNearPlanePointsStatic(  ref MatrixFrame cameraFrame ,  Single verticalFov ,  Single aspectRatioXY ,  Single newDNear ,  Single newDFar ,  IntPtr nearPlanePoints ) {
          NativeManager.OutboundManifest["ICamera"]["GetNearPlanePointsStatic"]
        .DynamicInvoke(new object[] {  cameraFrame ,  verticalFov ,  aspectRatioXY ,  newDNear ,  newDFar ,  nearPlanePoints  } );
    }

    public static void GetNearPlanePoints( UIntPtr cameraPointer ,  IntPtr nearPlanePoints ) {
          NativeManager.OutboundManifest["ICamera"]["GetNearPlanePoints"]
        .DynamicInvoke(new object[] {  cameraPointer ,  nearPlanePoints  } );
    }

    public static void SetFovVertical( UIntPtr cameraPointer ,  Single verticalFov ,  Single aspectRatio ,  Single newDNear ,  Single newDFar ) {
          NativeManager.OutboundManifest["ICamera"]["SetFovVertical"]
        .DynamicInvoke(new object[] {  cameraPointer ,  verticalFov ,  aspectRatio ,  newDNear ,  newDFar  } );
    }

    public static void GetViewProjMatrix( UIntPtr cameraPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["ICamera"]["GetViewProjMatrix"]
        .DynamicInvoke(new object[] {  cameraPointer ,  frame  } );
    }

    public static void SetFovHorizontal( UIntPtr cameraPointer ,  Single horizontalFov ,  Single aspectRatio ,  Single newDNear ,  Single newDFar ) {
          NativeManager.OutboundManifest["ICamera"]["SetFovHorizontal"]
        .DynamicInvoke(new object[] {  cameraPointer ,  horizontalFov ,  aspectRatio ,  newDNear ,  newDFar  } );
    }

    public static Single GetFovVertical( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetFovVertical"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static Single GetFovHorizontal( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetFovHorizontal"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static Single GetAspectRatio( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetAspectRatio"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static void FillParametersFrom( UIntPtr cameraPointer ,  UIntPtr otherCameraPointer ) {
          NativeManager.OutboundManifest["ICamera"]["FillParametersFrom"]
        .DynamicInvoke(new object[] {  cameraPointer ,  otherCameraPointer  } );
    }

    public static void RenderFrustrum( UIntPtr cameraPointer ) {
          NativeManager.OutboundManifest["ICamera"]["RenderFrustrum"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static void SetFrame( UIntPtr cameraPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["ICamera"]["SetFrame"]
        .DynamicInvoke(new object[] {  cameraPointer ,  frame  } );
    }

    public static void GetFrame( UIntPtr cameraPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ICamera"]["GetFrame"]
        .DynamicInvoke(new object[] {  cameraPointer ,  outFrame  } );
    }

    public static Single GetNear( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetNear"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static Single GetFar( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetFar"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static Single GetHorizontalFov( UIntPtr cameraPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ICamera"]["GetHorizontalFov"]
        .DynamicInvoke(new object[] {  cameraPointer  } );
    }

    public static void ViewportPointToWorldRay( UIntPtr cameraPointer ,   ref Vec3 rayBegin ,   ref Vec3 rayEnd ,  Vec3 viewportPoint ) {
          NativeManager.OutboundManifest["ICamera"]["ViewportPointToWorldRay"]
        .DynamicInvoke(new object[] {  cameraPointer ,  rayBegin ,  rayEnd ,  viewportPoint  } );
    }

    public static Vec3 WorldPointToViewportPoint( UIntPtr cameraPointer ,   ref Vec3 worldPoint ) {
         return   (Vec3)  NativeManager.OutboundManifest["ICamera"]["WorldPointToViewportPoint"]
        .DynamicInvoke(new object[] {  cameraPointer ,  worldPoint  } );
    }

    public static Boolean EnclosesPoint( UIntPtr cameraPointer ,  Vec3 pointInWorldSpace ) {
         return   (Boolean)  NativeManager.OutboundManifest["ICamera"]["EnclosesPoint"]
        .DynamicInvoke(new object[] {  cameraPointer ,  pointInWorldSpace  } );
    }

    public static void ConstructCameraFromPositionElevationBearing( Vec3 position ,  Single elevation ,  Single bearing ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ICamera"]["ConstructCameraFromPositionElevationBearing"]
        .DynamicInvoke(new object[] {  position ,  elevation ,  bearing ,  outFrame  } );
    }

    }
}