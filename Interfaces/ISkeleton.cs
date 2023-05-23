
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
    public static class ISkeleton {
    
    public static NativeObjectPointer CreateFromModel( Byte[] skeletonModelName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISkeleton"]["CreateFromModel"]
        .DynamicInvoke(new object[] {  skeletonModelName  } );
    }

    public static NativeObjectPointer CreateFromModelWithNullAnimTree( UIntPtr entityPointer ,  Byte[] skeletonModelName ,  Single scale ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISkeleton"]["CreateFromModelWithNullAnimTree"]
        .DynamicInvoke(new object[] {  entityPointer ,  skeletonModelName ,  scale  } );
    }

    public static void Freeze( UIntPtr skeletonPointer ,  Boolean isFrozen ) {
          NativeManager.OutboundManifest["ISkeleton"]["Freeze"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  isFrozen  } );
    }

    public static Boolean IsFrozen( UIntPtr skeletonPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISkeleton"]["IsFrozen"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void AddMeshToBone( UIntPtr skeletonPointer ,  UIntPtr multiMeshPointer ,  SByte bone_index ) {
          NativeManager.OutboundManifest["ISkeleton"]["AddMeshToBone"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  multiMeshPointer ,  bone_index  } );
    }

    public static SByte GetBoneChildCount( UIntPtr skeleton ,  SByte boneIndex ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneChildCount"]
        .DynamicInvoke(new object[] {  skeleton ,  boneIndex  } );
    }

    public static SByte GetBoneChildAtIndex( UIntPtr skeleton ,  SByte boneIndex ,  SByte childIndex ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneChildAtIndex"]
        .DynamicInvoke(new object[] {  skeleton ,  boneIndex ,  childIndex  } );
    }

    public static Int32 GetBoneName( UIntPtr skeleton ,  SByte boneIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneName"]
        .DynamicInvoke(new object[] {  skeleton ,  boneIndex  } );
    }

    public static Int32 GetName( UIntPtr skeleton ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetName"]
        .DynamicInvoke(new object[] {  skeleton  } );
    }

    public static SByte GetParentBoneIndex( UIntPtr skeleton ,  SByte boneIndex ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetParentBoneIndex"]
        .DynamicInvoke(new object[] {  skeleton ,  boneIndex  } );
    }

    public static void SetBoneLocalFrame( UIntPtr skeletonPointer ,  SByte boneIndex ,   ref MatrixFrame localFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["SetBoneLocalFrame"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  localFrame  } );
    }

    public static SByte GetBoneCount( UIntPtr skeletonPointer ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneCount"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void ForceUpdateBoneFrames( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["ForceUpdateBoneFrames"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void GetBoneEntitialFrameWithIndex( UIntPtr skeletonPointer ,  SByte boneIndex ,   ref MatrixFrame outEntitialFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneEntitialFrameWithIndex"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  outEntitialFrame  } );
    }

    public static void GetBoneEntitialFrameWithName( UIntPtr skeletonPointer ,  Byte[] boneName ,   ref MatrixFrame outEntitialFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneEntitialFrameWithName"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneName ,  outEntitialFrame  } );
    }

    public static void AddPrefabEntityToBone( UIntPtr skeletonPointer ,  Byte[] prefab_name ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["ISkeleton"]["AddPrefabEntityToBone"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  prefab_name ,  boneIndex  } );
    }

    public static SByte GetSkeletonBoneMapping( UIntPtr skeletonPointer ,  SByte boneIndex ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetSkeletonBoneMapping"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex  } );
    }

    public static void AddMesh( UIntPtr skeletonPointer ,  UIntPtr mesnPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["AddMesh"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  mesnPointer  } );
    }

    public static void ClearMeshes( UIntPtr skeletonPointer ,  Boolean clearBoneComponents ) {
          NativeManager.OutboundManifest["ISkeleton"]["ClearMeshes"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  clearBoneComponents  } );
    }

    public static void GetBoneBody( UIntPtr skeletonPointer ,  SByte boneIndex ,   ref CapsuleData data ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneBody"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  data  } );
    }

    public static RagdollState GetCurrentRagdollState( UIntPtr skeletonPointer ) {
         return   (RagdollState)  NativeManager.OutboundManifest["ISkeleton"]["GetCurrentRagdollState"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void ActivateRagdoll( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["ActivateRagdoll"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static Boolean SkeletonModelExist( Byte[] skeletonModelName ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISkeleton"]["SkeletonModelExist"]
        .DynamicInvoke(new object[] {  skeletonModelName  } );
    }

    public static NativeObjectPointer GetComponentAtIndex( UIntPtr skeletonPointer ,  ComponentType componentType ,  Int32 index ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISkeleton"]["GetComponentAtIndex"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  componentType ,  index  } );
    }

    public static void GetBoneEntitialFrame( UIntPtr skeletonPointer ,  SByte boneIndex ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneEntitialFrame"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  outFrame  } );
    }

    public static Int32 GetBoneComponentCount( UIntPtr skeletonPointer ,  SByte boneIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneComponentCount"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex  } );
    }

    public static void AddComponentToBone( UIntPtr skeletonPointer ,  SByte boneIndex ,  UIntPtr component ) {
          NativeManager.OutboundManifest["ISkeleton"]["AddComponentToBone"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  component  } );
    }

    public static NativeObjectPointer GetBoneComponentAtIndex( UIntPtr skeletonPointer ,  SByte boneIndex ,  Int32 componentIndex ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneComponentAtIndex"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  componentIndex  } );
    }

    public static Boolean HasBoneComponent( UIntPtr skeletonPointer ,  SByte boneIndex ,  UIntPtr component ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISkeleton"]["HasBoneComponent"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  component  } );
    }

    public static void RemoveBoneComponent( UIntPtr skeletonPointer ,  SByte boneIndex ,  UIntPtr component ) {
          NativeManager.OutboundManifest["ISkeleton"]["RemoveBoneComponent"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  component  } );
    }

    public static void ClearMeshesAtBone( UIntPtr skeletonPointer ,  SByte boneIndex ) {
          NativeManager.OutboundManifest["ISkeleton"]["ClearMeshesAtBone"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex  } );
    }

    public static Int32 GetComponentCount( UIntPtr skeletonPointer ,  ComponentType componentType ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetComponentCount"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  componentType  } );
    }

    public static void SetUsePreciseBoundingVolume( UIntPtr skeletonPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISkeleton"]["SetUsePreciseBoundingVolume"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  value  } );
    }

    public static void TickAnimations( UIntPtr skeletonPointer ,   ref MatrixFrame globalFrame ,  Single dt ,  Boolean tickAnimsForChildren ) {
          NativeManager.OutboundManifest["ISkeleton"]["TickAnimations"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  globalFrame ,  dt ,  tickAnimsForChildren  } );
    }

    public static void TickAnimationsAndForceUpdate( UIntPtr skeletonPointer ,   ref MatrixFrame globalFrame ,  Single dt ,  Boolean tickAnimsForChildren ) {
          NativeManager.OutboundManifest["ISkeleton"]["TickAnimationsAndForceUpdate"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  globalFrame ,  dt ,  tickAnimsForChildren  } );
    }

    public static Single GetSkeletonAnimationParameterAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ) {
         return   (Single)  NativeManager.OutboundManifest["ISkeleton"]["GetSkeletonAnimationParameterAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo  } );
    }

    public static void SetSkeletonAnimationParameterAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ,  Single parameter ) {
          NativeManager.OutboundManifest["ISkeleton"]["SetSkeletonAnimationParameterAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo ,  parameter  } );
    }

    public static Single GetSkeletonAnimationSpeedAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ) {
         return   (Single)  NativeManager.OutboundManifest["ISkeleton"]["GetSkeletonAnimationSpeedAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo  } );
    }

    public static void SetSkeletonAnimationSpeedAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ,  Single speed ) {
          NativeManager.OutboundManifest["ISkeleton"]["SetSkeletonAnimationSpeedAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo ,  speed  } );
    }

    public static void SetSkeletonUptoDate( UIntPtr skeletonPointer ,  Boolean value ) {
          NativeManager.OutboundManifest["ISkeleton"]["SetSkeletonUptoDate"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  value  } );
    }

    public static void GetBoneEntitialRestFrame( UIntPtr skeletonPointer ,  SByte boneIndex ,  Boolean useBoneMapping ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneEntitialRestFrame"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  useBoneMapping ,  outFrame  } );
    }

    public static void GetBoneLocalRestFrame( UIntPtr skeletonPointer ,  SByte boneIndex ,  Boolean useBoneMapping ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneLocalRestFrame"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  useBoneMapping ,  outFrame  } );
    }

    public static void GetBoneEntitialFrameAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ,  SByte boneIndex ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetBoneEntitialFrameAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo ,  boneIndex ,  outFrame  } );
    }

    public static Int32 GetAnimationAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetAnimationAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo  } );
    }

    public static Int32 GetAnimationIndexAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["ISkeleton"]["GetAnimationIndexAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo  } );
    }

    public static void ResetCloths( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["ResetCloths"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void ResetFrames( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["ResetFrames"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void ClearComponents( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["ClearComponents"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void AddComponent( UIntPtr skeletonPointer ,  UIntPtr componentPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["AddComponent"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  componentPointer  } );
    }

    public static Boolean HasComponent( UIntPtr skeletonPointer ,  UIntPtr componentPointer ) {
         return   (Boolean)  NativeManager.OutboundManifest["ISkeleton"]["HasComponent"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  componentPointer  } );
    }

    public static void RemoveComponent( UIntPtr SkeletonPointer ,  UIntPtr componentPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["RemoveComponent"]
        .DynamicInvoke(new object[] {  SkeletonPointer ,  componentPointer  } );
    }

    public static void UpdateEntitialFramesFromLocalFrames( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["ISkeleton"]["UpdateEntitialFramesFromLocalFrames"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    public static void GetAllMeshes( UIntPtr skeleton ,  UIntPtr nativeObjectArray ) {
          NativeManager.OutboundManifest["ISkeleton"]["GetAllMeshes"]
        .DynamicInvoke(new object[] {  skeleton ,  nativeObjectArray  } );
    }

    public static SByte GetBoneIndexFromName( Byte[] skeletonModelName ,  Byte[] boneName ) {
         return   (SByte)  NativeManager.OutboundManifest["ISkeleton"]["GetBoneIndexFromName"]
        .DynamicInvoke(new object[] {  skeletonModelName ,  boneName  } );
    }

    }
}