
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
    public static class ManagedScriptHolder {
    
    public delegate Int32 CreateManagedScriptHolderDelegate();
    private static CreateManagedScriptHolderDelegate  _createManagedScriptHolder;
    public static event CreateManagedScriptHolderDelegate CreateManagedScriptHolder {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["CreateManagedScriptHolder"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("CreateManagedScriptHolder" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createManagedScriptHolder += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "CreateManagedScriptHolder");
        }
    }
    private static Int32 CreateManagedScriptHolderInternal() =>  (Int32)  ManagedScriptHolder. _createManagedScriptHolder?.Invoke();
    
    public delegate void SetScriptComponentHolderDelegate( Int32 thisPointer ,  Int32 sc );
    private static SetScriptComponentHolderDelegate  _setScriptComponentHolder;
    public static event SetScriptComponentHolderDelegate SetScriptComponentHolder {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["SetScriptComponentHolder"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("SetScriptComponentHolder" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setScriptComponentHolder += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "SetScriptComponentHolder");
        }
    }
    private static void SetScriptComponentHolderInternal( Int32 thisPointer ,  Int32 sc ) =>  ManagedScriptHolder. _setScriptComponentHolder?.Invoke( thisPointer ,  sc );
    
    public delegate void RemoveScriptComponentFromAllTickListsDelegate( Int32 thisPointer ,  Int32 sc );
    private static RemoveScriptComponentFromAllTickListsDelegate  _removeScriptComponentFromAllTickLists;
    public static event RemoveScriptComponentFromAllTickListsDelegate RemoveScriptComponentFromAllTickLists {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["RemoveScriptComponentFromAllTickLists"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("RemoveScriptComponentFromAllTickLists" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _removeScriptComponentFromAllTickLists += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "RemoveScriptComponentFromAllTickLists");
        }
    }
    private static void RemoveScriptComponentFromAllTickListsInternal( Int32 thisPointer ,  Int32 sc ) =>  ManagedScriptHolder. _removeScriptComponentFromAllTickLists?.Invoke( thisPointer ,  sc );
    
    public delegate Int32 GetNumberOfScriptsDelegate( Int32 thisPointer );
    private static GetNumberOfScriptsDelegate  _getNumberOfScripts;
    public static event GetNumberOfScriptsDelegate GetNumberOfScripts {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["GetNumberOfScripts"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("GetNumberOfScripts" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getNumberOfScripts += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "GetNumberOfScripts");
        }
    }
    private static Int32 GetNumberOfScriptsInternal( Int32 thisPointer ) =>  (Int32)  ManagedScriptHolder. _getNumberOfScripts?.Invoke( thisPointer );
    
    public delegate void TickComponentsDelegate( Int32 thisPointer ,  Single dt );
    private static TickComponentsDelegate  _tickComponents;
    public static event TickComponentsDelegate TickComponents {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["TickComponents"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("TickComponents" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _tickComponents += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "TickComponents");
        }
    }
    private static void TickComponentsInternal( Int32 thisPointer ,  Single dt ) =>  ManagedScriptHolder. _tickComponents?.Invoke( thisPointer ,  dt );
    
    public delegate void TickComponentsEditorDelegate( Int32 thisPointer ,  Single dt );
    private static TickComponentsEditorDelegate  _tickComponentsEditor;
    public static event TickComponentsEditorDelegate TickComponentsEditor {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedScriptHolder"]["TickComponentsEditor"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedScriptHolder).GetMethod("TickComponentsEditor" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _tickComponentsEditor += value;
        }
        remove {
            NativeManager.UnHook("ManagedScriptHolder", "TickComponentsEditor");
        }
    }
    private static void TickComponentsEditorInternal( Int32 thisPointer ,  Single dt ) =>  ManagedScriptHolder. _tickComponentsEditor?.Invoke( thisPointer ,  dt );
    
    }
}