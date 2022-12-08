
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
    public static class ITwoDimensionView {
    
    public static NativeObjectPointer CreateTwoDimensionView() {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ITwoDimensionView"]["CreateTwoDimensionView"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void BeginFrame( UIntPtr pointer ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["BeginFrame"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void EndFrame( UIntPtr pointer ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["EndFrame"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void Clear( UIntPtr pointer ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["Clear"]
        .DynamicInvoke(new object[] {  pointer  } );
    }

    public static void AddNewMesh( UIntPtr pointer ,  IntPtr vertices ,  IntPtr uvs ,  IntPtr indices ,  Int32 vertexCount ,  Int32 indexCount ,  UIntPtr material ,   ref TwoDimensionMeshDrawData meshDrawData ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["AddNewMesh"]
        .DynamicInvoke(new object[] {  pointer ,  vertices ,  uvs ,  indices ,  vertexCount ,  indexCount ,  material ,  meshDrawData  } );
    }

    public static void AddNewQuadMesh( UIntPtr pointer ,  UIntPtr material ,   ref TwoDimensionMeshDrawData meshDrawData ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["AddNewQuadMesh"]
        .DynamicInvoke(new object[] {  pointer ,  material ,  meshDrawData  } );
    }

    public static Boolean AddCachedTextMesh( UIntPtr pointer ,  UIntPtr material ,   ref TwoDimensionTextMeshDrawData meshDrawData ) {
         return   (Boolean)  NativeManager.OutboundManifest["ITwoDimensionView"]["AddCachedTextMesh"]
        .DynamicInvoke(new object[] {  pointer ,  material ,  meshDrawData  } );
    }

    public static void AddNewTextMesh( UIntPtr pointer ,  IntPtr vertices ,  IntPtr uvs ,  IntPtr indices ,  Int32 vertexCount ,  Int32 indexCount ,  UIntPtr material ,   ref TwoDimensionTextMeshDrawData meshDrawData ) {
          NativeManager.OutboundManifest["ITwoDimensionView"]["AddNewTextMesh"]
        .DynamicInvoke(new object[] {  pointer ,  vertices ,  uvs ,  indices ,  vertexCount ,  indexCount ,  material ,  meshDrawData  } );
    }

    }
}