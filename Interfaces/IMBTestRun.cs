
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
    public static class IMBTestRun {
    
    public static Int32 AutoContinue( Int32 type ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBTestRun"]["AutoContinue"]
        .DynamicInvoke(new object[] {  type  } );
    }

    public static Int32 GetFPS() {
         return   (Int32)  NativeManager.OutboundManifest["IMBTestRun"]["GetFPS"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean EnterEditMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTestRun"]["EnterEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean OpenScene( Byte[] sceneName ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTestRun"]["OpenScene"]
        .DynamicInvoke(new object[] {  sceneName  } );
    }

    public static Boolean CloseScene() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTestRun"]["CloseScene"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean LeaveEditMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTestRun"]["LeaveEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean NewScene() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTestRun"]["NewScene"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void StartMission() {
          NativeManager.OutboundManifest["IMBTestRun"]["StartMission"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}