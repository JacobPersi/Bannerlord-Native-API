
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
    public static class IMBAnimation {
    
    public static Int32 GetIDWithIndex( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetIDWithIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Int32 GetIndexWithID( Byte[] id ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetIndexWithID"]
        .DynamicInvoke(new object[] {  id  } );
    }

    public static Vec3 GetDisplacementVector( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Vec3)  NativeManager.OutboundManifest["IMBAnimation"]["GetDisplacementVector"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Boolean CheckAnimationClipExists( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAnimation"]["CheckAnimationClipExists"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static void PrefetchAnimationClip( Int32 actionSetNo ,  Int32 actionIndex ) {
          NativeManager.OutboundManifest["IMBAnimation"]["PrefetchAnimationClip"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Int32 AnimationIndexOfActionCode( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["AnimationIndexOfActionCode"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static AnimFlags GetAnimationFlags( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (AnimFlags)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationFlags"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static ActionCodeType GetActionType( Int32 actionIndex ) {
         return   (ActionCodeType)  NativeManager.OutboundManifest["IMBAnimation"]["GetActionType"]
        .DynamicInvoke(new object[] {  actionIndex  } );
    }

    public static Single GetAnimationDuration( Int32 animationIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationDuration"]
        .DynamicInvoke(new object[] {  animationIndex  } );
    }

    public static Single GetAnimationParameter1( Int32 animationIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationParameter1"]
        .DynamicInvoke(new object[] {  animationIndex  } );
    }

    public static Single GetAnimationParameter2( Int32 animationIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationParameter2"]
        .DynamicInvoke(new object[] {  animationIndex  } );
    }

    public static Single GetAnimationParameter3( Int32 animationIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationParameter3"]
        .DynamicInvoke(new object[] {  animationIndex  } );
    }

    public static Single GetActionAnimationDuration( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetActionAnimationDuration"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Int32 GetAnimationName( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationName"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Int32 GetAnimationContinueToAction( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationContinueToAction"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Single GetAnimationBlendInPeriod( Int32 animationIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetAnimationBlendInPeriod"]
        .DynamicInvoke(new object[] {  animationIndex  } );
    }

    public static Single GetActionBlendOutStartProgress( Int32 actionSetNo ,  Int32 actionIndex ) {
         return   (Single)  NativeManager.OutboundManifest["IMBAnimation"]["GetActionBlendOutStartProgress"]
        .DynamicInvoke(new object[] {  actionSetNo ,  actionIndex  } );
    }

    public static Int32 GetActionCodeWithName( Byte[] name ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetActionCodeWithName"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static Int32 GetActionNameWithCode( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetActionNameWithCode"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Int32 GetNumActionCodes() {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetNumActionCodes"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetNumAnimations() {
         return   (Int32)  NativeManager.OutboundManifest["IMBAnimation"]["GetNumAnimations"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsAnyAnimationLoadingFromDisk() {
         return   (Boolean)  NativeManager.OutboundManifest["IMBAnimation"]["IsAnyAnimationLoadingFromDisk"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}