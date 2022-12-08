
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
    public static class IManaged {
    
    public static void IncreaseReferenceCount( UIntPtr ptr ) {
          NativeManager.OutboundManifest["IManaged"]["IncreaseReferenceCount"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static void DecreaseReferenceCount( UIntPtr ptr ) {
          NativeManager.OutboundManifest["IManaged"]["DecreaseReferenceCount"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    public static Int32 GetClassTypeDefinitionCount() {
         return   (Int32)  NativeManager.OutboundManifest["IManaged"]["GetClassTypeDefinitionCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetClassTypeDefinition( Int32 index ,   ref EngineClassTypeDefinition engineClassTypeDefinition ) {
          NativeManager.OutboundManifest["IManaged"]["GetClassTypeDefinition"]
        .DynamicInvoke(new object[] {  index ,  engineClassTypeDefinition  } );
    }

    public static void ReleaseManagedObject( UIntPtr ptr ) {
          NativeManager.OutboundManifest["IManaged"]["ReleaseManagedObject"]
        .DynamicInvoke(new object[] {  ptr  } );
    }

    }
}