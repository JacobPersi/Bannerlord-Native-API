
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
    public static class IClothSimulatorComponent {
    
    public static void SetMaxDistanceMultiplier( UIntPtr cloth_pointer ,  Single multiplier ) {
          NativeManager.OutboundManifest["IClothSimulatorComponent"]["SetMaxDistanceMultiplier"]
        .DynamicInvoke(new object[] {  cloth_pointer ,  multiplier  } );
    }

    }
}