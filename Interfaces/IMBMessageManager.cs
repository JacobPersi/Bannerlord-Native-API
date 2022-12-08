
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
    public static class IMBMessageManager {
    
    public static void DisplayMessage( Byte[] message ) {
          NativeManager.OutboundManifest["IMBMessageManager"]["DisplayMessage"]
        .DynamicInvoke(new object[] {  message  } );
    }

    public static void DisplayMessageWithColor( Byte[] message ,  UInt32 color ) {
          NativeManager.OutboundManifest["IMBMessageManager"]["DisplayMessageWithColor"]
        .DynamicInvoke(new object[] {  message ,  color  } );
    }

    public static void SetMessageManager( Int32 messageManager ) {
          NativeManager.OutboundManifest["IMBMessageManager"]["SetMessageManager"]
        .DynamicInvoke(new object[] {  messageManager  } );
    }

    }
}