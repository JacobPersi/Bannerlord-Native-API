
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
    public static class ILight {
    
    public static NativeObjectPointer CreatePointLight( Single lightRadius ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ILight"]["CreatePointLight"]
        .DynamicInvoke(new object[] {  lightRadius  } );
    }

    public static void SetRadius( UIntPtr lightpointer ,  Single radius ) {
          NativeManager.OutboundManifest["ILight"]["SetRadius"]
        .DynamicInvoke(new object[] {  lightpointer ,  radius  } );
    }

    public static void SetLightFlicker( UIntPtr lightpointer ,  Single magnitude ,  Single interval ) {
          NativeManager.OutboundManifest["ILight"]["SetLightFlicker"]
        .DynamicInvoke(new object[] {  lightpointer ,  magnitude ,  interval  } );
    }

    public static void EnableShadow( UIntPtr lightpointer ,  Boolean shadowEnabled ) {
          NativeManager.OutboundManifest["ILight"]["EnableShadow"]
        .DynamicInvoke(new object[] {  lightpointer ,  shadowEnabled  } );
    }

    public static Boolean IsShadowEnabled( UIntPtr lightpointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ILight"]["IsShadowEnabled"]
        .DynamicInvoke(new object[] {  lightpointer  } );
    }

    public static void SetVolumetricProperties( UIntPtr lightpointer ,  Boolean volumelightenabled ,  Single volumeparameter ) {
          NativeManager.OutboundManifest["ILight"]["SetVolumetricProperties"]
        .DynamicInvoke(new object[] {  lightpointer ,  volumelightenabled ,  volumeparameter  } );
    }

    public static void SetVisibility( UIntPtr lightpointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ILight"]["SetVisibility"]
        .DynamicInvoke(new object[] {  lightpointer ,  value  } );
    }

    public static Single GetRadius( UIntPtr lightpointer ) {
         return   (Single)  NativeManager.OutboundManifest["ILight"]["GetRadius"]
        .DynamicInvoke(new object[] {  lightpointer  } );
    }

    public static void SetShadows( UIntPtr lightPointer ,  Int32 shadowType ) {
          NativeManager.OutboundManifest["ILight"]["SetShadows"]
        .DynamicInvoke(new object[] {  lightPointer ,  shadowType  } );
    }

    public static void SetLightColor( UIntPtr lightpointer ,  Vec3 color ) {
          NativeManager.OutboundManifest["ILight"]["SetLightColor"]
        .DynamicInvoke(new object[] {  lightpointer ,  color  } );
    }

    public static Vec3 GetLightColor( UIntPtr lightpointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["ILight"]["GetLightColor"]
        .DynamicInvoke(new object[] {  lightpointer  } );
    }

    public static void SetIntensity( UIntPtr lightPointer ,  Single value ) {
          NativeManager.OutboundManifest["ILight"]["SetIntensity"]
        .DynamicInvoke(new object[] {  lightPointer ,  value  } );
    }

    public static Single GetIntensity( UIntPtr lightPointer ) {
         return   (Single)  NativeManager.OutboundManifest["ILight"]["GetIntensity"]
        .DynamicInvoke(new object[] {  lightPointer  } );
    }

    public static void Release( UIntPtr lightpointer ) {
          NativeManager.OutboundManifest["ILight"]["Release"]
        .DynamicInvoke(new object[] {  lightpointer  } );
    }

    public static void SetFrame( UIntPtr lightPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["ILight"]["SetFrame"]
        .DynamicInvoke(new object[] {  lightPointer ,  frame  } );
    }

    public static void GetFrame( UIntPtr lightPointer ,   ref MatrixFrame result ) {
          NativeManager.OutboundManifest["ILight"]["GetFrame"]
        .DynamicInvoke(new object[] {  lightPointer ,  result  } );
    }

    }
}