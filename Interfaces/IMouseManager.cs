
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
    public static class IMouseManager {
    
    public static void ActivateMouseCursor( Int32 id ) {
          NativeManager.OutboundManifest["IMouseManager"]["ActivateMouseCursor"]
        .DynamicInvoke(new object[] {  id  } );
    }

    public static void SetMouseCursor( Int32 id ,  Byte[] mousePath ) {
          NativeManager.OutboundManifest["IMouseManager"]["SetMouseCursor"]
        .DynamicInvoke(new object[] {  id ,  mousePath  } );
    }

    public static void ShowCursor( Boolean show ) {
          NativeManager.OutboundManifest["IMouseManager"]["ShowCursor"]
        .DynamicInvoke(new object[] {  show  } );
    }

    public static void LockCursorAtCurrentPosition( Boolean lockCursor ) {
          NativeManager.OutboundManifest["IMouseManager"]["LockCursorAtCurrentPosition"]
        .DynamicInvoke(new object[] {  lockCursor  } );
    }

    public static void LockCursorAtPosition( Single x ,  Single y ) {
          NativeManager.OutboundManifest["IMouseManager"]["LockCursorAtPosition"]
        .DynamicInvoke(new object[] {  x ,  y  } );
    }

    public static void UnlockCursor() {
          NativeManager.OutboundManifest["IMouseManager"]["UnlockCursor"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}