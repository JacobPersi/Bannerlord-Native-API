
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
    public static class ITelemetry {
    
    public static UInt32 GetTelemetryLevelMask() {
         return   (UInt32)  NativeManager.OutboundManifest["ITelemetry"]["GetTelemetryLevelMask"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}