
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
    public static class IMBPeer {
    
    public static void SetUserData( Int32 index ,  Int32 data ) {
          NativeManager.OutboundManifest["IMBPeer"]["SetUserData"]
        .DynamicInvoke(new object[] {  index ,  data  } );
    }

    public static void SetControlledAgent( Int32 index ,  UIntPtr missionPointer ,  Int32 agentIndex ) {
          NativeManager.OutboundManifest["IMBPeer"]["SetControlledAgent"]
        .DynamicInvoke(new object[] {  index ,  missionPointer ,  agentIndex  } );
    }

    public static void SetTeam( Int32 index ,  Int32 teamIndex ) {
          NativeManager.OutboundManifest["IMBPeer"]["SetTeam"]
        .DynamicInvoke(new object[] {  index ,  teamIndex  } );
    }

    public static Boolean IsActive( Int32 index ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBPeer"]["IsActive"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void SetIsSynchronized( Int32 index ,  Boolean value ) {
          NativeManager.OutboundManifest["IMBPeer"]["SetIsSynchronized"]
        .DynamicInvoke(new object[] {  index ,  value  } );
    }

    public static Boolean GetIsSynchronized( Int32 index ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBPeer"]["GetIsSynchronized"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void SendExistingObjects( Int32 index ,  UIntPtr missionPointer ) {
          NativeManager.OutboundManifest["IMBPeer"]["SendExistingObjects"]
        .DynamicInvoke(new object[] {  index ,  missionPointer  } );
    }

    public static void BeginModuleEvent( Int32 index ,  Boolean isReliable ) {
          NativeManager.OutboundManifest["IMBPeer"]["BeginModuleEvent"]
        .DynamicInvoke(new object[] {  index ,  isReliable  } );
    }

    public static void EndModuleEvent( Boolean isReliable ) {
          NativeManager.OutboundManifest["IMBPeer"]["EndModuleEvent"]
        .DynamicInvoke(new object[] {  isReliable  } );
    }

    public static Double GetAveragePingInMilliseconds( Int32 index ) {
         return   (Double)  NativeManager.OutboundManifest["IMBPeer"]["GetAveragePingInMilliseconds"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Double GetAverageLossPercent( Int32 index ) {
         return   (Double)  NativeManager.OutboundManifest["IMBPeer"]["GetAverageLossPercent"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void SetRelevantGameOptions( Int32 index ,  Boolean sendMeBloodEvents ,  Boolean sendMeSoundEvents ) {
          NativeManager.OutboundManifest["IMBPeer"]["SetRelevantGameOptions"]
        .DynamicInvoke(new object[] {  index ,  sendMeBloodEvents ,  sendMeSoundEvents  } );
    }

    public static UInt32 GetReversedHost( Int32 index ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMBPeer"]["GetReversedHost"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static UInt32 GetHost( Int32 index ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMBPeer"]["GetHost"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static UInt16 GetPort( Int32 index ) {
         return   (UInt16)  NativeManager.OutboundManifest["IMBPeer"]["GetPort"]
        .DynamicInvoke(new object[] {  index  } );
    }

    }
}