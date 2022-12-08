
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
    public static class IVideoPlayerView {
    
    public static NativeObjectPointer CreateVideoPlayerView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IVideoPlayerView"]["CreateVideoPlayerView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void PlayVideo( UIntPtr pointer ,  Byte[] videoFileName ,  Byte[] soundFileName ,  Single framerate ) {
          NativeManager.OutboundManifest["IVideoPlayerView"]["PlayVideo"]
        .DynamicInvoke(new object[] {  pointer ,  videoFileName ,  soundFileName ,  framerate  } );
    }

    public static void StopVideo( UIntPtr pointer ) {
          NativeManager.OutboundManifest["IVideoPlayerView"]["StopVideo"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static Boolean IsVideoFinished( UIntPtr pointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IVideoPlayerView"]["IsVideoFinished"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void Finalize( UIntPtr pointer ) {
          NativeManager.OutboundManifest["IVideoPlayerView"]["Finalize"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}