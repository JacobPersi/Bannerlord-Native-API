
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
    public static class INativeArray {
    
    public static Int32 GetDataPointerOffset() {
         return   (Int32)  NativeManager.OutboundManifest["INativeArray"]["GetDataPointerOffset"]
        .DynamicInvoke(new object[] {  } );
    }

    public static NativeObjectPointer Create() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["INativeArray"]["Create"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDataSize( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["INativeArray"]["GetDataSize"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static UIntPtr GetDataPointer( UIntPtr pointer ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["INativeArray"]["GetDataPointer"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void AddIntegerElement( UIntPtr pointer ,  Int32 value ) {
          NativeManager.OutboundManifest["INativeArray"]["AddIntegerElement"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void AddFloatElement( UIntPtr pointer ,  Single value ) {
          NativeManager.OutboundManifest["INativeArray"]["AddFloatElement"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void AddElement( UIntPtr pointer ,  IntPtr element ,  Int32 elementSize ) {
          NativeManager.OutboundManifest["INativeArray"]["AddElement"]
        .DynamicInvoke(new object[] {  pointer ,  element ,  elementSize  } );
    }

    public static void Clear( UIntPtr pointer ) {
          NativeManager.OutboundManifest["INativeArray"]["Clear"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}