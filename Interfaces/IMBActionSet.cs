
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
    public static class IMBActionSet {
    
    public static Int32 GetIndexWithID( Byte[] id ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetIndexWithID"]
        .DynamicInvoke(new object[] {  id  } );
    }

    public static Int32 GetNameWithIndex( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetNameWithIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Int32 GetSkeletonName( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetSkeletonName"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Int32 GetNumberOfActionSets() {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetNumberOfActionSets"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetNumberOfMonsterUsageSets() {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetNumberOfMonsterUsageSets"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetAnimationName( Int32 index ,  Int32 actionNo ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBActionSet"]["GetAnimationName"]
        .DynamicInvoke(new object[] {  index ,  actionNo  } );
    }

    public static Boolean AreActionsAlternatives( Int32 index ,  Int32 actionNo1 ,  Int32 actionNo2 ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBActionSet"]["AreActionsAlternatives"]
        .DynamicInvoke(new object[] {  index ,  actionNo1 ,  actionNo2  } );
    }

    public static SByte GetBoneIndexWithId( Byte[] actionSetId ,  Byte[] boneId ) {
         return   (SByte)  NativeManager.OutboundManifest["IMBActionSet"]["GetBoneIndexWithId"]
        .DynamicInvoke(new object[] {  actionSetId ,  boneId  } );
    }

    public static Boolean GetBoneHasParentBone( Byte[] actionSetId ,  SByte boneIndex ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBActionSet"]["GetBoneHasParentBone"]
        .DynamicInvoke(new object[] {  actionSetId ,  boneIndex  } );
    }

    }
}