
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
    public static class RenderTargetComponent {
    
    public delegate Int32 CreateRenderTargetComponentDelegate( NativeObjectPointer renderTarget );
    private static CreateRenderTargetComponentDelegate  _createRenderTargetComponent;
    public static event CreateRenderTargetComponentDelegate CreateRenderTargetComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["RenderTargetComponent"]["CreateRenderTargetComponent"].Method;
            MethodInfo patch = typeof(Native.Events.RenderTargetComponent).GetMethod("CreateRenderTargetComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createRenderTargetComponent += value;
        }
        remove {
            NativeManager.UnHook("RenderTargetComponent", "CreateRenderTargetComponent");
        }
    }
    private static Int32 CreateRenderTargetComponentInternal( NativeObjectPointer renderTarget ) =>  (Int32)  RenderTargetComponent. _createRenderTargetComponent?.Invoke( renderTarget );
    
    public delegate void OnPaintNeededDelegate( Int32 thisPointer );
    private static OnPaintNeededDelegate  _onPaintNeeded;
    public static event OnPaintNeededDelegate OnPaintNeeded {
        add {
            MethodInfo callback = NativeManager.InboundManifest["RenderTargetComponent"]["OnPaintNeeded"].Method;
            MethodInfo patch = typeof(Native.Events.RenderTargetComponent).GetMethod("OnPaintNeeded" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onPaintNeeded += value;
        }
        remove {
            NativeManager.UnHook("RenderTargetComponent", "OnPaintNeeded");
        }
    }
    private static void OnPaintNeededInternal( Int32 thisPointer ) =>  RenderTargetComponent. _onPaintNeeded?.Invoke( thisPointer );
    
    }
}