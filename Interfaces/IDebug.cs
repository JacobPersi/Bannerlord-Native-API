
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
    public static class IDebug {
    
    public static void WriteDebugLineOnScreen( Byte[] line ) {
          NativeManager.OutboundManifest["IDebug"]["WriteDebugLineOnScreen"]
        .DynamicInvoke(new object[] {  line  } );
    }

    public static void AbortGame( Int32 ExitCode ) {
          NativeManager.OutboundManifest["IDebug"]["AbortGame"]
        .DynamicInvoke(new object[] {  ExitCode  } );
    }

    public static void AssertMemoryUsage( Int32 memoryMB ) {
          NativeManager.OutboundManifest["IDebug"]["AssertMemoryUsage"]
        .DynamicInvoke(new object[] {  memoryMB  } );
    }

    public static void WriteLine( Int32 logLevel ,  Byte[] line ,  Int32 color ,  UInt64 filter ) {
          NativeManager.OutboundManifest["IDebug"]["WriteLine"]
        .DynamicInvoke(new object[] {  logLevel ,  line ,  color ,  filter  } );
    }

    public static void RenderDebugDirectionArrow( Vec3 position ,  Vec3 direction ,  UInt32 color ,  Boolean depthCheck ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugDirectionArrow"]
        .DynamicInvoke(new object[] {  position ,  direction ,  color ,  depthCheck  } );
    }

    public static void RenderDebugLine( Vec3 position ,  Vec3 direction ,  UInt32 color ,  Boolean depthCheck ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugLine"]
        .DynamicInvoke(new object[] {  position ,  direction ,  color ,  depthCheck ,  time  } );
    }

    public static void RenderDebugSphere( Vec3 position ,  Single radius ,  UInt32 color ,  Boolean depthCheck ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugSphere"]
        .DynamicInvoke(new object[] {  position ,  radius ,  color ,  depthCheck ,  time  } );
    }

    public static void RenderDebugCapsule( Vec3 p0 ,  Vec3 p1 ,  Single radius ,  UInt32 color ,  Boolean depthCheck ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugCapsule"]
        .DynamicInvoke(new object[] {  p0 ,  p1 ,  radius ,  color ,  depthCheck ,  time  } );
    }

    public static void RenderDebugFrame(  ref MatrixFrame frame ,  Single lineLength ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugFrame"]
        .DynamicInvoke(new object[] {  frame ,  lineLength ,  time  } );
    }

    public static void RenderDebugText3d( Vec3 worldPosition ,  Byte[] str ,  UInt32 color ,  Int32 screenPosOffsetX ,  Int32 screenPosOffsetY ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugText3d"]
        .DynamicInvoke(new object[] {  worldPosition ,  str ,  color ,  screenPosOffsetX ,  screenPosOffsetY ,  time  } );
    }

    public static void RenderDebugText( Single screenX ,  Single screenY ,  Byte[] str ,  UInt32 color ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugText"]
        .DynamicInvoke(new object[] {  screenX ,  screenY ,  str ,  color ,  time  } );
    }

    public static void RenderDebugRect( Single left ,  Single bottom ,  Single right ,  Single top ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugRect"]
        .DynamicInvoke(new object[] {  left ,  bottom ,  right ,  top  } );
    }

    public static void RenderDebugRectWithColor( Single left ,  Single bottom ,  Single right ,  Single top ,  UInt32 color ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugRectWithColor"]
        .DynamicInvoke(new object[] {  left ,  bottom ,  right ,  top ,  color  } );
    }

    public static void ClearAllDebugRenderObjects() {
          NativeManager.OutboundManifest["IDebug"]["ClearAllDebugRenderObjects"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Vec3 GetDebugVector() {
         return   (Vec3)  NativeManager.OutboundManifest["IDebug"]["GetDebugVector"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void RenderDebugBoxObject( Vec3 min ,  Vec3 max ,  UInt32 color ,  Boolean depthCheck ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugBoxObject"]
        .DynamicInvoke(new object[] {  min ,  max ,  color ,  depthCheck ,  time  } );
    }

    public static void RenderDebugBoxObjectWithFrame( Vec3 min ,  Vec3 max ,   ref MatrixFrame frame ,  UInt32 color ,  Boolean depthCheck ,  Single time ) {
          NativeManager.OutboundManifest["IDebug"]["RenderDebugBoxObjectWithFrame"]
        .DynamicInvoke(new object[] {  min ,  max ,  frame ,  color ,  depthCheck ,  time  } );
    }

    public static void PostWarningLine( Byte[] line ) {
          NativeManager.OutboundManifest["IDebug"]["PostWarningLine"]
        .DynamicInvoke(new object[] {  line  } );
    }

    public static Boolean IsErrorReportModeActive() {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["IsErrorReportModeActive"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsErrorReportModePauseMission() {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["IsErrorReportModePauseMission"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetErrorReportScene( UIntPtr scenePointer ) {
          NativeManager.OutboundManifest["IDebug"]["SetErrorReportScene"]
        .DynamicInvoke(new object[] {  scenePointer  } );
    }

    public static void SetDumpGenerationDisabled( Boolean Disabled ) {
          NativeManager.OutboundManifest["IDebug"]["SetDumpGenerationDisabled"]
        .DynamicInvoke(new object[] {  Disabled  } );
    }

    public static Int32 MessageBox( Byte[] lpText ,  Byte[] lpCaption ,  UInt32 uType ) {
         return   (Int32)  NativeManager.OutboundManifest["IDebug"]["MessageBox"]
        .DynamicInvoke(new object[] {  lpText ,  lpCaption ,  uType  } );
    }

    public static Int32 GetShowDebugInfo() {
         return   (Int32)  NativeManager.OutboundManifest["IDebug"]["GetShowDebugInfo"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetShowDebugInfo( Int32 value ) {
          NativeManager.OutboundManifest["IDebug"]["SetShowDebugInfo"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Boolean Error( Byte[] MessageString ) {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["Error"]
        .DynamicInvoke(new object[] {  MessageString  } );
    }

    public static Boolean Warning( Byte[] MessageString ) {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["Warning"]
        .DynamicInvoke(new object[] {  MessageString  } );
    }

    public static Boolean ContentWarning( Byte[] MessageString ) {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["ContentWarning"]
        .DynamicInvoke(new object[] {  MessageString  } );
    }

    public static Boolean FailedAssert( Byte[] messageString ,  Byte[] callerFile ,  Byte[] callerMethod ,  Int32 callerLine ) {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["FailedAssert"]
        .DynamicInvoke(new object[] {  messageString ,  callerFile ,  callerMethod ,  callerLine  } );
    }

    public static Boolean SilentAssert( Byte[] messageString ,  Byte[] callerFile ,  Byte[] callerMethod ,  Int32 callerLine ,  Boolean getDump ) {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["SilentAssert"]
        .DynamicInvoke(new object[] {  messageString ,  callerFile ,  callerMethod ,  callerLine ,  getDump  } );
    }

    public static Boolean IsTestMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IDebug"]["IsTestMode"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}