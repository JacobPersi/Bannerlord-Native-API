
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
    public static class IMBScreen {
    
    public static void OnExitButtonClick() {
          NativeManager.OutboundManifest["IMBScreen"]["OnExitButtonClick"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void OnEditModeEnterPress() {
          NativeManager.OutboundManifest["IMBScreen"]["OnEditModeEnterPress"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void OnEditModeEnterRelease() {
          NativeManager.OutboundManifest["IMBScreen"]["OnEditModeEnterRelease"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}