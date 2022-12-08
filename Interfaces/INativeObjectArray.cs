
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
    public static class INativeObjectArray {
    
    public static NativeObjectPointer Create() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["INativeObjectArray"]["Create"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetCount( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["INativeObjectArray"]["GetCount"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void AddElement( UIntPtr pointer ,  UIntPtr nativeObject ) {
          NativeManager.OutboundManifest["INativeObjectArray"]["AddElement"]
        .DynamicInvoke(new object[] {  pointer ,  nativeObject  } );
    }

    public static NativeObjectPointer GetElementAtIndex( UIntPtr pointer ,  Int32 index ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["INativeObjectArray"]["GetElementAtIndex"]
        .DynamicInvoke(new object[] {  pointer ,  index  } );
    }

    public static void Clear( UIntPtr pointer ) {
          NativeManager.OutboundManifest["INativeObjectArray"]["Clear"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}