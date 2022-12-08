
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
    public static class IMusic {
    
    public static Int32 GetFreeMusicChannelIndex() {
         return   (Int32)  NativeManager.OutboundManifest["IMusic"]["GetFreeMusicChannelIndex"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void LoadClip( Int32 index ,  Byte[] pathToClip ) {
          NativeManager.OutboundManifest["IMusic"]["LoadClip"]
        .DynamicInvoke(new object[] {  index ,  pathToClip  } );
    }

    public static void UnloadClip( Int32 index ) {
          NativeManager.OutboundManifest["IMusic"]["UnloadClip"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Boolean IsClipLoaded( Int32 index ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMusic"]["IsClipLoaded"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void PlayMusic( Int32 index ) {
          NativeManager.OutboundManifest["IMusic"]["PlayMusic"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void PlayDelayed( Int32 index ,  Int32 delayMilliseconds ) {
          NativeManager.OutboundManifest["IMusic"]["PlayDelayed"]
        .DynamicInvoke(new object[] {  index ,  delayMilliseconds  } );
    }

    public static Boolean IsMusicPlaying( Int32 index ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMusic"]["IsMusicPlaying"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void PauseMusic( Int32 index ) {
          NativeManager.OutboundManifest["IMusic"]["PauseMusic"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void StopMusic( Int32 index ) {
          NativeManager.OutboundManifest["IMusic"]["StopMusic"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void SetVolume( Int32 index ,  Single volume ) {
          NativeManager.OutboundManifest["IMusic"]["SetVolume"]
        .DynamicInvoke(new object[] {  index ,  volume  } );
    }

    }
}