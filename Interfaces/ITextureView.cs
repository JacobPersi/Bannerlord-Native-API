
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
    public static class ITextureView {
    
    public static NativeObjectPointer CreateTextureView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITextureView"]["CreateTextureView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetTexture( UIntPtr pointer ,  UIntPtr texture_ptr ) {
          NativeManager.OutboundManifest["ITextureView"]["SetTexture"]
        .DynamicInvoke(new object[] {  pointer ,  texture_ptr  } );
    }

    }
}