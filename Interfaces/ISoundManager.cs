
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
    public static class ISoundManager {
    
    public static void SetListenerFrame(  ref MatrixFrame frame ,   ref Vec3 attenuationPosition ) {
          NativeManager.OutboundManifest["ISoundManager"]["SetListenerFrame"]
        .DynamicInvoke(new object[] {  frame ,  attenuationPosition  } );
    }

    public static void GetListenerFrame(  ref MatrixFrame result ) {
          NativeManager.OutboundManifest["ISoundManager"]["GetListenerFrame"]
        .DynamicInvoke(new object[] {  result  } );
    }

    public static void GetAttenuationPosition(  ref Vec3 result ) {
          NativeManager.OutboundManifest["ISoundManager"]["GetAttenuationPosition"]
        .DynamicInvoke(new object[] {  result  } );
    }

    public static void Reset() {
          NativeManager.OutboundManifest["ISoundManager"]["Reset"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean StartOneShotEventWithParam( Byte[] eventFullName ,  Vec3 position ,  Byte[] paramName ,  Single paramValue ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundManager"]["StartOneShotEventWithParam"]
        .DynamicInvoke(new object[] {  eventFullName ,  position ,  paramName ,  paramValue  } );
    }

    public static Boolean StartOneShotEvent( Byte[] eventFullName ,  Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundManager"]["StartOneShotEvent"]
        .DynamicInvoke(new object[] {  eventFullName ,  position  } );
    }

    public static void SetState( Byte[] stateGroup ,  Byte[] state ) {
          NativeManager.OutboundManifest["ISoundManager"]["SetState"]
        .DynamicInvoke(new object[] {  stateGroup ,  state  } );
    }

    public static void LoadEventFileAux( Byte[] soundBankName ,  Boolean decompressSamples ) {
          NativeManager.OutboundManifest["ISoundManager"]["LoadEventFileAux"]
        .DynamicInvoke(new object[] {  soundBankName ,  decompressSamples  } );
    }

    public static void SetGlobalParameter( Byte[] parameterName ,  Single value ) {
          NativeManager.OutboundManifest["ISoundManager"]["SetGlobalParameter"]
        .DynamicInvoke(new object[] {  parameterName ,  value  } );
    }

    public static void AddSoundClientWithId( UInt64 client_id ) {
          NativeManager.OutboundManifest["ISoundManager"]["AddSoundClientWithId"]
        .DynamicInvoke(new object[] {  client_id  } );
    }

    public static void DeleteSoundClientWithId( UInt64 client_id ) {
          NativeManager.OutboundManifest["ISoundManager"]["DeleteSoundClientWithId"]
        .DynamicInvoke(new object[] {  client_id  } );
    }

    public static Int32 GetGlobalIndexOfEvent( Byte[] eventFullName ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundManager"]["GetGlobalIndexOfEvent"]
        .DynamicInvoke(new object[] {  eventFullName  } );
    }

    public static void CreateVoiceEvent() {
          NativeManager.OutboundManifest["ISoundManager"]["CreateVoiceEvent"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DestroyVoiceEvent( Int32 id ) {
          NativeManager.OutboundManifest["ISoundManager"]["DestroyVoiceEvent"]
        .DynamicInvoke(new object[] {  id  } );
    }

    public static void InitializeVoicePlayEvent() {
          NativeManager.OutboundManifest["ISoundManager"]["InitializeVoicePlayEvent"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void FinalizeVoicePlayEvent() {
          NativeManager.OutboundManifest["ISoundManager"]["FinalizeVoicePlayEvent"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void StartVoiceRecord() {
          NativeManager.OutboundManifest["ISoundManager"]["StartVoiceRecord"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void StopVoiceRecord() {
          NativeManager.OutboundManifest["ISoundManager"]["StopVoiceRecord"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetVoiceData( ManagedArray voiceBuffer ,  Int32 chunkSize ,   ref Int32 readBytesLength ) {
          NativeManager.OutboundManifest["ISoundManager"]["GetVoiceData"]
        .DynamicInvoke(new object[] {  voiceBuffer ,  chunkSize ,  readBytesLength  } );
    }

    public static void UpdateVoiceToPlay( ManagedArray voiceBuffer ,  Int32 length ,  Int32 index ) {
          NativeManager.OutboundManifest["ISoundManager"]["UpdateVoiceToPlay"]
        .DynamicInvoke(new object[] {  voiceBuffer ,  length ,  index  } );
    }

    public static void CompressData( UInt64 clientID ,  ManagedArray buffer ,  Int32 length ,  ManagedArray compressedBuffer ,   ref Int32 compressedBufferLength ) {
          NativeManager.OutboundManifest["ISoundManager"]["CompressData"]
        .DynamicInvoke(new object[] {  clientID ,  buffer ,  length ,  compressedBuffer ,  compressedBufferLength  } );
    }

    public static void DecompressData( UInt64 clientID ,  ManagedArray compressedBuffer ,  Int32 compressedBufferLength ,  ManagedArray decompressedBuffer ,   ref Int32 decompressedBufferLength ) {
          NativeManager.OutboundManifest["ISoundManager"]["DecompressData"]
        .DynamicInvoke(new object[] {  clientID ,  compressedBuffer ,  compressedBufferLength ,  decompressedBuffer ,  decompressedBufferLength  } );
    }

    public static void RemoveXBOXRemoteUser( UInt64 XUID ) {
          NativeManager.OutboundManifest["ISoundManager"]["RemoveXBOXRemoteUser"]
        .DynamicInvoke(new object[] {  XUID  } );
    }

    public static void AddXBOXRemoteUser( UInt64 XUID ,  UInt64 deviceID ,  Boolean canSendMicSound ,  Boolean canSendTextSound ,  Boolean canSendText ,  Boolean canReceiveSound ,  Boolean canReceiveText ) {
          NativeManager.OutboundManifest["ISoundManager"]["AddXBOXRemoteUser"]
        .DynamicInvoke(new object[] {  XUID ,  deviceID ,  canSendMicSound ,  canSendTextSound ,  canSendText ,  canReceiveSound ,  canReceiveText  } );
    }

    public static void InitializeXBOXSoundManager() {
          NativeManager.OutboundManifest["ISoundManager"]["InitializeXBOXSoundManager"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ApplyPushToTalk( Boolean pushed ) {
          NativeManager.OutboundManifest["ISoundManager"]["ApplyPushToTalk"]
        .DynamicInvoke(new object[] {  pushed  } );
    }

    public static void ClearXBOXSoundManager() {
          NativeManager.OutboundManifest["ISoundManager"]["ClearXBOXSoundManager"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UpdateXBOXLocalUser() {
          NativeManager.OutboundManifest["ISoundManager"]["UpdateXBOXLocalUser"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UpdateXBOXChatCommunicationFlags( UInt64 XUID ,  Boolean canSendMicSound ,  Boolean canSendTextSound ,  Boolean canSendText ,  Boolean canReceiveSound ,  Boolean canReceiveText ) {
          NativeManager.OutboundManifest["ISoundManager"]["UpdateXBOXChatCommunicationFlags"]
        .DynamicInvoke(new object[] {  XUID ,  canSendMicSound ,  canSendTextSound ,  canSendText ,  canReceiveSound ,  canReceiveText  } );
    }

    public static void ProcessDataToBeReceived( UInt64 senderDeviceID ,  ManagedArray data ,  UInt32 dataSize ) {
          NativeManager.OutboundManifest["ISoundManager"]["ProcessDataToBeReceived"]
        .DynamicInvoke(new object[] {  senderDeviceID ,  data ,  dataSize  } );
    }

    public static void ProcessDataToBeSent(  ref Int32 numData ) {
          NativeManager.OutboundManifest["ISoundManager"]["ProcessDataToBeSent"]
        .DynamicInvoke(new object[] {  numData  } );
    }

    public static void HandleStateChanges() {
          NativeManager.OutboundManifest["ISoundManager"]["HandleStateChanges"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetSizeOfDataToBeSentAt( Int32 index ,   ref UInt32 byte_count ,   ref UInt32 numReceivers ) {
          NativeManager.OutboundManifest["ISoundManager"]["GetSizeOfDataToBeSentAt"]
        .DynamicInvoke(new object[] {  index ,  byte_count ,  numReceivers  } );
    }

    public static Boolean GetDataToBeSentAt( Int32 index ,  ManagedArray buffer ,  IntPtr receivers ,   ref Boolean transportGuaranteed ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundManager"]["GetDataToBeSentAt"]
        .DynamicInvoke(new object[] {  index ,  buffer ,  receivers ,  transportGuaranteed  } );
    }

    public static void ClearDataToBeSent() {
          NativeManager.OutboundManifest["ISoundManager"]["ClearDataToBeSent"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}