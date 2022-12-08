
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
    public static class IScriptComponent {
    
    public static Int32 GetScriptComponentBehavior( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IScriptComponent"]["GetScriptComponentBehavior"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void SetVariableEditorWidgetStatus( UIntPtr pointer ,  Byte[] field ,  Boolean enabled ) {
          NativeManager.OutboundManifest["IScriptComponent"]["SetVariableEditorWidgetStatus"]
        .DynamicInvoke(new object[] {  pointer ,  field ,  enabled  } );
    }

    }
}