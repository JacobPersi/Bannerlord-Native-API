
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
    public static class IPhysicsShape {
    
    public static NativeObjectPointer GetFromResource( Byte[] bodyName ,  Boolean mayReturnNull ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IPhysicsShape"]["GetFromResource"]
        .DynamicInvoke(new object[] {  bodyName ,  mayReturnNull  } );
    }

    public static void AddPreloadQueueWithName( Byte[] bodyName ,   ref Vec3 scale ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["AddPreloadQueueWithName"]
        .DynamicInvoke(new object[] {  bodyName ,  scale  } );
    }

    public static void ProcessPreloadQueue() {
          NativeManager.OutboundManifest["IPhysicsShape"]["ProcessPreloadQueue"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void UnloadDynamicBodies() {
          NativeManager.OutboundManifest["IPhysicsShape"]["UnloadDynamicBodies"]
        .DynamicInvoke(new object[] {  } );
    }

    public static NativeObjectPointer CreateBodyCopy( UIntPtr bodyPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IPhysicsShape"]["CreateBodyCopy"]
        .DynamicInvoke(new object[] {  bodyPointer  } );
    }

    public static Int32 GetName( UIntPtr shape ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["GetName"]
        .DynamicInvoke(new object[] {  shape  } );
    }

    public static Int32 TriangleMeshCount( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["TriangleMeshCount"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static Int32 TriangleCountInTriangleMesh( UIntPtr pointer ,  Int32 meshIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["TriangleCountInTriangleMesh"]
        .DynamicInvoke(new object[] {  pointer ,  meshIndex  } );
    }

    public static Int32 GetDominantMaterialForTriangleMesh( UIntPtr shape ,  Int32 meshIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["GetDominantMaterialForTriangleMesh"]
        .DynamicInvoke(new object[] {  shape ,  meshIndex  } );
    }

    public static void GetTriangle( UIntPtr pointer ,  IntPtr data ,  Int32 meshIndex ,  Int32 triangleIndex ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["GetTriangle"]
        .DynamicInvoke(new object[] {  pointer ,  data ,  meshIndex ,  triangleIndex  } );
    }

    public static Int32 SphereCount( UIntPtr pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["SphereCount"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void GetSphere( UIntPtr shapePointer ,   ref SphereData data ,  Int32 sphereIndex ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["GetSphere"]
        .DynamicInvoke(new object[] {  shapePointer ,  data ,  sphereIndex  } );
    }

    public static void GetSphereWithMaterial( UIntPtr shapePointer ,   ref SphereData data ,   ref Int32 materialIndex ,  Int32 sphereIndex ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["GetSphereWithMaterial"]
        .DynamicInvoke(new object[] {  shapePointer ,  data ,  materialIndex ,  sphereIndex  } );
    }

    public static void Prepare( UIntPtr shapePointer ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["Prepare"]
        .DynamicInvoke(new object[] {  shapePointer  } );
    }

    public static Int32 CapsuleCount( UIntPtr shapePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsShape"]["CapsuleCount"]
        .DynamicInvoke(new object[] {  shapePointer  } );
    }

    public static void AddCapsule( UIntPtr shapePointer ,   ref CapsuleData data ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["AddCapsule"]
        .DynamicInvoke(new object[] {  shapePointer ,  data  } );
    }

    public static void InitDescription( UIntPtr shapePointer ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["InitDescription"]
        .DynamicInvoke(new object[] {  shapePointer  } );
    }

    public static void AddSphere( UIntPtr shapePointer ,   ref Vec3 origin ,  Single radius ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["AddSphere"]
        .DynamicInvoke(new object[] {  shapePointer ,  origin ,  radius  } );
    }

    public static void SetCapsule( UIntPtr shapePointer ,   ref CapsuleData data ,  Int32 index ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["SetCapsule"]
        .DynamicInvoke(new object[] {  shapePointer ,  data ,  index  } );
    }

    public static void GetCapsule( UIntPtr shapePointer ,   ref CapsuleData data ,  Int32 index ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["GetCapsule"]
        .DynamicInvoke(new object[] {  shapePointer ,  data ,  index  } );
    }

    public static void GetCapsuleWithMaterial( UIntPtr shapePointer ,   ref CapsuleData data ,   ref Int32 materialIndex ,  Int32 index ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["GetCapsuleWithMaterial"]
        .DynamicInvoke(new object[] {  shapePointer ,  data ,  materialIndex ,  index  } );
    }

    public static void clear( UIntPtr shapePointer ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["clear"]
        .DynamicInvoke(new object[] {  shapePointer  } );
    }

    public static void Transform( UIntPtr shapePointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IPhysicsShape"]["Transform"]
        .DynamicInvoke(new object[] {  shapePointer ,  frame  } );
    }

    public static Vec3 GetBoundingBoxCenter( UIntPtr shapePointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IPhysicsShape"]["GetBoundingBoxCenter"]
        .DynamicInvoke(new object[] {  shapePointer  } );
    }

    }
}