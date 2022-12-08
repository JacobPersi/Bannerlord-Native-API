
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
    public static class INativeStringHelper {
    
    public static UIntPtr CreateRglVarString( Byte[] text ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["INativeStringHelper"]["CreateRglVarString"]
        .DynamicInvoke(new object[] {  text  } );
    }

    public static UIntPtr GetThreadLocalCachedRglVarString() {
         return   (UIntPtr)  NativeManager.OutboundManifest["INativeStringHelper"]["GetThreadLocalCachedRglVarString"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetRglVarString( UIntPtr pointer ,  Byte[] text ) {
          NativeManager.OutboundManifest["INativeStringHelper"]["SetRglVarString"]
        .DynamicInvoke(new object[] {  pointer ,  text  } );
    }

    public static void DeleteRglVarString( UIntPtr pointer ) {
          NativeManager.OutboundManifest["INativeStringHelper"]["DeleteRglVarString"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}