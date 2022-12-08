
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
    public static class IView {
    
    public static void SetRenderOption( UIntPtr ptr ,  Int32 optionEnum ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetRenderOption"]
        .DynamicInvoke(new object[] {  ptr ,  optionEnum ,  value  } );
    }

    public static void SetRenderOrder( UIntPtr ptr ,  Int32 value ) {
          NativeManager.OutboundManifest["IView"]["SetRenderOrder"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetRenderTarget( UIntPtr ptr ,  UIntPtr texture_ptr ) {
          NativeManager.OutboundManifest["IView"]["SetRenderTarget"]
        .DynamicInvoke(new object[] {  ptr ,  texture_ptr  } );
    }

    public static void SetDepthTarget( UIntPtr ptr ,  UIntPtr texture_ptr ) {
          NativeManager.OutboundManifest["IView"]["SetDepthTarget"]
        .DynamicInvoke(new object[] {  ptr ,  texture_ptr  } );
    }

    public static void SetScale( UIntPtr ptr ,  Single x ,  Single y ) {
          NativeManager.OutboundManifest["IView"]["SetScale"]
        .DynamicInvoke(new object[] {  ptr ,  x ,  y  } );
    }

    public static void SetOffset( UIntPtr ptr ,  Single x ,  Single y ) {
          NativeManager.OutboundManifest["IView"]["SetOffset"]
        .DynamicInvoke(new object[] {  ptr ,  x ,  y  } );
    }

    public static void SetDebugRenderFunctionality( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetDebugRenderFunctionality"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetClearColor( UIntPtr ptr ,  UInt32 rgba ) {
          NativeManager.OutboundManifest["IView"]["SetClearColor"]
        .DynamicInvoke(new object[] {  ptr ,  rgba  } );
    }

    public static void SetEnable( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetEnable"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetRenderOnDemand( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetRenderOnDemand"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetAutoDepthTargetCreation( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetAutoDepthTargetCreation"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetSaveFinalResultToDisk( UIntPtr ptr ,  Boolean value ) {
          NativeManager.OutboundManifest["IView"]["SetSaveFinalResultToDisk"]
        .DynamicInvoke(new object[] {  ptr ,  value  } );
    }

    public static void SetFileNameToSaveResult( UIntPtr ptr ,  Byte[] name ) {
          NativeManager.OutboundManifest["IView"]["SetFileNameToSaveResult"]
        .DynamicInvoke(new object[] {  ptr ,  name  } );
    }

    public static void SetFileTypeToSave( UIntPtr ptr ,  Int32 type ) {
          NativeManager.OutboundManifest["IView"]["SetFileTypeToSave"]
        .DynamicInvoke(new object[] {  ptr ,  type  } );
    }

    public static void SetFilePathToSaveResult( UIntPtr ptr ,  Byte[] name ) {
          NativeManager.OutboundManifest["IView"]["SetFilePathToSaveResult"]
        .DynamicInvoke(new object[] {  ptr ,  name  } );
    }

    }
}