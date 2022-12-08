
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
    public static class IMeshBuilder {
    
    public static NativeObjectPointer CreateTilingWindowMesh( Byte[] baseMeshName ,   ref Vec2 meshSizeMin ,   ref Vec2 meshSizeMax ,   ref Vec2 borderThickness ,   ref Vec2 backgroundBorderThickness ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMeshBuilder"]["CreateTilingWindowMesh"]
        .DynamicInvoke(new object[] {  baseMeshName ,  meshSizeMin ,  meshSizeMax ,  borderThickness ,  backgroundBorderThickness  } );
    }

    public static NativeObjectPointer CreateTilingButtonMesh( Byte[] baseMeshName ,   ref Vec2 meshSizeMin ,   ref Vec2 meshSizeMax ,   ref Vec2 borderThickness ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMeshBuilder"]["CreateTilingButtonMesh"]
        .DynamicInvoke(new object[] {  baseMeshName ,  meshSizeMin ,  meshSizeMax ,  borderThickness  } );
    }

    public static NativeObjectPointer FinalizeMeshBuilder( Int32 num_vertices ,  IntPtr vertices ,  Int32 num_face_corners ,  IntPtr faceCorners ,  Int32 num_faces ,  IntPtr faces ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMeshBuilder"]["FinalizeMeshBuilder"]
        .DynamicInvoke(new object[] {  num_vertices ,  vertices ,  num_face_corners ,  faceCorners ,  num_faces ,  faces  } );
    }

    }
}