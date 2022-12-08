
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
    public static class IMBDebugExtensions {
    
    public static void RenderDebugCircleOnTerrain( UIntPtr scenePointer ,   ref MatrixFrame frame ,  Single radius ,  UInt32 color ,  Boolean depthCheck ,  Boolean isDotted ) {
          NativeManager.OutboundManifest["IMBDebugExtensions"]["RenderDebugCircleOnTerrain"]
        .DynamicInvoke(new object[] {  scenePointer ,  frame ,  radius ,  color ,  depthCheck ,  isDotted  } );
    }

    public static void RenderDebugArcOnTerrain( UIntPtr scenePointer ,   ref MatrixFrame frame ,  Single radius ,  Single beginAngle ,  Single endAngle ,  UInt32 color ,  Boolean depthCheck ,  Boolean isDotted ) {
          NativeManager.OutboundManifest["IMBDebugExtensions"]["RenderDebugArcOnTerrain"]
        .DynamicInvoke(new object[] {  scenePointer ,  frame ,  radius ,  beginAngle ,  endAngle ,  color ,  depthCheck ,  isDotted  } );
    }

    public static void RenderDebugLineOnTerrain( UIntPtr scenePointer ,  Vec3 position ,  Vec3 direction ,  UInt32 color ,  Boolean depthCheck ,  Single time ,  Boolean isDotted ,  Single pointDensity ) {
          NativeManager.OutboundManifest["IMBDebugExtensions"]["RenderDebugLineOnTerrain"]
        .DynamicInvoke(new object[] {  scenePointer ,  position ,  direction ,  color ,  depthCheck ,  time ,  isDotted ,  pointDensity  } );
    }

    public static void OverrideNativeParameter( Byte[] paramName ,  Single value ) {
          NativeManager.OutboundManifest["IMBDebugExtensions"]["OverrideNativeParameter"]
        .DynamicInvoke(new object[] {  paramName ,  value  } );
    }

    public static void ReloadNativeParameters() {
          NativeManager.OutboundManifest["IMBDebugExtensions"]["ReloadNativeParameters"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}