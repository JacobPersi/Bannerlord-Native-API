
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
    public static class ITableauView {
    
    public static NativeObjectPointer CreateTableauView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITableauView"]["CreateTableauView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetSortingEnabled( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ITableauView"]["SetSortingEnabled"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetContinousRendering( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ITableauView"]["SetContinousRendering"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetDoNotRenderThisFrame( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ITableauView"]["SetDoNotRenderThisFrame"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    public static void SetDeleteAfterRendering( UIntPtr pointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ITableauView"]["SetDeleteAfterRendering"]
        .DynamicInvoke(new object[] {  pointer ,  value  } );
    }

    }
}