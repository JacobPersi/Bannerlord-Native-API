
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
    public static class IMBSkeletonExtensions {
    
    public static NativeObjectPointer CreateAgentSkeleton( Byte[] skeletonName ,  Boolean isHumanoid ,  Int32 actionSetIndex ,  Byte[] monsterUsageSetName ,   ref AnimationSystemData animationSystemData ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["CreateAgentSkeleton"]
        .DynamicInvoke(new object[] {  skeletonName ,  isHumanoid ,  actionSetIndex ,  monsterUsageSetName ,  animationSystemData  } );
    }

    public static NativeObjectPointer CreateSimpleSkeleton( Byte[] skeletonName ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["CreateSimpleSkeleton"]
        .DynamicInvoke(new object[] {  skeletonName  } );
    }

    public static NativeObjectPointer CreateWithActionSet(  ref AnimationSystemData animationSystemData ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["CreateWithActionSet"]
        .DynamicInvoke(new object[] {  animationSystemData  } );
    }

    public static Single GetSkeletonFaceAnimationTime( UIntPtr entityId ) {
         return   (Single)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["GetSkeletonFaceAnimationTime"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void SetSkeletonFaceAnimationTime( UIntPtr entityId ,  Single time ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["SetSkeletonFaceAnimationTime"]
        .DynamicInvoke(new object[] {  entityId ,  time  } );
    }

    public static Int32 GetSkeletonFaceAnimationName( UIntPtr entityId ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["GetSkeletonFaceAnimationName"]
        .DynamicInvoke(new object[] {  entityId  } );
    }

    public static void GetBoneEntitialFrameAtAnimationProgress( UIntPtr skeletonPointer ,  SByte boneIndex ,  Int32 animationIndex ,  Single progress ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["GetBoneEntitialFrameAtAnimationProgress"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  boneIndex ,  animationIndex ,  progress ,  outFrame  } );
    }

    public static void GetBoneEntitialFrame( UIntPtr skeletonPointer ,  SByte bone ,  Boolean useBoneMapping ,  Boolean forceToUpdate ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["GetBoneEntitialFrame"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  bone ,  useBoneMapping ,  forceToUpdate ,  outFrame  } );
    }

    public static void SetAnimationAtChannel( UIntPtr skeletonPointer ,  Int32 animationIndex ,  Int32 channelNo ,  Single animationSpeedMultiplier ,  Single blendInPeriod ,  Single startProgress ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["SetAnimationAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  animationIndex ,  channelNo ,  animationSpeedMultiplier ,  blendInPeriod ,  startProgress  } );
    }

    public static Int32 GetActionAtChannel( UIntPtr skeletonPointer ,  Int32 channelNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["GetActionAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channelNo  } );
    }

    public static void SetFacialAnimationOfChannel( UIntPtr skeletonPointer ,  Int32 channel ,  Byte[] facialAnimationName ,  Boolean playSound ,  Boolean loop ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["SetFacialAnimationOfChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  channel ,  facialAnimationName ,  playSound ,  loop  } );
    }

    public static void SetAgentActionChannel( UIntPtr skeletonPointer ,  Int32 actionChannelNo ,  Int32 actionIndex ,  Single channelParameter ,  Single blendPeriodOverride ,  Boolean forceFaceMorphRestart ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["SetAgentActionChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  actionChannelNo ,  actionIndex ,  channelParameter ,  blendPeriodOverride ,  forceFaceMorphRestart  } );
    }

    public static Boolean DoesActionContinueWithCurrentActionAtChannel( UIntPtr skeletonPointer ,  Int32 actionChannelNo ,  Int32 actionIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBSkeletonExtensions"]["DoesActionContinueWithCurrentActionAtChannel"]
        .DynamicInvoke(new object[] {  skeletonPointer ,  actionChannelNo ,  actionIndex  } );
    }

    public static void TickActionChannels( UIntPtr skeletonPointer ) {
          NativeManager.OutboundManifest["IMBSkeletonExtensions"]["TickActionChannels"]
        .DynamicInvoke(new object[] {  skeletonPointer  } );
    }

    }
}