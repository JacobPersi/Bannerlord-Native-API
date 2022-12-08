
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
    public static class IMBWindowManager {
    
    public static void EraseMessageLines() {
          NativeManager.OutboundManifest["IMBWindowManager"]["EraseMessageLines"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single WorldToScreen( UIntPtr cameraPointer ,  Vec3 worldSpacePosition ,   ref Single screenX ,   ref Single screenY ,   ref Single w ) {
         return   (Single)  NativeManager.OutboundManifest["IMBWindowManager"]["WorldToScreen"]
        .DynamicInvoke(new object[] {  cameraPointer ,  worldSpacePosition ,  screenX ,  screenY ,  w  } );
    }

    public static Single WorldToScreenWithFixedZ( UIntPtr cameraPointer ,  Vec3 cameraPosition ,  Vec3 worldSpacePosition ,   ref Single screenX ,   ref Single screenY ,   ref Single w ) {
         return   (Single)  NativeManager.OutboundManifest["IMBWindowManager"]["WorldToScreenWithFixedZ"]
        .DynamicInvoke(new object[] {  cameraPointer ,  cameraPosition ,  worldSpacePosition ,  screenX ,  screenY ,  w  } );
    }

    public static void DontChangeCursorPos() {
          NativeManager.OutboundManifest["IMBWindowManager"]["DontChangeCursorPos"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void PreDisplay() {
          NativeManager.OutboundManifest["IMBWindowManager"]["PreDisplay"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ScreenToWorld( UIntPtr pointer ,  Single screenX ,  Single screenY ,  Single z ,   ref Vec3 worldSpacePosition ) {
          NativeManager.OutboundManifest["IMBWindowManager"]["ScreenToWorld"]
        .DynamicInvoke(new object[] {  pointer ,  screenX ,  screenY ,  z ,  worldSpacePosition  } );
    }

    }
}