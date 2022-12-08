
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
    public static class IInput {
    
    public static void ClearKeys() {
          NativeManager.OutboundManifest["IInput"]["ClearKeys"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMouseSensitivity() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMouseSensitivity"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMouseDeltaZ() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMouseDeltaZ"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsMouseActive() {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsMouseActive"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsControllerConnected() {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsControllerConnected"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetRumbleEffect( IntPtr lowFrequencyLevels ,  IntPtr lowFrequencyDurations ,  Int32 numLowFrequencyElements ,  IntPtr highFrequencyLevels ,  IntPtr highFrequencyDurations ,  Int32 numHighFrequencyElements ) {
          NativeManager.OutboundManifest["IInput"]["SetRumbleEffect"]
        .DynamicInvoke(new object[] {  lowFrequencyLevels ,  lowFrequencyDurations ,  numLowFrequencyElements ,  highFrequencyLevels ,  highFrequencyDurations ,  numHighFrequencyElements  } );
    }

    public static void SetTriggerFeedback( Byte leftTriggerPosition ,  Byte leftTriggerStrength ,  Byte rightTriggerPosition ,  Byte rightTriggerStrength ) {
          NativeManager.OutboundManifest["IInput"]["SetTriggerFeedback"]
        .DynamicInvoke(new object[] {  leftTriggerPosition ,  leftTriggerStrength ,  rightTriggerPosition ,  rightTriggerStrength  } );
    }

    public static void SetTriggerWeaponEffect( Byte leftStartPosition ,  Byte leftEnd_position ,  Byte leftStrength ,  Byte rightStartPosition ,  Byte rightEndPosition ,  Byte rightStrength ) {
          NativeManager.OutboundManifest["IInput"]["SetTriggerWeaponEffect"]
        .DynamicInvoke(new object[] {  leftStartPosition ,  leftEnd_position ,  leftStrength ,  rightStartPosition ,  rightEndPosition ,  rightStrength  } );
    }

    public static void SetTriggerVibration( IntPtr leftTriggerAmplitudes ,  IntPtr leftTriggerFrequencies ,  IntPtr leftTriggerDurations ,  Int32 numLeftTriggerElements ,  IntPtr rightTriggerAmplitudes ,  IntPtr rightTriggerFrequencies ,  IntPtr rightTriggerDurations ,  Int32 numRightTriggerElements ) {
          NativeManager.OutboundManifest["IInput"]["SetTriggerVibration"]
        .DynamicInvoke(new object[] {  leftTriggerAmplitudes ,  leftTriggerFrequencies ,  leftTriggerDurations ,  numLeftTriggerElements ,  rightTriggerAmplitudes ,  rightTriggerFrequencies ,  rightTriggerDurations ,  numRightTriggerElements  } );
    }

    public static void SetLightbarColor( Single red ,  Single green ,  Single blue ) {
          NativeManager.OutboundManifest["IInput"]["SetLightbarColor"]
        .DynamicInvoke(new object[] {  red ,  green ,  blue  } );
    }

    public static void PressKey( InputKey key ) {
          NativeManager.OutboundManifest["IInput"]["PressKey"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static Int32 GetVirtualKeyCode( InputKey key ) {
         return   (Int32)  NativeManager.OutboundManifest["IInput"]["GetVirtualKeyCode"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static void SetClipboardText( Byte[] text ) {
          NativeManager.OutboundManifest["IInput"]["SetClipboardText"]
        .DynamicInvoke(new object[] {  text  } );
    }

    public static Int32 GetClipboardText() {
         return   (Int32)  NativeManager.OutboundManifest["IInput"]["GetClipboardText"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UpdateKeyData( ManagedArray keyData ) {
          NativeManager.OutboundManifest["IInput"]["UpdateKeyData"]
        .DynamicInvoke(new object[] {  keyData  } );
    }

    public static Single GetMouseMoveX() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMouseMoveX"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMouseMoveY() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMouseMoveY"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMousePositionX() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMousePositionX"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMousePositionY() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMousePositionY"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMouseScrollValue() {
         return   (Single)  NativeManager.OutboundManifest["IInput"]["GetMouseScrollValue"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Vec2 GetKeyState( InputKey key ) {
         return   (Vec2)  NativeManager.OutboundManifest["IInput"]["GetKeyState"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static Boolean IsKeyDown( InputKey key ) {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsKeyDown"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static Boolean IsKeyDownImmediate( InputKey key ) {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsKeyDownImmediate"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static Boolean IsKeyPressed( InputKey key ) {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsKeyPressed"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static Boolean IsKeyReleased( InputKey key ) {
         return   (Boolean)  NativeManager.OutboundManifest["IInput"]["IsKeyReleased"]
        .DynamicInvoke(new object[] {  key  } );
    }

    public static void SetCursorPosition( Int32 x ,  Int32 y ) {
          NativeManager.OutboundManifest["IInput"]["SetCursorPosition"]
        .DynamicInvoke(new object[] {  x ,  y  } );
    }

    public static void SetCursorFrictionValue( Single frictionValue ) {
          NativeManager.OutboundManifest["IInput"]["SetCursorFrictionValue"]
        .DynamicInvoke(new object[] {  frictionValue  } );
    }

    }
}