
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
    public static class IThumbnailCreatorView {
    
    public static NativeObjectPointer CreateThumbnailCreatorView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IThumbnailCreatorView"]["CreateThumbnailCreatorView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void RegisterScene( UIntPtr pointer ,  UIntPtr scene_ptr ,  Boolean use_postfx ) {
          NativeManager.OutboundManifest["IThumbnailCreatorView"]["RegisterScene"]
        .DynamicInvoke(new object[] {  pointer ,  scene_ptr ,  use_postfx  } );
    }

    public static void ClearRequests( UIntPtr pointer ) {
          NativeManager.OutboundManifest["IThumbnailCreatorView"]["ClearRequests"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void CancelRequest( UIntPtr pointer ,  Byte[] render_id ) {
          NativeManager.OutboundManifest["IThumbnailCreatorView"]["CancelRequest"]
        .DynamicInvoke(new object[] {  pointer ,  render_id  } );
    }

    public static void RegisterEntity( UIntPtr pointer ,  UIntPtr scene_ptr ,  UIntPtr cam_ptr ,  UIntPtr texture_ptr ,  UIntPtr entity_ptr ,  Byte[] render_id ,  Int32 allocationGroupIndex ) {
          NativeManager.OutboundManifest["IThumbnailCreatorView"]["RegisterEntity"]
        .DynamicInvoke(new object[] {  pointer ,  scene_ptr ,  cam_ptr ,  texture_ptr ,  entity_ptr ,  render_id ,  allocationGroupIndex  } );
    }

    public static void RegisterEntityWithoutTexture( UIntPtr pointer ,  UIntPtr scene_ptr ,  UIntPtr cam_ptr ,  UIntPtr entity_ptr ,  Int32 width ,  Int32 height ,  Byte[] render_id ,  Byte[] debug_name ,  Int32 allocationGroupIndex ) {
          NativeManager.OutboundManifest["IThumbnailCreatorView"]["RegisterEntityWithoutTexture"]
        .DynamicInvoke(new object[] {  pointer ,  scene_ptr ,  cam_ptr ,  entity_ptr ,  width ,  height ,  render_id ,  debug_name ,  allocationGroupIndex  } );
    }

    public static Int32 GetNumberOfPendingRequests( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IThumbnailCreatorView"]["GetNumberOfPendingRequests"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static Boolean IsMemoryCleared( UIntPtr pointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IThumbnailCreatorView"]["IsMemoryCleared"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}