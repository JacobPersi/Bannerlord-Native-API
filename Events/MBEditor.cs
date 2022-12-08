
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
    public static class MBEditor {
    
    public delegate void SetEditorSceneDelegate( NativeObjectPointer scene );
    private static SetEditorSceneDelegate  _setEditorScene;
    public static event SetEditorSceneDelegate SetEditorScene {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBEditor"]["SetEditorScene"].Method;
            MethodInfo patch = typeof(Native.Events.MBEditor).GetMethod("SetEditorScene" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setEditorScene += value;
        }
        remove {
            NativeManager.UnHook("MBEditor", "SetEditorScene");
        }
    }
    private static void SetEditorSceneInternal( NativeObjectPointer scene ) =>  MBEditor. _setEditorScene?.Invoke( scene );
    
    public delegate void CloseEditorSceneDelegate();
    private static CloseEditorSceneDelegate  _closeEditorScene;
    public static event CloseEditorSceneDelegate CloseEditorScene {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBEditor"]["CloseEditorScene"].Method;
            MethodInfo patch = typeof(Native.Events.MBEditor).GetMethod("CloseEditorScene" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _closeEditorScene += value;
        }
        remove {
            NativeManager.UnHook("MBEditor", "CloseEditorScene");
        }
    }
    private static void CloseEditorSceneInternal() =>  MBEditor. _closeEditorScene?.Invoke();
    
    public delegate void DestroyEditorDelegate( NativeObjectPointer scene );
    private static DestroyEditorDelegate  _destroyEditor;
    public static event DestroyEditorDelegate DestroyEditor {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBEditor"]["DestroyEditor"].Method;
            MethodInfo patch = typeof(Native.Events.MBEditor).GetMethod("DestroyEditor" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _destroyEditor += value;
        }
        remove {
            NativeManager.UnHook("MBEditor", "DestroyEditor");
        }
    }
    private static void DestroyEditorInternal( NativeObjectPointer scene ) =>  MBEditor. _destroyEditor?.Invoke( scene );
    
    }
}