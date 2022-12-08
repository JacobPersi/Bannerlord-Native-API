
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
    public static class ITexture {
    
    public static void GetCurObject( UIntPtr texturePointer ,  Boolean blocking ) {
          NativeManager.OutboundManifest["ITexture"]["GetCurObject"]
        .DynamicInvoke(new object[] {  texturePointer ,  blocking  } );
    }

    public static NativeObjectPointer GetFromResource( Byte[] textureName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["GetFromResource"]
        .DynamicInvoke(new object[] {  textureName  } );
    }

    public static NativeObjectPointer LoadTextureFromPath( Byte[] fileName ,  Byte[] folder ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["LoadTextureFromPath"]
        .DynamicInvoke(new object[] {  fileName ,  folder  } );
    }

    public static NativeObjectPointer CheckAndGetFromResource( Byte[] textureName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CheckAndGetFromResource"]
        .DynamicInvoke(new object[] {  textureName  } );
    }

    public static Int32 GetName( UIntPtr texturePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["ITexture"]["GetName"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static void SetName( UIntPtr texturePointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["ITexture"]["SetName"]
        .DynamicInvoke(new object[] {  texturePointer ,  name  } );
    }

    public static Int32 GetWidth( UIntPtr texturePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["ITexture"]["GetWidth"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static Int32 GetHeight( UIntPtr texturePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["ITexture"]["GetHeight"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static Int32 GetMemorySize( UIntPtr texturePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["ITexture"]["GetMemorySize"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static Boolean IsRenderTarget( UIntPtr texturePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ITexture"]["IsRenderTarget"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static void ReleaseNextFrame( UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["ITexture"]["ReleaseNextFrame"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static void Release( UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["ITexture"]["Release"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static NativeObjectPointer CreateRenderTarget( Byte[] name ,  Int32 width ,  Int32 height ,  Boolean autoMipmaps ,  Boolean isTableau ,  Boolean createUninitialized ,  Boolean always_valid ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CreateRenderTarget"]
        .DynamicInvoke(new object[] {  name ,  width ,  height ,  autoMipmaps ,  isTableau ,  createUninitialized ,  always_valid  } );
    }

    public static NativeObjectPointer CreateDepthTarget( Byte[] name ,  Int32 width ,  Int32 height ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CreateDepthTarget"]
        .DynamicInvoke(new object[] {  name ,  width ,  height  } );
    }

    public static NativeObjectPointer CreateFromByteArray( ManagedArray data ,  Int32 width ,  Int32 height ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CreateFromByteArray"]
        .DynamicInvoke(new object[] {  data ,  width ,  height  } );
    }

    public static NativeObjectPointer CreateFromMemory( ManagedArray data ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CreateFromMemory"]
        .DynamicInvoke(new object[] {  data  } );
    }

    public static void SaveToFile( UIntPtr texturePointer ,  Byte[] fileName ) {
          NativeManager.OutboundManifest["ITexture"]["SaveToFile"]
        .DynamicInvoke(new object[] {  texturePointer ,  fileName  } );
    }

    public static void SaveTextureAsAlwaysValid( UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["ITexture"]["SaveTextureAsAlwaysValid"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static void ReleaseGpuMemories() {
          NativeManager.OutboundManifest["ITexture"]["ReleaseGpuMemories"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void TransformRenderTargetToResourceTexture( UIntPtr texturePointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["ITexture"]["TransformRenderTargetToResourceTexture"]
        .DynamicInvoke(new object[] {  texturePointer ,  name  } );
    }

    public static void RemoveContinousTableauTexture( UIntPtr texturePointer ) {
          NativeManager.OutboundManifest["ITexture"]["RemoveContinousTableauTexture"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static void SetTableauView( UIntPtr texturePointer ,  UIntPtr tableauView ) {
          NativeManager.OutboundManifest["ITexture"]["SetTableauView"]
        .DynamicInvoke(new object[] {  texturePointer ,  tableauView  } );
    }

    public static NativeObjectPointer CreateTextureFromPath( PlatformFilePath filePath ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["CreateTextureFromPath"]
        .DynamicInvoke(new object[] {  filePath  } );
    }

    public static Int32 GetRenderTargetComponent( UIntPtr texturePointer ) {
         return   (Int32)  NativeManager.OutboundManifest["ITexture"]["GetRenderTargetComponent"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static NativeObjectPointer GetTableauView( UIntPtr texturePointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITexture"]["GetTableauView"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    public static Boolean IsLoaded( UIntPtr texturePointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ITexture"]["IsLoaded"]
        .DynamicInvoke(new object[] {  texturePointer  } );
    }

    }
}