
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
    public static class IPath {
    
    public static Int32 GetNumberOfPoints( UIntPtr ptr ) {
         return   (Int32)  NativeManager.OutboundManifest["IPath"]["GetNumberOfPoints"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void GetHermiteFrameForDt( UIntPtr ptr ,   ref MatrixFrame frame ,  Single phase ,  Int32 firstPoint ) {
          NativeManager.OutboundManifest["IPath"]["GetHermiteFrameForDt"]
        .DynamicInvoke(new object[] {  ptr ,  frame ,  phase ,  firstPoint  } );
    }

    public static void GetHermiteFrameForDistance( UIntPtr ptr ,   ref MatrixFrame frame ,  Single distance ) {
          NativeManager.OutboundManifest["IPath"]["GetHermiteFrameForDistance"]
        .DynamicInvoke(new object[] {  ptr ,  frame ,  distance  } );
    }

    public static void GetNearestHermiteFrameWithValidAlphaForDistance( UIntPtr ptr ,   ref MatrixFrame frame ,  Single distance ,  Boolean searchForward ,  Single alphaThreshold ) {
          NativeManager.OutboundManifest["IPath"]["GetNearestHermiteFrameWithValidAlphaForDistance"]
        .DynamicInvoke(new object[] {  ptr ,  frame ,  distance ,  searchForward ,  alphaThreshold  } );
    }

    public static void GetHermiteFrameAndColorForDistance( UIntPtr ptr ,   ref MatrixFrame frame ,   ref Vec3 color ,  Single distance ) {
          NativeManager.OutboundManifest["IPath"]["GetHermiteFrameAndColorForDistance"]
        .DynamicInvoke(new object[] {  ptr ,  frame ,  color ,  distance  } );
    }

    public static Single GetArcLength( UIntPtr ptr ,  Int32 firstPoint ) {
         return   (Single)  NativeManager.OutboundManifest["IPath"]["GetArcLength"]
        .DynamicInvoke(new object[] {  ptr ,  firstPoint  } );
    }

    public static void GetPoints( UIntPtr ptr ,  IntPtr points ) {
          NativeManager.OutboundManifest["IPath"]["GetPoints"]
        .DynamicInvoke(new object[] {  ptr ,  points  } );
    }

    public static Single GetTotalLength( UIntPtr ptr ) {
         return   (Single)  NativeManager.OutboundManifest["IPath"]["GetTotalLength"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static Int32 GetVersion( UIntPtr ptr ) {
         return   (Int32)  NativeManager.OutboundManifest["IPath"]["GetVersion"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void SetFrameOfPoint( UIntPtr ptr ,  Int32 pointIndex ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IPath"]["SetFrameOfPoint"]
        .DynamicInvoke(new object[] {  ptr ,  pointIndex ,  frame  } );
    }

    public static void SetTangentPositionOfPoint( UIntPtr ptr ,  Int32 pointIndex ,  Int32 tangentIndex ,   ref Vec3 position ) {
          NativeManager.OutboundManifest["IPath"]["SetTangentPositionOfPoint"]
        .DynamicInvoke(new object[] {  ptr ,  pointIndex ,  tangentIndex ,  position  } );
    }

    public static Int32 AddPathPoint( UIntPtr ptr ,  Int32 newNodeIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IPath"]["AddPathPoint"]
        .DynamicInvoke(new object[] {  ptr ,  newNodeIndex  } );
    }

    public static void DeletePathPoint( UIntPtr ptr ,  Int32 newNodeIndex ) {
          NativeManager.OutboundManifest["IPath"]["DeletePathPoint"]
        .DynamicInvoke(new object[] {  ptr ,  newNodeIndex  } );
    }

    public static Boolean HasValidAlphaAtPathPoint( UIntPtr ptr ,  Int32 nodeIndex ,  Single alphaThreshold ) {
         return   (Boolean)  NativeManager.OutboundManifest["IPath"]["HasValidAlphaAtPathPoint"]
        .DynamicInvoke(new object[] {  ptr ,  nodeIndex ,  alphaThreshold  } );
    }

    public static Int32 GetName( UIntPtr ptr ) {
         return   (Int32)  NativeManager.OutboundManifest["IPath"]["GetName"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    }
}