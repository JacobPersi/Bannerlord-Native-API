
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
    public static class INativeString {
    
    public static NativeObjectPointer Create() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["INativeString"]["Create"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetString( UIntPtr nativeString ) {
         return   (Int32)  NativeManager.OutboundManifest["INativeString"]["GetString"]
        .DynamicInvoke(new object[] {  nativeString  } );
    }

    public static void SetString( UIntPtr nativeString ,  Byte[] newString ) {
          NativeManager.OutboundManifest["INativeString"]["SetString"]
        .DynamicInvoke(new object[] {  nativeString ,  newString  } );
    }

    }
}