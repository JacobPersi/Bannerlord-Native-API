
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
    public static class IShader {
    
    public static NativeObjectPointer GetFromResource( Byte[] shaderName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IShader"]["GetFromResource"]
        .DynamicInvoke(new object[] {  shaderName  } );
    }

    public static Int32 GetName( UIntPtr shaderPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IShader"]["GetName"]
        .DynamicInvoke(new object[] {  shaderPointer  } );
    }

    public static void Release( UIntPtr shaderPointer ) {
          NativeManager.OutboundManifest["IShader"]["Release"]
        .DynamicInvoke(new object[] {  shaderPointer  } );
    }

    public static UInt64 GetMaterialShaderFlagMask( UIntPtr shaderPointer ,  Byte[] flagName ,  Boolean showError ) {
         return   (UInt64)  NativeManager.OutboundManifest["IShader"]["GetMaterialShaderFlagMask"]
        .DynamicInvoke(new object[] {  shaderPointer ,  flagName ,  showError  } );
    }

    }
}