
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
    public static class IAsyncTask {
    
    public static NativeObjectPointer CreateWith( Int32 function ,  Boolean isBackground ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IAsyncTask"]["CreateWith"]
        .DynamicInvoke(new object[] {  function ,  isBackground  } );
    }

    public static void Invoke( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IAsyncTask"]["Invoke"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    public static void Wait( UIntPtr Pointer ) {
          NativeManager.OutboundManifest["IAsyncTask"]["Wait"]
        .DynamicInvoke(new object[] {  Pointer  } );
    }

    }
}