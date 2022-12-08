
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
    public static class IBodyPart {
    
    public static Boolean DoSegmentsIntersect( Vec2 line1Start ,  Vec2 line1Direction ,  Vec2 line2Start ,  Vec2 line2Direction ,   ref Vec2 intersectionPoint ) {
         return   (Boolean)  NativeManager.OutboundManifest["IBodyPart"]["DoSegmentsIntersect"]
        .DynamicInvoke(new object[] {  line1Start ,  line1Direction ,  line2Start ,  line2Direction ,  intersectionPoint  } );
    }

    }
}