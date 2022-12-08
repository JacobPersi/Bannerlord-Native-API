
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
    public static class IGameEntityComponent {
    
    public static NativeObjectPointer GetEntity( UIntPtr entityComponent ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntityComponent"]["GetEntity"]
        .DynamicInvoke(new object[] {  entityComponent  } );
    }

    public static NativeObjectPointer GetFirstMetaMesh( UIntPtr entityComponent ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IGameEntityComponent"]["GetFirstMetaMesh"]
        .DynamicInvoke(new object[] {  entityComponent  } );
    }

    }
}