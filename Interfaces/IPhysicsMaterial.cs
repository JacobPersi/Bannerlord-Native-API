
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
    public static class IPhysicsMaterial {
    
    public static PhysicsMaterial GetIndexWithName( Byte[] materialName ) {
         return   (PhysicsMaterial)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetIndexWithName"]
        .DynamicInvoke(new object[] {  materialName  } );
    }

    public static Int32 GetMaterialCount() {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetMaterialCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetMaterialNameAtIndex( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetMaterialNameAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static PhysicsMaterialFlags GetFlagsAtIndex( Int32 index ) {
         return   (PhysicsMaterialFlags)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetFlagsAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Single GetRestitutionAtIndex( Int32 index ) {
         return   (Single)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetRestitutionAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Single GetDynamicFrictionAtIndex( Int32 index ) {
         return   (Single)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetDynamicFrictionAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Single GetStaticFrictionAtIndex( Int32 index ) {
         return   (Single)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetStaticFrictionAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Single GetSoftnessAtIndex( Int32 index ) {
         return   (Single)  NativeManager.OutboundManifest["IPhysicsMaterial"]["GetSoftnessAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    }
}