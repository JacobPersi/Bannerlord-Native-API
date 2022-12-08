
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
    public static class ISoundEvent {
    
    public static Int32 CreateEventFromString( Byte[] eventName ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["CreateEventFromString"]
        .DynamicInvoke(new object[] {  eventName ,  scene  } );
    }

    public static Int32 GetEventIdFromString( Byte[] eventName ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["GetEventIdFromString"]
        .DynamicInvoke(new object[] {  eventName  } );
    }

    public static Boolean PlaySound2D( Int32 fmodEventIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["PlaySound2D"]
        .DynamicInvoke(new object[] {  fmodEventIndex  } );
    }

    public static Int32 GetTotalEventCount() {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["GetTotalEventCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetEventMinMaxDistance( Int32 fmodEventIndex ,  Vec3 radius ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetEventMinMaxDistance"]
        .DynamicInvoke(new object[] {  fmodEventIndex ,  radius  } );
    }

    public static Int32 CreateEvent( Int32 fmodEventIndex ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["CreateEvent"]
        .DynamicInvoke(new object[] {  fmodEventIndex ,  scene  } );
    }

    public static void ReleaseEvent( Int32 eventId ) {
          NativeManager.OutboundManifest["ISoundEvent"]["ReleaseEvent"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void SetEventParameterFromString( Int32 eventId ,  Byte[] name ,  Single value ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetEventParameterFromString"]
        .DynamicInvoke(new object[] {  eventId ,  name ,  value  } );
    }

    public static Vec3 GetEventMinMaxDistance( Int32 eventId ) {
         return   (Vec3)  NativeManager.OutboundManifest["ISoundEvent"]["GetEventMinMaxDistance"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void SetEventPosition( Int32 eventId ,   ref Vec3 position ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetEventPosition"]
        .DynamicInvoke(new object[] {  eventId ,  position  } );
    }

    public static void SetEventVelocity( Int32 eventId ,   ref Vec3 velocity ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetEventVelocity"]
        .DynamicInvoke(new object[] {  eventId ,  velocity  } );
    }

    public static Boolean StartEvent( Int32 eventId ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["StartEvent"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static Boolean StartEventInPosition( Int32 eventId ,   ref Vec3 position ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["StartEventInPosition"]
        .DynamicInvoke(new object[] {  eventId ,  position  } );
    }

    public static void StopEvent( Int32 eventId ) {
          NativeManager.OutboundManifest["ISoundEvent"]["StopEvent"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void PauseEvent( Int32 eventId ) {
          NativeManager.OutboundManifest["ISoundEvent"]["PauseEvent"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void ResumeEvent( Int32 eventId ) {
          NativeManager.OutboundManifest["ISoundEvent"]["ResumeEvent"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void PlayExtraEvent( Int32 soundId ,  Byte[] eventName ) {
          NativeManager.OutboundManifest["ISoundEvent"]["PlayExtraEvent"]
        .DynamicInvoke(new object[] {  soundId ,  eventName  } );
    }

    public static void SetSwitch( Int32 soundId ,  Byte[] switchGroupName ,  Byte[] newSwitchStateName ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetSwitch"]
        .DynamicInvoke(new object[] {  soundId ,  switchGroupName ,  newSwitchStateName  } );
    }

    public static void TriggerCue( Int32 eventId ) {
          NativeManager.OutboundManifest["ISoundEvent"]["TriggerCue"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static void SetEventParameterAtIndex( Int32 soundId ,  Int32 parameterIndex ,  Single value ) {
          NativeManager.OutboundManifest["ISoundEvent"]["SetEventParameterAtIndex"]
        .DynamicInvoke(new object[] {  soundId ,  parameterIndex ,  value  } );
    }

    public static Boolean IsPlaying( Int32 eventId ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["IsPlaying"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static Boolean IsPaused( Int32 eventId ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["IsPaused"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static Boolean IsValid( Int32 eventId ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISoundEvent"]["IsValid"]
        .DynamicInvoke(new object[] {  eventId  } );
    }

    public static Int32 CreateEventFromExternalFile( Byte[] programmerSoundEventName ,  Byte[] filePath ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["CreateEventFromExternalFile"]
        .DynamicInvoke(new object[] {  programmerSoundEventName ,  filePath ,  scene  } );
    }

    public static Int32 CreateEventFromSoundBuffer( Byte[] programmerSoundEventName ,  ManagedArray soundBuffer ,  UIntPtr scene ) {
         return   (Int32)  NativeManager.OutboundManifest["ISoundEvent"]["CreateEventFromSoundBuffer"]
        .DynamicInvoke(new object[] {  programmerSoundEventName ,  soundBuffer ,  scene  } );
    }

    }
}