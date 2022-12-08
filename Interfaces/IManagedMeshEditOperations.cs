
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
    public static class IManagedMeshEditOperations {
    
    public static NativeObjectPointer Create( UIntPtr meshPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["Create"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void Weld( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["Weld"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static Int32 AddVertex( UIntPtr Pointer ,   ref Vec3 vertexPos ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddVertex"]
        .DynamicInvoke(new object[] {  Pointer ,  vertexPos  } );
    }

    public static Int32 AddFaceCorner1( UIntPtr Pointer ,  Int32 vertexIndex ,   ref Vec2 uv0 ,   ref Vec3 color ,   ref Vec3 normal ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddFaceCorner1"]
        .DynamicInvoke(new object[] {  Pointer ,  vertexIndex ,  uv0 ,  color ,  normal  } );
    }

    public static Int32 AddFaceCorner2( UIntPtr Pointer ,  Int32 vertexIndex ,   ref Vec2 uv0 ,   ref Vec2 uv1 ,   ref Vec3 color ,   ref Vec3 normal ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddFaceCorner2"]
        .DynamicInvoke(new object[] {  Pointer ,  vertexIndex ,  uv0 ,  uv1 ,  color ,  normal  } );
    }

    public static Int32 AddFace( UIntPtr Pointer ,  Int32 patchNode0 ,  Int32 patchNode1 ,  Int32 patchNode2 ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddFace"]
        .DynamicInvoke(new object[] {  Pointer ,  patchNode0 ,  patchNode1 ,  patchNode2  } );
    }

    public static void AddTriangle1( UIntPtr Pointer ,   ref Vec3 p1 ,   ref Vec3 p2 ,   ref Vec3 p3 ,   ref Vec2 uv1 ,   ref Vec2 uv2 ,   ref Vec2 uv3 ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddTriangle1"]
        .DynamicInvoke(new object[] {  Pointer ,  p1 ,  p2 ,  p3 ,  uv1 ,  uv2 ,  uv3 ,  color  } );
    }

    public static void AddTriangle2( UIntPtr Pointer ,   ref Vec3 p1 ,   ref Vec3 p2 ,   ref Vec3 p3 ,   ref Vec3 n1 ,   ref Vec3 n2 ,   ref Vec3 n3 ,   ref Vec2 uv1 ,   ref Vec2 uv2 ,   ref Vec2 uv3 ,   ref Vec3 c1 ,   ref Vec3 c2 ,   ref Vec3 c3 ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddTriangle2"]
        .DynamicInvoke(new object[] {  Pointer ,  p1 ,  p2 ,  p3 ,  n1 ,  n2 ,  n3 ,  uv1 ,  uv2 ,  uv3 ,  c1 ,  c2 ,  c3  } );
    }

    public static void AddRectangle3( UIntPtr Pointer ,   ref Vec3 o ,   ref Vec2 size ,   ref Vec2 uv_origin ,   ref Vec2 uvSize ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddRectangle3"]
        .DynamicInvoke(new object[] {  Pointer ,  o ,  size ,  uv_origin ,  uvSize ,  color  } );
    }

    public static void AddRectangleWithInverseUV( UIntPtr Pointer ,   ref Vec3 o ,   ref Vec2 size ,   ref Vec2 uv_origin ,   ref Vec2 uvSize ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddRectangleWithInverseUV"]
        .DynamicInvoke(new object[] {  Pointer ,  o ,  size ,  uv_origin ,  uvSize ,  color  } );
    }

    public static void AddRect( UIntPtr Pointer ,   ref Vec3 originBegin ,   ref Vec3 originEnd ,   ref Vec2 uvBegin ,   ref Vec2 uvEnd ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddRect"]
        .DynamicInvoke(new object[] {  Pointer ,  originBegin ,  originEnd ,  uvBegin ,  uvEnd ,  color  } );
    }

    public static void AddRectWithZUp( UIntPtr Pointer ,   ref Vec3 originBegin ,   ref Vec3 originEnd ,   ref Vec2 uvBegin ,   ref Vec2 uvEnd ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddRectWithZUp"]
        .DynamicInvoke(new object[] {  Pointer ,  originBegin ,  originEnd ,  uvBegin ,  uvEnd ,  color  } );
    }

    public static void InvertFacesWindingOrder( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["InvertFacesWindingOrder"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void ScaleVertices1( UIntPtr Pointer ,  Single newScale ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ScaleVertices1"]
        .DynamicInvoke(new object[] {  Pointer ,  newScale  } );
    }

    public static void MoveVerticesAlongNormal( UIntPtr Pointer ,  Single moveAmount ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["MoveVerticesAlongNormal"]
        .DynamicInvoke(new object[] {  Pointer ,  moveAmount  } );
    }

    public static void ScaleVertices2( UIntPtr Pointer ,   ref Vec3 newScale ,  Boolean keepUvX ,  Single maxUvSize ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ScaleVertices2"]
        .DynamicInvoke(new object[] {  Pointer ,  newScale ,  keepUvX ,  maxUvSize  } );
    }

    public static void TranslateVertices( UIntPtr Pointer ,   ref Vec3 newOrigin ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["TranslateVertices"]
        .DynamicInvoke(new object[] {  Pointer ,  newOrigin  } );
    }

    public static void AddMeshAux( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ,  SByte boneIndex ,   ref Vec3 color ,  Boolean transformNormal ,  Boolean heightGradient ,  Boolean addSkinData ,  Boolean useDoublePrecision ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshAux"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame ,  boneIndex ,  color ,  transformNormal ,  heightGradient ,  addSkinData ,  useDoublePrecision  } );
    }

    public static Int32 ComputeTangents( UIntPtr Pointer ,  Boolean checkFixedNormals ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ComputeTangents"]
        .DynamicInvoke(new object[] {  Pointer ,  checkFixedNormals  } );
    }

    public static void GenerateGrid( UIntPtr Pointer ,   ref Vec2i numEdges ,   ref Vec2 edgeScale ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["GenerateGrid"]
        .DynamicInvoke(new object[] {  Pointer ,  numEdges ,  edgeScale  } );
    }

    public static void RescaleMesh2d( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2d"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax  } );
    }

    public static void RescaleMesh2dRepeatX( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ,  Single frameThickness ,  Int32 frameSide ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2dRepeatX"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax ,  frameThickness ,  frameSide  } );
    }

    public static void RescaleMesh2dRepeatY( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ,  Single frameThickness ,  Int32 frameSide ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2dRepeatY"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax ,  frameThickness ,  frameSide  } );
    }

    public static void RescaleMesh2dRepeatXWithTiling( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ,  Single frameThickness ,  Int32 frameSide ,  Single xyRatio ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2dRepeatXWithTiling"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax ,  frameThickness ,  frameSide ,  xyRatio  } );
    }

    public static void RescaleMesh2dRepeatYWithTiling( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ,  Single frameThickness ,  Int32 frameSide ,  Single xyRatio ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2dRepeatYWithTiling"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax ,  frameThickness ,  frameSide ,  xyRatio  } );
    }

    public static void RescaleMesh2dWithoutChangingUV( UIntPtr Pointer ,   ref Vec2 scaleSizeMin ,   ref Vec2 scaleSizeMax ,  Single remaining ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RescaleMesh2dWithoutChangingUV"]
        .DynamicInvoke(new object[] {  Pointer ,  scaleSizeMin ,  scaleSizeMax ,  remaining  } );
    }

    public static void AddLine( UIntPtr Pointer ,   ref Vec3 start ,   ref Vec3 end ,   ref Vec3 color ,  Single lineWidth ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddLine"]
        .DynamicInvoke(new object[] {  Pointer ,  start ,  end ,  color ,  lineWidth  } );
    }

    public static void ComputeCornerNormals( UIntPtr Pointer ,  Boolean checkFixedNormals ,  Boolean smoothCornerNormals ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ComputeCornerNormals"]
        .DynamicInvoke(new object[] {  Pointer ,  checkFixedNormals ,  smoothCornerNormals  } );
    }

    public static void ComputeCornerNormalsWithSmoothingData( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ComputeCornerNormalsWithSmoothingData"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void AddMesh( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMesh"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame  } );
    }

    public static void AddMeshWithSkinData( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshWithSkinData"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame ,  boneIndex  } );
    }

    public static void AddMeshWithColor( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ,   ref Vec3 vertexColor ,  Boolean useDoublePrecision ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshWithColor"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame ,  vertexColor ,  useDoublePrecision  } );
    }

    public static void AddMeshToBone( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshToBone"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame ,  boneIndex  } );
    }

    public static void AddMeshWithFixedNormals( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshWithFixedNormals"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame  } );
    }

    public static void AddMeshWithFixedNormalsWithHeightGradientColor( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddMeshWithFixedNormalsWithHeightGradientColor"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame  } );
    }

    public static void AddSkinnedMeshWithColor( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame frame ,   ref Vec3 vertexColor ,  Boolean useDoublePrecision ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["AddSkinnedMeshWithColor"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  frame ,  vertexColor ,  useDoublePrecision  } );
    }

    public static void SetCornerVertexColor( UIntPtr Pointer ,  Int32 cornerNo ,   ref Vec3 vertexColor ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetCornerVertexColor"]
        .DynamicInvoke(new object[] {  Pointer ,  cornerNo ,  vertexColor  } );
    }

    public static void SetCornerUV( UIntPtr Pointer ,  Int32 cornerNo ,   ref Vec2 newUV ,  Int32 uvNumber ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetCornerUV"]
        .DynamicInvoke(new object[] {  Pointer ,  cornerNo ,  newUV ,  uvNumber  } );
    }

    public static void ReserveVertices( UIntPtr Pointer ,  Int32 count ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ReserveVertices"]
        .DynamicInvoke(new object[] {  Pointer ,  count  } );
    }

    public static void ReserveFaceCorners( UIntPtr Pointer ,  Int32 count ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ReserveFaceCorners"]
        .DynamicInvoke(new object[] {  Pointer ,  count  } );
    }

    public static void ReserveFaces( UIntPtr Pointer ,  Int32 count ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ReserveFaces"]
        .DynamicInvoke(new object[] {  Pointer ,  count  } );
    }

    public static Int32 RemoveDuplicatedCorners( UIntPtr Pointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RemoveDuplicatedCorners"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void TransformVerticesToParent( UIntPtr Pointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["TransformVerticesToParent"]
        .DynamicInvoke(new object[] {  Pointer ,  frame  } );
    }

    public static void TransformVerticesToLocal( UIntPtr Pointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["TransformVerticesToLocal"]
        .DynamicInvoke(new object[] {  Pointer ,  frame  } );
    }

    public static void SetVertexColor( UIntPtr Pointer ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetVertexColor"]
        .DynamicInvoke(new object[] {  Pointer ,  color  } );
    }

    public static Vec3 GetVertexColor( UIntPtr Pointer ,  Int32 faceCornerIndex ) {
         return   (Vec3)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["GetVertexColor"]
        .DynamicInvoke(new object[] {  Pointer ,  faceCornerIndex  } );
    }

    public static void SetVertexColorAlpha( UIntPtr Pointer ,  Single newAlpha ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetVertexColorAlpha"]
        .DynamicInvoke(new object[] {  Pointer ,  newAlpha  } );
    }

    public static Single GetVertexColorAlpha( UIntPtr Pointer ) {
         return   (Single)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["GetVertexColorAlpha"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void EnsureTransformedVertices( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["EnsureTransformedVertices"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void ApplyCPUSkinning( UIntPtr Pointer ,  UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ApplyCPUSkinning"]
        .DynamicInvoke(new object[] {  Pointer ,  skeletonPointer  } );
    }

    public static void UpdateOverlappedVertexNormals( UIntPtr Pointer ,  UIntPtr meshPointer ,   ref MatrixFrame attachFrame ,  Single mergeRadiusSQ ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["UpdateOverlappedVertexNormals"]
        .DynamicInvoke(new object[] {  Pointer ,  meshPointer ,  attachFrame ,  mergeRadiusSQ  } );
    }

    public static void ClearAll( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["ClearAll"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void SetTangentsOfFaceCorner( UIntPtr Pointer ,  Int32 faceCornerIndex ,   ref Vec3 tangent ,   ref Vec3 binormal ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetTangentsOfFaceCorner"]
        .DynamicInvoke(new object[] {  Pointer ,  faceCornerIndex ,  tangent ,  binormal  } );
    }

    public static void SetPositionOfVertex( UIntPtr Pointer ,  Int32 vertexIndex ,   ref Vec3 position ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["SetPositionOfVertex"]
        .DynamicInvoke(new object[] {  Pointer ,  vertexIndex ,  position  } );
    }

    public static Vec3 GetPositionOfVertex( UIntPtr Pointer ,  Int32 vertexIndex ) {
         return   (Vec3)  NativeManager.OutboundManifest["IManagedMeshEditOperations"]["GetPositionOfVertex"]
        .DynamicInvoke(new object[] {  Pointer ,  vertexIndex  } );
    }

    public static void RemoveFace( UIntPtr Pointer ,  Int32 faceIndex ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["RemoveFace"]
        .DynamicInvoke(new object[] {  Pointer ,  faceIndex  } );
    }

    public static void FinalizeEditing( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IManagedMeshEditOperations"]["FinalizeEditing"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    }
}