
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
    public static class ILibrarySizeChecker {
    
    public static Int32 GetEngineStructSize( Byte[] str ) {
         return   (Int32)  NativeManager.OutboundManifest["ILibrarySizeChecker"]["GetEngineStructSize"]
        .DynamicInvoke(new object[] {  str  } );
    }

    }
}