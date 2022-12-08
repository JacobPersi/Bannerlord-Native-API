
using System;
using System.Reflection;
using HarmonyLib;

using TaleWorlds.Library;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using static TaleWorlds.MountAndBlade.Agent;
using static TaleWorlds.MountAndBlade.Mission;

namespace BannerlordUnlocked.Native.Events {
    public static class ThumbnailCreatorView {
    
    public delegate void OnThumbnailRenderCompleteDelegate( IntPtr renderId ,  NativeObjectPointer renderTarget );
    private static OnThumbnailRenderCompleteDelegate  _onThumbnailRenderComplete;
    public static event OnThumbnailRenderCompleteDelegate OnThumbnailRenderComplete {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ThumbnailCreatorView"]["OnThumbnailRenderComplete"].Method;
            MethodInfo patch = typeof(Native.Events.ThumbnailCreatorView).GetMethod("OnThumbnailRenderComplete" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onThumbnailRenderComplete += value;
        }
        remove {
            NativeManager.UnHook("ThumbnailCreatorView", "OnThumbnailRenderComplete");
        }
    }
    private static void OnThumbnailRenderCompleteInternal( IntPtr renderId ,  NativeObjectPointer renderTarget ) =>  ThumbnailCreatorView. _onThumbnailRenderComplete?.Invoke( renderId ,  renderTarget );
    
    }
}