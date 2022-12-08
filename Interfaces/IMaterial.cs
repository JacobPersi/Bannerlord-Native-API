
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
    public static class IMaterial {
    
    public static NativeObjectPointer CreateCopy( UIntPtr materialPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["CreateCopy"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static NativeObjectPointer GetFromResource( Byte[] materialName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["GetFromResource"]
        .DynamicInvoke(new object[] {  materialName  } );
    }

    public static NativeObjectPointer GetDefaultMaterial() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["GetDefaultMaterial"]
        .DynamicInvoke(new object[] {  } );
    }

    public static NativeObjectPointer GetOutlineMaterial( UIntPtr materialPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["GetOutlineMaterial"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static Int32 GetName( UIntPtr materialPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMaterial"]["GetName"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static void SetName( UIntPtr materialPointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["IMaterial"]["SetName"]
        .DynamicInvoke(new object[] {  materialPointer ,  name  } );
    }

    public static Int32 GetAlphaBlendMode( UIntPtr materialPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMaterial"]["GetAlphaBlendMode"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static void SetAlphaBlendMode( UIntPtr materialPointer ,  Int32 alphaBlendMode ) {
          NativeManager.OutboundManifest["IMaterial"]["SetAlphaBlendMode"]
        .DynamicInvoke(new object[] {  materialPointer ,  alphaBlendMode  } );
    }

    public static void Release( UIntPtr materialPointer ) {
          NativeManager.OutboundManifest["IMaterial"]["Release"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static void SetShader( UIntPtr materialPointer ,  UIntPtr shaderPointer ) {
          NativeManager.OutboundManifest["IMaterial"]["SetShader"]
        .DynamicInvoke(new object[] {  materialPointer ,  shaderPointer  } );
    }

    public static NativeObjectPointer GetShader( UIntPtr materialPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["GetShader"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static UInt64 GetShaderFlags( UIntPtr materialPointer ) {
         return   (UInt64)  NativeManager.OutboundManifest["IMaterial"]["GetShaderFlags"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static void SetShaderFlags( UIntPtr materialPointer ,  UInt64 shaderFlags ) {
          NativeManager.OutboundManifest["IMaterial"]["SetShaderFlags"]
        .DynamicInvoke(new object[] {  materialPointer ,  shaderFlags  } );
    }

    public static void SetMeshVectorArgument( UIntPtr materialPointer ,  Single x ,  Single y ,  Single z ,  Single w ) {
          NativeManager.OutboundManifest["IMaterial"]["SetMeshVectorArgument"]
        .DynamicInvoke(new object[] {  materialPointer ,  x ,  y ,  z ,  w  } );
    }

    public static void SetTexture( UIntPtr materialPointer ,  Int32 textureType ,  UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["IMaterial"]["SetTexture"]
        .DynamicInvoke(new object[] {  materialPointer ,  textureType ,  texturePointer  } );
    }

    public static void SetTextureAtSlot( UIntPtr materialPointer ,  Int32 textureSlotIndex ,  UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["IMaterial"]["SetTextureAtSlot"]
        .DynamicInvoke(new object[] {  materialPointer ,  textureSlotIndex ,  texturePointer  } );
    }

    public static NativeObjectPointer GetTexture( UIntPtr materialPointer ,  Int32 textureType ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMaterial"]["GetTexture"]
        .DynamicInvoke(new object[] {  materialPointer ,  textureType  } );
    }

    public static void SetAlphaTestValue( UIntPtr materialPointer ,  Single alphaTestValue ) {
          NativeManager.OutboundManifest["IMaterial"]["SetAlphaTestValue"]
        .DynamicInvoke(new object[] {  materialPointer ,  alphaTestValue  } );
    }

    public static Single GetAlphaTestValue( UIntPtr materialPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMaterial"]["GetAlphaTestValue"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static UInt32 GetFlags( UIntPtr materialPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMaterial"]["GetFlags"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    public static void SetFlags( UIntPtr materialPointer ,  UInt32 flags ) {
          NativeManager.OutboundManifest["IMaterial"]["SetFlags"]
        .DynamicInvoke(new object[] {  materialPointer ,  flags  } );
    }

    public static void AddMaterialShaderFlag( UIntPtr materialPointer ,  Byte[] flagName ,  Boolean showErrors ) {
          NativeManager.OutboundManifest["IMaterial"]["AddMaterialShaderFlag"]
        .DynamicInvoke(new object[] {  materialPointer ,  flagName ,  showErrors  } );
    }

    public static void SetAreaMapScale( UIntPtr materialPointer ,  Single scale ) {
          NativeManager.OutboundManifest["IMaterial"]["SetAreaMapScale"]
        .DynamicInvoke(new object[] {  materialPointer ,  scale  } );
    }

    public static void SetEnableSkinning( UIntPtr materialPointer ,  Boolean enable ) {
          NativeManager.OutboundManifest["IMaterial"]["SetEnableSkinning"]
        .DynamicInvoke(new object[] {  materialPointer ,  enable  } );
    }

    public static Boolean UsingSkinning( UIntPtr materialPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMaterial"]["UsingSkinning"]
        .DynamicInvoke(new object[] {  materialPointer  } );
    }

    }
}