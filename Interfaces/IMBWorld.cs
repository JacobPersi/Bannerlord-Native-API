
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
    public static class IMBWorld {
    
    public static Single GetGlobalTime( TimeType timeType ) {
         return   (Single)  NativeManager.OutboundManifest["IMBWorld"]["GetGlobalTime"]
        .DynamicInvoke(new object[] {  timeType  } );
    }

    public static Int32 GetLastMessages() {
         return   (Int32)  NativeManager.OutboundManifest["IMBWorld"]["GetLastMessages"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetGameType() {
         return   (Int32)  NativeManager.OutboundManifest["IMBWorld"]["GetGameType"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetGameType( Int32 gameType ) {
          NativeManager.OutboundManifest["IMBWorld"]["SetGameType"]
        .DynamicInvoke(new object[] {  gameType  } );
    }

    public static void PauseGame() {
          NativeManager.OutboundManifest["IMBWorld"]["PauseGame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UnpauseGame() {
          NativeManager.OutboundManifest["IMBWorld"]["UnpauseGame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetMeshUsed( Byte[] meshName ) {
          NativeManager.OutboundManifest["IMBWorld"]["SetMeshUsed"]
        .DynamicInvoke(new object[] {  meshName  } );
    }

    public static void SetMaterialUsed( Byte[] materialName ) {
          NativeManager.OutboundManifest["IMBWorld"]["SetMaterialUsed"]
        .DynamicInvoke(new object[] {  materialName  } );
    }

    public static void SetBodyUsed( Byte[] bodyName ) {
          NativeManager.OutboundManifest["IMBWorld"]["SetBodyUsed"]
        .DynamicInvoke(new object[] {  bodyName  } );
    }

    public static void FixSkeletons() {
          NativeManager.OutboundManifest["IMBWorld"]["FixSkeletons"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void CheckResourceModifications() {
          NativeManager.OutboundManifest["IMBWorld"]["CheckResourceModifications"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}