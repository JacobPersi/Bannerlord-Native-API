
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
    public static class IMBEditor {
    
    public static Boolean IsEditMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsEditModeEnabled() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsEditModeEnabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UpdateSceneTree() {
          NativeManager.OutboundManifest["IMBEditor"]["UpdateSceneTree"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsEntitySelected( UIntPtr entityId ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsEntitySelected"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void AddEditorWarning( Byte[] msg ) {
          NativeManager.OutboundManifest["IMBEditor"]["AddEditorWarning"]
        .DynamicInvoke(new object[] {  msg  } );
    }

    public static void RenderEditorMesh( UIntPtr metaMeshId ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IMBEditor"]["RenderEditorMesh"]
        .DynamicInvoke(new object[] {  metaMeshId ,  frame  } );
    }

    public static void EnterEditMode( UIntPtr sceneWidgetPointer ,   ref MatrixFrame initialCameraFrame ,  Single initialCameraElevation ,  Single initialCameraBearing ) {
          NativeManager.OutboundManifest["IMBEditor"]["EnterEditMode"]
        .DynamicInvoke(new object[] {  sceneWidgetPointer ,  initialCameraFrame ,  initialCameraElevation ,  initialCameraBearing  } );
    }

    public static void TickEditMode( Single dt ) {
          NativeManager.OutboundManifest["IMBEditor"]["TickEditMode"]
        .DynamicInvoke(new object[] {  dt  } );
    }

    public static void LeaveEditMode() {
          NativeManager.OutboundManifest["IMBEditor"]["LeaveEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EnterEditMissionMode( UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBEditor"]["EnterEditMissionMode"]
        .DynamicInvoke(new object[] {  missionPointer  } );
    }

    public static void LeaveEditMissionMode() {
          NativeManager.OutboundManifest["IMBEditor"]["LeaveEditMissionMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ActivateSceneEditorPresentation() {
          NativeManager.OutboundManifest["IMBEditor"]["ActivateSceneEditorPresentation"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DeactivateSceneEditorPresentation() {
          NativeManager.OutboundManifest["IMBEditor"]["DeactivateSceneEditorPresentation"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void TickSceneEditorPresentation( Single dt ) {
          NativeManager.OutboundManifest["IMBEditor"]["TickSceneEditorPresentation"]
        .DynamicInvoke(new object[] {  dt  } );
    }

    public static NativeObjectPointer GetEditorSceneView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBEditor"]["GetEditorSceneView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean HelpersEnabled() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["HelpersEnabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean BorderHelpersEnabled() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["BorderHelpersEnabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ZoomToPosition( Vec3 pos ) {
          NativeManager.OutboundManifest["IMBEditor"]["ZoomToPosition"]
        .DynamicInvoke(new object[] {  pos  } );
    }

    public static void AddEntityWarning( UIntPtr entityId ,  Byte[] msg ) {
          NativeManager.OutboundManifest["IMBEditor"]["AddEntityWarning"]
        .DynamicInvoke(new object[] {  entityId ,  msg  } );
    }

    public static Int32 GetAllPrefabsAndChildWithTag( Byte[] tag ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBEditor"]["GetAllPrefabsAndChildWithTag"]
        .DynamicInvoke(new object[] {  tag  } );
    }

    public static void SetUpgradeLevelVisibility( Byte[] cumulated_string ) {
          NativeManager.OutboundManifest["IMBEditor"]["SetUpgradeLevelVisibility"]
        .DynamicInvoke(new object[] {  cumulated_string  } );
    }

    public static void ExitEditMode() {
          NativeManager.OutboundManifest["IMBEditor"]["ExitEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsReplayManagerRecording() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsReplayManagerRecording"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsReplayManagerRendering() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsReplayManagerRendering"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsReplayManagerReplaying() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBEditor"]["IsReplayManagerReplaying"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}