
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
    public static class IMesh {
    
    public static NativeObjectPointer CreateMesh( Boolean editable ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["CreateMesh"]
        .DynamicInvoke(new object[] {  editable  } );
    }

    public static NativeObjectPointer GetBaseMesh( UIntPtr ptr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["GetBaseMesh"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static NativeObjectPointer CreateMeshWithMaterial( UIntPtr ptr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["CreateMeshWithMaterial"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static NativeObjectPointer CreateMeshCopy( UIntPtr meshPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["CreateMeshCopy"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetColorAndStroke( UIntPtr meshPointer ,  Boolean drawStroke ) {
          NativeManager.OutboundManifest["IMesh"]["SetColorAndStroke"]
        .DynamicInvoke(new object[] {  meshPointer ,  drawStroke  } );
    }

    public static void SetMeshRenderOrder( UIntPtr meshPointer ,  Int32 renderorder ) {
          NativeManager.OutboundManifest["IMesh"]["SetMeshRenderOrder"]
        .DynamicInvoke(new object[] {  meshPointer ,  renderorder  } );
    }

    public static Boolean HasTag( UIntPtr meshPointer ,  Byte[] tag ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMesh"]["HasTag"]
        .DynamicInvoke(new object[] {  meshPointer ,  tag  } );
    }

    public static NativeObjectPointer GetMeshFromResource( Byte[] materialName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["GetMeshFromResource"]
        .DynamicInvoke(new object[] {  materialName  } );
    }

    public static NativeObjectPointer GetRandomMeshWithVdecl( Int32 vdecl ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["GetRandomMeshWithVdecl"]
        .DynamicInvoke(new object[] {  vdecl  } );
    }

    public static void SetMaterialByName( UIntPtr meshPointer ,  Byte[] materialName ) {
          NativeManager.OutboundManifest["IMesh"]["SetMaterialByName"]
        .DynamicInvoke(new object[] {  meshPointer ,  materialName  } );
    }

    public static void SetMaterial( UIntPtr meshPointer ,  UIntPtr materialpointer ) {
          NativeManager.OutboundManifest["IMesh"]["SetMaterial"]
        .DynamicInvoke(new object[] {  meshPointer ,  materialpointer  } );
    }

    public static void SetVectorArgument( UIntPtr meshPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IMesh"]["SetVectorArgument"]
        .DynamicInvoke(new object[] {  meshPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void SetVectorArgument2( UIntPtr meshPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IMesh"]["SetVectorArgument2"]
        .DynamicInvoke(new object[] {  meshPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static NativeObjectPointer GetMaterial( UIntPtr meshPointer ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMesh"]["GetMaterial"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void ReleaseResources( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["ReleaseResources"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static Int32 AddFaceCorner( UIntPtr meshPointer ,  Vec3 vertexPosition ,  Vec3 vertexNormal ,  Vec2 vertexUVCoordinates ,  UInt32 vertexColor ,  UIntPtr lockHandle ) {
         return   (Int32)  NativeManager.OutboundManifest["IMesh"]["AddFaceCorner"]
        .DynamicInvoke(new object[] {  meshPointer ,  vertexPosition ,  vertexNormal ,  vertexUVCoordinates ,  vertexColor ,  lockHandle  } );
    }

    public static Int32 AddFace( UIntPtr meshPointer ,  Int32 faceCorner0 ,  Int32 faceCorner1 ,  Int32 faceCorner2 ,  UIntPtr lockHandle ) {
         return   (Int32)  NativeManager.OutboundManifest["IMesh"]["AddFace"]
        .DynamicInvoke(new object[] {  meshPointer ,  faceCorner0 ,  faceCorner1 ,  faceCorner2 ,  lockHandle  } );
    }

    public static void ClearMesh( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["ClearMesh"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetName( UIntPtr meshPointer ,  Byte[] name ) {
          NativeManager.OutboundManifest["IMesh"]["SetName"]
        .DynamicInvoke(new object[] {  meshPointer ,  name  } );
    }

    public static Int32 GetName( UIntPtr meshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMesh"]["GetName"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetMorphTime( UIntPtr meshPointer ,  Single newTime ) {
          NativeManager.OutboundManifest["IMesh"]["SetMorphTime"]
        .DynamicInvoke(new object[] {  meshPointer ,  newTime  } );
    }

    public static void SetCullingMode( UIntPtr meshPointer ,  UInt32 newCullingMode ) {
          NativeManager.OutboundManifest["IMesh"]["SetCullingMode"]
        .DynamicInvoke(new object[] {  meshPointer ,  newCullingMode  } );
    }

    public static void SetColor( UIntPtr meshPointer ,  UInt32 newColor ) {
          NativeManager.OutboundManifest["IMesh"]["SetColor"]
        .DynamicInvoke(new object[] {  meshPointer ,  newColor  } );
    }

    public static UInt32 GetColor( UIntPtr meshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMesh"]["GetColor"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetColor2( UIntPtr meshPointer ,  UInt32 newColor2 ) {
          NativeManager.OutboundManifest["IMesh"]["SetColor2"]
        .DynamicInvoke(new object[] {  meshPointer ,  newColor2  } );
    }

    public static UInt32 GetColor2( UIntPtr meshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMesh"]["GetColor2"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetColorAlpha( UIntPtr meshPointer ,  UInt32 newColorAlpha ) {
          NativeManager.OutboundManifest["IMesh"]["SetColorAlpha"]
        .DynamicInvoke(new object[] {  meshPointer ,  newColorAlpha  } );
    }

    public static UInt32 GetFaceCount( UIntPtr meshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMesh"]["GetFaceCount"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static UInt32 GetFaceCornerCount( UIntPtr meshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMesh"]["GetFaceCornerCount"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void ComputeNormals( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["ComputeNormals"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void ComputeTangents( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["ComputeTangents"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void AddMeshToMesh( UIntPtr meshPointer ,  UIntPtr newMeshPointer ,   ref MatrixFrame meshFrame ) {
          NativeManager.OutboundManifest["IMesh"]["AddMeshToMesh"]
        .DynamicInvoke(new object[] {  meshPointer ,  newMeshPointer ,  meshFrame  } );
    }

    public static void SetLocalFrame( UIntPtr meshPointer ,   ref MatrixFrame meshFrame ) {
          NativeManager.OutboundManifest["IMesh"]["SetLocalFrame"]
        .DynamicInvoke(new object[] {  meshPointer ,  meshFrame  } );
    }

    public static void GetLocalFrame( UIntPtr meshPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMesh"]["GetLocalFrame"]
        .DynamicInvoke(new object[] {  meshPointer ,  outFrame  } );
    }

    public static void UpdateBoundingBox( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["UpdateBoundingBox"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetAsNotEffectedBySeason( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["SetAsNotEffectedBySeason"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static Single GetBoundingBoxWidth( UIntPtr meshPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMesh"]["GetBoundingBoxWidth"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static Single GetBoundingBoxHeight( UIntPtr meshPointer ) {
         return   (Single)  NativeManager.OutboundManifest["IMesh"]["GetBoundingBoxHeight"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static Vec3 GetBoundingBoxMin( UIntPtr meshPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMesh"]["GetBoundingBoxMin"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static Vec3 GetBoundingBoxMax( UIntPtr meshPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMesh"]["GetBoundingBoxMax"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void AddTriangle( UIntPtr meshPointer ,  Vec3 p1 ,  Vec3 p2 ,  Vec3 p3 ,  Vec2 uv1 ,  Vec2 uv2 ,  Vec2 uv3 ,  UInt32 color ,  UIntPtr lockHandle ) {
          NativeManager.OutboundManifest["IMesh"]["AddTriangle"]
        .DynamicInvoke(new object[] {  meshPointer ,  p1 ,  p2 ,  p3 ,  uv1 ,  uv2 ,  uv3 ,  color ,  lockHandle  } );
    }

    public static void AddTriangleWithVertexColors( UIntPtr meshPointer ,  Vec3 p1 ,  Vec3 p2 ,  Vec3 p3 ,  Vec2 uv1 ,  Vec2 uv2 ,  Vec2 uv3 ,  UInt32 c1 ,  UInt32 c2 ,  UInt32 c3 ,  UIntPtr lockHandle ) {
          NativeManager.OutboundManifest["IMesh"]["AddTriangleWithVertexColors"]
        .DynamicInvoke(new object[] {  meshPointer ,  p1 ,  p2 ,  p3 ,  uv1 ,  uv2 ,  uv3 ,  c1 ,  c2 ,  c3 ,  lockHandle  } );
    }

    public static void HintIndicesDynamic( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["HintIndicesDynamic"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void HintVerticesDynamic( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["HintVerticesDynamic"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void RecomputeBoundingBox( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["RecomputeBoundingBox"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static BillboardType GetBillboard( UIntPtr meshPointer ) {
         return   (BillboardType)  NativeManager.OutboundManifest["IMesh"]["GetBillboard"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetBillboard( UIntPtr meshPointer ,  BillboardType value ) {
          NativeManager.OutboundManifest["IMesh"]["SetBillboard"]
        .DynamicInvoke(new object[] {  meshPointer ,  value  } );
    }

    public static VisibilityMaskFlags GetVisibilityMask( UIntPtr meshPointer ) {
         return   (VisibilityMaskFlags)  NativeManager.OutboundManifest["IMesh"]["GetVisibilityMask"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetVisibilityMask( UIntPtr meshPointer ,  VisibilityMaskFlags value ) {
          NativeManager.OutboundManifest["IMesh"]["SetVisibilityMask"]
        .DynamicInvoke(new object[] {  meshPointer ,  value  } );
    }

    public static Int32 GetEditDataFaceCornerCount( UIntPtr meshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMesh"]["GetEditDataFaceCornerCount"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetEditDataFaceCornerVertexColor( UIntPtr meshPointer ,  Int32 index ,  UInt32 color ) {
          NativeManager.OutboundManifest["IMesh"]["SetEditDataFaceCornerVertexColor"]
        .DynamicInvoke(new object[] {  meshPointer ,  index ,  color  } );
    }

    public static UInt32 GetEditDataFaceCornerVertexColor( UIntPtr meshPointer ,  Int32 index ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMesh"]["GetEditDataFaceCornerVertexColor"]
        .DynamicInvoke(new object[] {  meshPointer ,  index  } );
    }

    public static void PreloadForRendering( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["PreloadForRendering"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetContourColor( UIntPtr meshPointer ,  Vec3 color ,  Boolean alwaysVisible ,  Boolean maskMesh ) {
          NativeManager.OutboundManifest["IMesh"]["SetContourColor"]
        .DynamicInvoke(new object[] {  meshPointer ,  color ,  alwaysVisible ,  maskMesh  } );
    }

    public static void DisableContour( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["DisableContour"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetExternalBoundingBox( UIntPtr meshPointer ,   ref BoundingBox bbox ) {
          NativeManager.OutboundManifest["IMesh"]["SetExternalBoundingBox"]
        .DynamicInvoke(new object[] {  meshPointer ,  bbox  } );
    }

    public static void AddEditDataUser( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["AddEditDataUser"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void ReleaseEditDataUser( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMesh"]["ReleaseEditDataUser"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetEditDataPolicy( UIntPtr meshPointer ,  EditDataPolicy policy ) {
          NativeManager.OutboundManifest["IMesh"]["SetEditDataPolicy"]
        .DynamicInvoke(new object[] {  meshPointer ,  policy  } );
    }

    public static UIntPtr LockEditDataWrite( UIntPtr meshPointer ) {
         return   (UIntPtr)  NativeManager.OutboundManifest["IMesh"]["LockEditDataWrite"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void UnlockEditDataWrite( UIntPtr meshPointer ,  UIntPtr handle ) {
          NativeManager.OutboundManifest["IMesh"]["UnlockEditDataWrite"]
        .DynamicInvoke(new object[] {  meshPointer ,  handle  } );
    }

    }
}