
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
    public static class IScreen {
    
    public static Single GetRealScreenResolutionWidth() {
         return   (Single)  NativeManager.OutboundManifest["IScreen"]["GetRealScreenResolutionWidth"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetRealScreenResolutionHeight() {
         return   (Single)  NativeManager.OutboundManifest["IScreen"]["GetRealScreenResolutionHeight"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetDesktopWidth() {
         return   (Single)  NativeManager.OutboundManifest["IScreen"]["GetDesktopWidth"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetDesktopHeight() {
         return   (Single)  NativeManager.OutboundManifest["IScreen"]["GetDesktopHeight"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetAspectRatio() {
         return   (Single)  NativeManager.OutboundManifest["IScreen"]["GetAspectRatio"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetMouseVisible() {
         return   (Boolean)  NativeManager.OutboundManifest["IScreen"]["GetMouseVisible"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetMouseVisible( Boolean value ) {
          NativeManager.OutboundManifest["IScreen"]["SetMouseVisible"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Vec2 GetUsableAreaPercentages() {
         return   (Vec2)  NativeManager.OutboundManifest["IScreen"]["GetUsableAreaPercentages"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsEnterButtonCross() {
         return   (Boolean)  NativeManager.OutboundManifest["IScreen"]["IsEnterButtonCross"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}