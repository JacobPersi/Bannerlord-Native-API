
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
    public static class IMBNetwork {
    
    public static Boolean GetMultiplayerDisabled() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["GetMultiplayerDisabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsDedicatedServer() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["IsDedicatedServer"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void InitializeServerSide( Int32 port ) {
          NativeManager.OutboundManifest["IMBNetwork"]["InitializeServerSide"]
        .DynamicInvoke(new object[] {  port  } );
    }

    public static void InitializeClientSide( Byte[] serverAddress ,  Int32 port ,  Int32 sessionKey ,  Int32 playerIndex ) {
          NativeManager.OutboundManifest["IMBNetwork"]["InitializeClientSide"]
        .DynamicInvoke(new object[] {  serverAddress ,  port ,  sessionKey ,  playerIndex  } );
    }

    public static void TerminateServerSide() {
          NativeManager.OutboundManifest["IMBNetwork"]["TerminateServerSide"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void TerminateClientSide() {
          NativeManager.OutboundManifest["IMBNetwork"]["TerminateClientSide"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ServerPing( Byte[] serverAddress ,  Int32 port ) {
          NativeManager.OutboundManifest["IMBNetwork"]["ServerPing"]
        .DynamicInvoke(new object[] {  serverAddress ,  port  } );
    }

    public static void AddPeerToDisconnect( Int32 peer ) {
          NativeManager.OutboundManifest["IMBNetwork"]["AddPeerToDisconnect"]
        .DynamicInvoke(new object[] {  peer  } );
    }

    public static void PrepareNewUdpSession( Int32 player ,  Int32 sessionKey ) {
          NativeManager.OutboundManifest["IMBNetwork"]["PrepareNewUdpSession"]
        .DynamicInvoke(new object[] {  player ,  sessionKey  } );
    }

    public static Boolean CanAddNewPlayersOnServer( Int32 numPlayers ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["CanAddNewPlayersOnServer"]
        .DynamicInvoke(new object[] {  numPlayers  } );
    }

    public static Int32 AddNewPlayerOnServer( Boolean serverPlayer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBNetwork"]["AddNewPlayerOnServer"]
        .DynamicInvoke(new object[] {  serverPlayer  } );
    }

    public static Int32 AddNewBotOnServer() {
         return   (Int32)  NativeManager.OutboundManifest["IMBNetwork"]["AddNewBotOnServer"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void RemoveBotOnServer( Int32 botPlayerIndex ) {
          NativeManager.OutboundManifest["IMBNetwork"]["RemoveBotOnServer"]
        .DynamicInvoke(new object[] {  botPlayerIndex  } );
    }

    public static void ResetMissionData() {
          NativeManager.OutboundManifest["IMBNetwork"]["ResetMissionData"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void BeginBroadcastModuleEvent() {
          NativeManager.OutboundManifest["IMBNetwork"]["BeginBroadcastModuleEvent"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EndBroadcastModuleEvent( Int32 broadcastFlags ,  Int32 targetPlayer ,  Boolean isReliable ) {
          NativeManager.OutboundManifest["IMBNetwork"]["EndBroadcastModuleEvent"]
        .DynamicInvoke(new object[] {  broadcastFlags ,  targetPlayer ,  isReliable  } );
    }

    public static Double ElapsedTimeSinceLastUdpPacketArrived() {
         return   (Double)  NativeManager.OutboundManifest["IMBNetwork"]["ElapsedTimeSinceLastUdpPacketArrived"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void BeginModuleEventAsClient( Boolean isReliable ) {
          NativeManager.OutboundManifest["IMBNetwork"]["BeginModuleEventAsClient"]
        .DynamicInvoke(new object[] {  isReliable  } );
    }

    public static void EndModuleEventAsClient( Boolean isReliable ) {
          NativeManager.OutboundManifest["IMBNetwork"]["EndModuleEventAsClient"]
        .DynamicInvoke(new object[] {  isReliable  } );
    }

    public static Boolean ReadIntFromPacket(  ref Integer compressionInfo ,   ref Int32 output ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["ReadIntFromPacket"]
        .DynamicInvoke(new object[] {  compressionInfo ,  output  } );
    }

    public static Boolean ReadUintFromPacket(  ref UnsignedInteger compressionInfo ,   ref UInt32 output ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["ReadUintFromPacket"]
        .DynamicInvoke(new object[] {  compressionInfo ,  output  } );
    }

    public static Boolean ReadLongFromPacket(  ref LongInteger compressionInfo ,   ref Int64 output ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["ReadLongFromPacket"]
        .DynamicInvoke(new object[] {  compressionInfo ,  output  } );
    }

    public static Boolean ReadUlongFromPacket(  ref UnsignedLongInteger compressionInfo ,   ref UInt64 output ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["ReadUlongFromPacket"]
        .DynamicInvoke(new object[] {  compressionInfo ,  output  } );
    }

    public static Boolean ReadFloatFromPacket(  ref Float compressionInfo ,   ref Single output ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBNetwork"]["ReadFloatFromPacket"]
        .DynamicInvoke(new object[] {  compressionInfo ,  output  } );
    }

    public static Int32 ReadStringFromPacket(  ref Boolean bufferReadValid ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBNetwork"]["ReadStringFromPacket"]
        .DynamicInvoke(new object[] {  bufferReadValid  } );
    }

    public static void WriteIntToPacket( Int32 value ,   ref Integer compressionInfo ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteIntToPacket"]
        .DynamicInvoke(new object[] {  value ,  compressionInfo  } );
    }

    public static void WriteUintToPacket( UInt32 value ,   ref UnsignedInteger compressionInfo ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteUintToPacket"]
        .DynamicInvoke(new object[] {  value ,  compressionInfo  } );
    }

    public static void WriteLongToPacket( Int64 value ,   ref LongInteger compressionInfo ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteLongToPacket"]
        .DynamicInvoke(new object[] {  value ,  compressionInfo  } );
    }

    public static void WriteUlongToPacket( UInt64 value ,   ref UnsignedLongInteger compressionInfo ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteUlongToPacket"]
        .DynamicInvoke(new object[] {  value ,  compressionInfo  } );
    }

    public static void WriteFloatToPacket( Single value ,   ref Float compressionInfo ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteFloatToPacket"]
        .DynamicInvoke(new object[] {  value ,  compressionInfo  } );
    }

    public static void WriteStringToPacket( Byte[] value ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteStringToPacket"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Int32 ReadByteArrayFromPacket( ManagedArray buffer ,  Int32 offset ,  Int32 bufferCapacity ,   ref Boolean bufferReadValid ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBNetwork"]["ReadByteArrayFromPacket"]
        .DynamicInvoke(new object[] {  buffer ,  offset ,  bufferCapacity ,  bufferReadValid  } );
    }

    public static void WriteByteArrayToPacket( ManagedArray value ,  Int32 offset ,  Int32 size ) {
          NativeManager.OutboundManifest["IMBNetwork"]["WriteByteArrayToPacket"]
        .DynamicInvoke(new object[] {  value ,  offset ,  size  } );
    }

    public static void IncreaseTotalUploadLimit( Int32 value ) {
          NativeManager.OutboundManifest["IMBNetwork"]["IncreaseTotalUploadLimit"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void ResetDebugVariables() {
          NativeManager.OutboundManifest["IMBNetwork"]["ResetDebugVariables"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void PrintDebugStats() {
          NativeManager.OutboundManifest["IMBNetwork"]["PrintDebugStats"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetAveragePacketLossRatio() {
         return   (Single)  NativeManager.OutboundManifest["IMBNetwork"]["GetAveragePacketLossRatio"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetDebugUploadsInBits(  ref DebugNetworkPacketStatisticsStruct networkStatisticsStruct ,   ref DebugNetworkPositionCompressionStatisticsStruct posStatisticsStruct ) {
          NativeManager.OutboundManifest["IMBNetwork"]["GetDebugUploadsInBits"]
        .DynamicInvoke(new object[] {  networkStatisticsStruct ,  posStatisticsStruct  } );
    }

    public static void ResetDebugUploads() {
          NativeManager.OutboundManifest["IMBNetwork"]["ResetDebugUploads"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void PrintReplicationTableStatistics() {
          NativeManager.OutboundManifest["IMBNetwork"]["PrintReplicationTableStatistics"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ClearReplicationTableStatistics() {
          NativeManager.OutboundManifest["IMBNetwork"]["ClearReplicationTableStatistics"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}