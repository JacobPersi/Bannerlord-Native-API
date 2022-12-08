
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
    public static class IMBTeam {
    
    public static Boolean IsEnemy( UIntPtr missionPointer ,  Int32 teamIndex ,  Int32 otherTeamIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBTeam"]["IsEnemy"]
        .DynamicInvoke(new object[] {  missionPointer ,  teamIndex ,  otherTeamIndex  } );
    }

    public static void SetIsEnemy( UIntPtr missionPointer ,  Int32 teamIndex ,  Int32 otherTeamIndex ,  Boolean isEnemy ) {
          NativeManager.OutboundManifest["IMBTeam"]["SetIsEnemy"]
        .DynamicInvoke(new object[] {  missionPointer ,  teamIndex ,  otherTeamIndex ,  isEnemy  } );
    }

    }
}