
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
    public static class IMBSoundEvent {
    
    public static Int32 CreateEventFromExternalFile( Byte[] programmerSoundEventName ,  Byte[] filePath ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBSoundEvent"]["CreateEventFromExternalFile"]
        .DynamicInvoke(new object[] {  programmerSoundEventName ,  filePath ,  scene  } );
    }

    public static Int32 CreateEventFromSoundBuffer( Byte[] programmerSoundEventName ,  ManagedArray soundBuffer ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBSoundEvent"]["CreateEventFromSoundBuffer"]
        .DynamicInvoke(new object[] {  programmerSoundEventName ,  soundBuffer ,  scene  } );
    }

    public static Boolean PlaySound( Int32 fmodEventIndex ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBSoundEvent"]["PlaySound"]
        .DynamicInvoke(new object[] {  fmodEventIndex ,  position  } );
    }

    public static Boolean PlaySoundWithIntParam( Int32 fmodEventIndex ,  Int32 paramIndex ,  Single paramVal ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBSoundEvent"]["PlaySoundWithIntParam"]
        .DynamicInvoke(new object[] {  fmodEventIndex ,  paramIndex ,  paramVal ,  position  } );
    }

    public static Boolean PlaySoundWithStrParam( Int32 fmodEventIndex ,  Byte[] paramName ,  Single paramVal ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBSoundEvent"]["PlaySoundWithStrParam"]
        .DynamicInvoke(new object[] {  fmodEventIndex ,  paramName ,  paramVal ,  position  } );
    }

    public static Boolean PlaySoundWithParam( Int32 soundCodeId ,  SoundEventParameter parameter ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBSoundEvent"]["PlaySoundWithParam"]
        .DynamicInvoke(new object[] {  soundCodeId ,  parameter ,  position  } );
    }

    }
}