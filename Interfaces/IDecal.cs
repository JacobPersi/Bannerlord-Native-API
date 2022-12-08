
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
    public static class IDecal {
    
    public static NativeObjectPointer GetMaterial( UIntPtr decalPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IDecal"]["GetMaterial"]
        .DynamicInvoke(new object[] {  decalPointer  } );
    }

    public static void SetMaterial( UIntPtr decalPointer ,  UIntPtr materialPointer ) {
          NativeManager.OutboundManifest["IDecal"]["SetMaterial"]
        .DynamicInvoke(new object[] {  decalPointer ,  materialPointer  } );
    }

    public static NativeObjectPointer CreateDecal( Byte[] name ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IDecal"]["CreateDecal"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static UInt32 GetFactor1( UIntPtr decalPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IDecal"]["GetFactor1"]
        .DynamicInvoke(new object[] {  decalPointer  } );
    }

    public static void SetFactor1Linear( UIntPtr decalPointer ,  UInt32 linearFactorColor1 ) {
          NativeManager.OutboundManifest["IDecal"]["SetFactor1Linear"]
        .DynamicInvoke(new object[] {  decalPointer ,  linearFactorColor1  } );
    }

    public static void SetFactor1( UIntPtr decalPointer ,  UInt32 factorColor1 ) {
          NativeManager.OutboundManifest["IDecal"]["SetFactor1"]
        .DynamicInvoke(new object[] {  decalPointer ,  factorColor1  } );
    }

    public static void SetVectorArgument( UIntPtr decalPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IDecal"]["SetVectorArgument"]
        .DynamicInvoke(new object[] {  decalPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void SetVectorArgument2( UIntPtr decalPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IDecal"]["SetVectorArgument2"]
        .DynamicInvoke(new object[] {  decalPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void GetFrame( UIntPtr decalPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IDecal"]["GetFrame"]
        .DynamicInvoke(new object[] {  decalPointer ,  outFrame  } );
    }

    public static void SetFrame( UIntPtr decalPointer ,   ref MatrixFrame decalFrame ) {
          NativeManager.OutboundManifest["IDecal"]["SetFrame"]
        .DynamicInvoke(new object[] {  decalPointer ,  decalFrame  } );
    }

    public static NativeObjectPointer CreateCopy( UIntPtr pointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IDecal"]["CreateCopy"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    }
}