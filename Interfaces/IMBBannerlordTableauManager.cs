
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
    public static class IMBBannerlordTableauManager {
    
    public static void RequestCharacterTableauRender( Int32 characterCodeId ,  Byte[] path ,  UIntPtr poseEntity ,  UIntPtr cameraObject ,  Int32 tableauType ) {
          NativeManager.OutboundManifest["IMBBannerlordTableauManager"]["RequestCharacterTableauRender"]
        .DynamicInvoke(new object[] {  characterCodeId ,  path ,  poseEntity ,  cameraObject ,  tableauType  } );
    }

    public static void InitializeCharacterTableauRenderSystem() {
          NativeManager.OutboundManifest["IMBBannerlordTableauManager"]["InitializeCharacterTableauRenderSystem"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetNumberOfPendingTableauRequests() {
         return   (Int32)  NativeManager.OutboundManifest["IMBBannerlordTableauManager"]["GetNumberOfPendingTableauRequests"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}