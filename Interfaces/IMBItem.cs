
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
    public static class IMBItem {
    
    public static Int32 GetItemUsageIndex( Byte[] itemusagename ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBItem"]["GetItemUsageIndex"]
        .DynamicInvoke(new object[] {  itemusagename  } );
    }

    public static Int32 GetItemHolsterIndex( Byte[] itemholstername ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBItem"]["GetItemHolsterIndex"]
        .DynamicInvoke(new object[] {  itemholstername  } );
    }

    public static Boolean GetItemIsPassiveUsage( Byte[] itemUsageName ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBItem"]["GetItemIsPassiveUsage"]
        .DynamicInvoke(new object[] {  itemUsageName  } );
    }

    public static void GetHolsterFrameByIndex( Int32 index ,   ref MatrixFrame outFrame ) {
          NativeManager.OutboundManifest["IMBItem"]["GetHolsterFrameByIndex"]
        .DynamicInvoke(new object[] {  index ,  outFrame  } );
    }

    public static Int32 GetItemUsageSetFlags( Byte[] ItemUsageName ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBItem"]["GetItemUsageSetFlags"]
        .DynamicInvoke(new object[] {  ItemUsageName  } );
    }

    public static Int32 GetItemUsageReloadActionCode( Byte[] itemUsageName ,  Int32 usageDirection ,  Boolean isMounted ,  Int32 leftHandUsageSetIndex ,  Boolean isLeftStance ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBItem"]["GetItemUsageReloadActionCode"]
        .DynamicInvoke(new object[] {  itemUsageName ,  usageDirection ,  isMounted ,  leftHandUsageSetIndex ,  isLeftStance  } );
    }

    public static Int32 GetItemUsageStrikeType( Byte[] itemUsageName ,  Int32 usageDirection ,  Boolean isMounted ,  Int32 leftHandUsageSetIndex ,  Boolean isLeftStance ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBItem"]["GetItemUsageStrikeType"]
        .DynamicInvoke(new object[] {  itemUsageName ,  usageDirection ,  isMounted ,  leftHandUsageSetIndex ,  isLeftStance  } );
    }

    public static Single GetMissileRange( Single shot_speed ,  Single z_diff ) {
         return   (Single)  NativeManager.OutboundManifest["IMBItem"]["GetMissileRange"]
        .DynamicInvoke(new object[] {  shot_speed ,  z_diff  } );
    }

    }
}