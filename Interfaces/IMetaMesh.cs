
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
    public static class IMetaMesh {
    
    public static void SetMaterial( UIntPtr multiMeshPointer ,  UIntPtr materialPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetMaterial"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  materialPointer  } );
    }

    public static void SetLodBias( UIntPtr multiMeshPointer ,  Int32 lod_bias ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetLodBias"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  lod_bias  } );
    }

    public static NativeObjectPointer CreateMetaMesh( Byte[] name ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMetaMesh"]["CreateMetaMesh"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static void CheckMetaMeshExistence( Byte[] multiMeshPrefixName ,  Int32 lod_count_check ) {
          NativeManager.OutboundManifest["IMetaMesh"]["CheckMetaMeshExistence"]
        .DynamicInvoke(new object[] {  multiMeshPrefixName ,  lod_count_check  } );
    }

    public static NativeObjectPointer CreateCopyFromName( Byte[] multiMeshPrefixName ,  Boolean showErrors ,  Boolean mayReturnNull ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMetaMesh"]["CreateCopyFromName"]
        .DynamicInvoke(new object[] {  multiMeshPrefixName ,  showErrors ,  mayReturnNull  } );
    }

    public static Int32 GetLodMaskForMeshAtIndex( UIntPtr multiMeshPointer ,  Int32 meshIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetLodMaskForMeshAtIndex"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  meshIndex  } );
    }

    public static Int32 GetTotalGpuSize( UIntPtr multiMeshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetTotalGpuSize"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Int32 RemoveMeshesWithTag( UIntPtr multiMeshPointer ,  Byte[] tag ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["RemoveMeshesWithTag"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  tag  } );
    }

    public static Int32 RemoveMeshesWithoutTag( UIntPtr multiMeshPointer ,  Byte[] tag ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["RemoveMeshesWithoutTag"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  tag  } );
    }

    public static Int32 GetMeshCountWithTag( UIntPtr multiMeshPointer ,  Byte[] tag ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetMeshCountWithTag"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  tag  } );
    }

    public static Boolean HasVertexBufferOrEditDataOrPackageItem( UIntPtr multiMeshPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMetaMesh"]["HasVertexBufferOrEditDataOrPackageItem"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Boolean HasAnyGeneratedLods( UIntPtr multiMeshPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMetaMesh"]["HasAnyGeneratedLods"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Boolean HasAnyLods( UIntPtr multiMeshPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMetaMesh"]["HasAnyLods"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void CopyTo( UIntPtr metaMesh ,  UIntPtr targetMesh ,  Boolean copyMeshes ) {
          NativeManager.OutboundManifest["IMetaMesh"]["CopyTo"]
        .DynamicInvoke(new object[] {  metaMesh ,  targetMesh ,  copyMeshes  } );
    }

    public static void ClearMeshesForOtherLods( UIntPtr multiMeshPointer ,  Int32 lodToKeep ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ClearMeshesForOtherLods"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  lodToKeep  } );
    }

    public static void ClearMeshesForLod( UIntPtr multiMeshPointer ,  Int32 lodToClear ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ClearMeshesForLod"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  lodToClear  } );
    }

    public static void ClearMeshesForLowerLods( UIntPtr multiMeshPointer ,  Int32 lod ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ClearMeshesForLowerLods"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  lod  } );
    }

    public static void ClearMeshes( UIntPtr multiMeshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ClearMeshes"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void SetNumLods( UIntPtr multiMeshPointer ,  Int32 num_lod ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetNumLods"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  num_lod  } );
    }

    public static void AddMesh( UIntPtr multiMeshPointer ,  UIntPtr meshPointer ,  UInt32 lodLevel ) {
          NativeManager.OutboundManifest["IMetaMesh"]["AddMesh"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  meshPointer ,  lodLevel  } );
    }

    public static void AddMetaMesh( UIntPtr metaMeshPtr ,  UIntPtr otherMetaMeshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["AddMetaMesh"]
        .DynamicInvoke(new object[] {  metaMeshPtr ,  otherMetaMeshPointer  } );
    }

    public static void SetCullMode( UIntPtr metaMeshPtr ,  MBMeshCullingMode cullMode ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetCullMode"]
        .DynamicInvoke(new object[] {  metaMeshPtr ,  cullMode  } );
    }

    public static void MergeMultiMeshes( UIntPtr multiMeshPointer ,  UIntPtr multiMeshToMergePointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["MergeMultiMeshes"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  multiMeshToMergePointer  } );
    }

    public static void AssignClothBodyFrom( UIntPtr multiMeshPointer ,  UIntPtr multiMeshToMergePointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["AssignClothBodyFrom"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  multiMeshToMergePointer  } );
    }

    public static void BatchMultiMeshes( UIntPtr multiMeshPointer ,  UIntPtr multiMeshToMergePointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["BatchMultiMeshes"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  multiMeshToMergePointer  } );
    }

    public static Boolean HasClothData( UIntPtr multiMeshPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMetaMesh"]["HasClothData"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void BatchMultiMeshesMultiple( UIntPtr multiMeshPointer ,  IntPtr multiMeshToMergePointers ,  Int32 metaMeshCount ) {
          NativeManager.OutboundManifest["IMetaMesh"]["BatchMultiMeshesMultiple"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  multiMeshToMergePointers ,  metaMeshCount  } );
    }

    public static void ClearEditData( UIntPtr multiMeshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ClearEditData"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Int32 GetMeshCount( UIntPtr multiMeshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetMeshCount"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static NativeObjectPointer GetMeshAtIndex( UIntPtr multiMeshPointer ,  Int32 meshIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMetaMesh"]["GetMeshAtIndex"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  meshIndex  } );
    }

    public static NativeObjectPointer GetMorphedCopy( Byte[] multiMeshName ,  Single morphTarget ,  Boolean showErrors ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMetaMesh"]["GetMorphedCopy"]
        .DynamicInvoke(new object[] {  multiMeshName ,  morphTarget ,  showErrors  } );
    }

    public static NativeObjectPointer CreateCopy( UIntPtr ptr ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMetaMesh"]["CreateCopy"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void Release( UIntPtr multiMeshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["Release"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void SetGlossMultiplier( UIntPtr multiMeshPointer ,  Single value ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetGlossMultiplier"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  value  } );
    }

    public static UInt32 GetFactor1( UIntPtr multiMeshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMetaMesh"]["GetFactor1"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static UInt32 GetFactor2( UIntPtr multiMeshPointer ) {
         return   (UInt32)  NativeManager.OutboundManifest["IMetaMesh"]["GetFactor2"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void SetFactor1Linear( UIntPtr multiMeshPointer ,  UInt32 linearFactorColor1 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFactor1Linear"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  linearFactorColor1  } );
    }

    public static void SetFactor2Linear( UIntPtr multiMeshPointer ,  UInt32 linearFactorColor2 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFactor2Linear"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  linearFactorColor2  } );
    }

    public static void SetFactor1( UIntPtr multiMeshPointer ,  UInt32 factorColor1 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFactor1"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  factorColor1  } );
    }

    public static void SetFactor2( UIntPtr multiMeshPointer ,  UInt32 factorColor2 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFactor2"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  factorColor2  } );
    }

    public static void SetVectorArgument( UIntPtr multiMeshPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetVectorArgument"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static void SetVectorArgument2( UIntPtr multiMeshPointer ,  Single vectorArgument0 ,  Single vectorArgument1 ,  Single vectorArgument2 ,  Single vectorArgument3 ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetVectorArgument2"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  vectorArgument0 ,  vectorArgument1 ,  vectorArgument2 ,  vectorArgument3  } );
    }

    public static Vec3 GetVectorArgument2( UIntPtr multiMeshPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMetaMesh"]["GetVectorArgument2"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void GetFrame( UIntPtr multiMeshPointer ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMetaMesh"]["GetFrame"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  outFrame  } );
    }

    public static void SetFrame( UIntPtr multiMeshPointer ,   ref MatrixFrame meshFrame ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFrame"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  meshFrame  } );
    }

    public static Vec3 GetVectorUserData( UIntPtr multiMeshPointer ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMetaMesh"]["GetVectorUserData"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void SetVectorUserData( UIntPtr multiMeshPointer ,   ref Vec3 vectorArg ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetVectorUserData"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  vectorArg  } );
    }

    public static void SetBillboarding( UIntPtr multiMeshPointer ,  BillboardType billboard ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetBillboarding"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  billboard  } );
    }

    public static void UseHeadBoneFaceGenScaling( UIntPtr multiMeshPointer ,  UIntPtr skeleton ,  SByte headLookDirectionBoneIndex ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IMetaMesh"]["UseHeadBoneFaceGenScaling"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  skeleton ,  headLookDirectionBoneIndex ,  frame  } );
    }

    public static void DrawTextWithDefaultFont( UIntPtr multiMeshPointer ,  Byte[] text ,  Vec2 textPositionMin ,  Vec2 textPositionMax ,  Vec2 size ,  UInt32 color ,  TextFlags flags ) {
          NativeManager.OutboundManifest["IMetaMesh"]["DrawTextWithDefaultFont"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  text ,  textPositionMin ,  textPositionMax ,  size ,  color ,  flags  } );
    }

    public static void GetBoundingBox( UIntPtr multiMeshPointer ,   ref BoundingBox outBoundingBox ) {
          NativeManager.OutboundManifest["IMetaMesh"]["GetBoundingBox"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  outBoundingBox  } );
    }

    public static VisibilityMaskFlags GetVisibilityMask( UIntPtr multiMeshPointer ) {
         return   (VisibilityMaskFlags)  NativeManager.OutboundManifest["IMetaMesh"]["GetVisibilityMask"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static void SetVisibilityMask( UIntPtr multiMeshPointer ,  VisibilityMaskFlags visibilityMask ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetVisibilityMask"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  visibilityMask  } );
    }

    public static Int32 GetName( UIntPtr multiMeshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetName"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Int32 GetMultiMeshCount() {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetMultiMeshCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetAllMultiMeshes( IntPtr gameEntitiesTemp ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["GetAllMultiMeshes"]
        .DynamicInvoke(new object[] {  gameEntitiesTemp  } );
    }

    public static void GetMultiMesh( Byte[] name ,  IntPtr gameEntity ) {
          NativeManager.OutboundManifest["IMetaMesh"]["GetMultiMesh"]
        .DynamicInvoke(new object[] {  name ,  gameEntity  } );
    }

    public static void PreloadForRendering( UIntPtr multiMeshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["PreloadForRendering"]
        .DynamicInvoke(new object[] {  multiMeshPointer  } );
    }

    public static Int32 CheckResources( UIntPtr meshPointer ) {
         return   (Int32)  NativeManager.OutboundManifest["IMetaMesh"]["CheckResources"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void PreloadShaders( UIntPtr multiMeshPointer ,  Boolean useTableau ,  Boolean useTeamColor ) {
          NativeManager.OutboundManifest["IMetaMesh"]["PreloadShaders"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  useTableau ,  useTeamColor  } );
    }

    public static void RecomputeBoundingBox( UIntPtr multiMeshPointer ,  Boolean recomputeMeshes ) {
          NativeManager.OutboundManifest["IMetaMesh"]["RecomputeBoundingBox"]
        .DynamicInvoke(new object[] {  multiMeshPointer ,  recomputeMeshes  } );
    }

    public static void AddEditDataUser( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["AddEditDataUser"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void ReleaseEditDataUser( UIntPtr meshPointer ) {
          NativeManager.OutboundManifest["IMetaMesh"]["ReleaseEditDataUser"]
        .DynamicInvoke(new object[] {  meshPointer  } );
    }

    public static void SetEditDataPolicy( UIntPtr meshPointer ,  EditDataPolicy policy ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetEditDataPolicy"]
        .DynamicInvoke(new object[] {  meshPointer ,  policy  } );
    }

    public static void SetContourState( UIntPtr meshPointer ,  Boolean alwaysVisible ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetContourState"]
        .DynamicInvoke(new object[] {  meshPointer ,  alwaysVisible  } );
    }

    public static void SetContourColor( UIntPtr meshPointer ,  UInt32 color ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetContourColor"]
        .DynamicInvoke(new object[] {  meshPointer ,  color  } );
    }

    public static void SetMaterialToSubMeshesWithTag( UIntPtr meshPointer ,  UIntPtr materialPointer ,  Byte[] tag ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetMaterialToSubMeshesWithTag"]
        .DynamicInvoke(new object[] {  meshPointer ,  materialPointer ,  tag  } );
    }

    public static void SetFactorColorToSubMeshesWithTag( UIntPtr meshPointer ,  UInt32 color ,  Byte[] tag ) {
          NativeManager.OutboundManifest["IMetaMesh"]["SetFactorColorToSubMeshesWithTag"]
        .DynamicInvoke(new object[] {  meshPointer ,  color ,  tag  } );
    }

    }
}