
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
    public static class ManagedDelegate {
    
    public delegate void InvokeAuxDelegate( Int32 thisPointer );
    private static InvokeAuxDelegate  _invokeAux;
    public static event InvokeAuxDelegate InvokeAux {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedDelegate"]["InvokeAux"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedDelegate).GetMethod("InvokeAux" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _invokeAux += value;
        }
        remove {
            NativeManager.UnHook("ManagedDelegate", "InvokeAux");
        }
    }
    private static void InvokeAuxInternal( Int32 thisPointer ) =>  ManagedDelegate. _invokeAux?.Invoke( thisPointer );
    
    }
}