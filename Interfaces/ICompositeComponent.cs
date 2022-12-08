
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
    public static class ICompositeComponent {
    
    public static NativeObjectPointer CreateCompositeComponent() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ICompositeComponent"]["CreateCompositeComponent"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetMaterial( UIntPtr compositeComponentPointer ,  UIntPtr materialPointer ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetMaterial"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  materialPointer  } );
    }

    public static NativeObjectPointer CreateCopy( UIntPtr pointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ICompositeComponent"]["CreateCopy"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void AddComponent( UIntPtr pointer ,  UIntPtr componentPointer ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["AddComponent"]
        .DynamicInvoke(new object[] {  pointer ,  componentPointer  } );
    }

    public static void AddPrefabEntity( UIntPtr pointer ,  UIntPtr scenePointer ,  Byte[] prefabName ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["AddPrefabEntity"]
        .DynamicInvoke(new object[] {  pointer ,  scenePointer ,  prefabName  } );
    }

    public static void Release( UIntPtr compositeComponentPointer ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["Release"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static UInt32 GetFactor1( UIntPtr compositeComponentPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["ICompositeComponent"]["GetFactor1"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static UInt32 GetFactor2( UIntPtr compositeComponentPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["ICompositeComponent"]["GetFactor2"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static void SetFactor1( UIntPtr compositeComponentPointer ,  UInt32 factorColor1 ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetFactor1"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  factorColor1  } );
    }

    public static void SetFactor2( UIntPtr compositeComponentPointer ,  UInt32 factorColor2 ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetFactor2"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  factorColor2  } );
    }

    public static void SetVectorArgument( UIntPtr compositeComponentPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetVectorArgument"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void GetFrame( UIntPtr compositeComponentPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["GetFrame"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  outFrame  } );
    }

    public static void SetFrame( UIntPtr compositeComponentPointer ,   ref MatrixFrame meshFrame ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetFrame"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  meshFrame  } );
    }

    public static Vec3 GetVectorUserData( UIntPtr compositeComponentPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["ICompositeComponent"]["GetVectorUserData"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static void SetVectorUserData( UIntPtr compositeComponentPointer ,   ref Vec3 vectorArg ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetVectorUserData"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  vectorArg  } );
    }

    public static void GetBoundingBox( UIntPtr compositeComponentPointer ,   ref BoundingBox outBoundingBox ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["GetBoundingBox"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  outBoundingBox  } );
    }

    public static void SetVisibilityMask( UIntPtr compositeComponentPointer ,  VisibilityMaskFlags visibilityMask ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetVisibilityMask"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  visibilityMask  } );
    }

    public static NativeObjectPointer GetFirstMetaMesh( UIntPtr compositeComponentPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ICompositeComponent"]["GetFirstMetaMesh"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static void AddMultiMesh( UIntPtr compositeComponentPointer ,  Byte[] multiMeshName ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["AddMultiMesh"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  multiMeshName  } );
    }

    public static Boolean IsVisible( UIntPtr compositeComponentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ICompositeComponent"]["IsVisible"]
        .DynamicInvoke(new object[] {  compositeComponentPointer  } );
    }

    public static void SetVisible( UIntPtr compositeComponentPointer ,  Boolean visible ) {
          NativeManager.OutboundManifest["ICompositeComponent"]["SetVisible"]
        .DynamicInvoke(new object[] {  compositeComponentPointer ,  visible  } );
    }

    }
}