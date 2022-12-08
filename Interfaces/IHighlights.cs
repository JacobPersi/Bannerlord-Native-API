
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
    public static class IHighlights {
    
    public static void Initialize() {
          NativeManager.OutboundManifest["IHighlights"]["Initialize"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void OpenGroup( Byte[] id ) {
          NativeManager.OutboundManifest["IHighlights"]["OpenGroup"]
        .DynamicInvoke(new object[] {  id  } );
    }

    public static void CloseGroup( Byte[] id ,  Boolean destroy ) {
          NativeManager.OutboundManifest["IHighlights"]["CloseGroup"]
        .DynamicInvoke(new object[] {  id ,  destroy  } );
    }

    public static void SaveScreenshot( Byte[] highlightId ,  Byte[] groupId ) {
          NativeManager.OutboundManifest["IHighlights"]["SaveScreenshot"]
        .DynamicInvoke(new object[] {  highlightId ,  groupId  } );
    }

    public static void SaveVideo( Byte[] highlightId ,  Byte[] groupId ,  Int32 startDelta ,  Int32 endDelta ) {
          NativeManager.OutboundManifest["IHighlights"]["SaveVideo"]
        .DynamicInvoke(new object[] {  highlightId ,  groupId ,  startDelta ,  endDelta  } );
    }

    public static void OpenSummary( Byte[] groups ) {
          NativeManager.OutboundManifest["IHighlights"]["OpenSummary"]
        .DynamicInvoke(new object[] {  groups  } );
    }

    public static void AddHighlight( Byte[] id ,  Byte[] name ) {
          NativeManager.OutboundManifest["IHighlights"]["AddHighlight"]
        .DynamicInvoke(new object[] {  id ,  name  } );
    }

    public static void RemoveHighlight( Byte[] id ) {
          NativeManager.OutboundManifest["IHighlights"]["RemoveHighlight"]
        .DynamicInvoke(new object[] {  id  } );
    }

    }
}