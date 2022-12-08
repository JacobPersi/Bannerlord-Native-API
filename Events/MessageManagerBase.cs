
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
    public static class MessageManagerBase {
    
    public delegate void PostWarningLineDelegate( Int32 thisPointer ,  IntPtr text );
    private static PostWarningLineDelegate  _postWarningLine;
    public static event PostWarningLineDelegate PostWarningLine {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MessageManagerBase"]["PostWarningLine"].Method;
            MethodInfo patch = typeof(Native.Events.MessageManagerBase).GetMethod("PostWarningLine" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _postWarningLine += value;
        }
        remove {
            NativeManager.UnHook("MessageManagerBase", "PostWarningLine");
        }
    }
    private static void PostWarningLineInternal( Int32 thisPointer ,  IntPtr text ) =>  MessageManagerBase. _postWarningLine?.Invoke( thisPointer ,  text );
    
    public delegate void PostSuccessLineDelegate( Int32 thisPointer ,  IntPtr text );
    private static PostSuccessLineDelegate  _postSuccessLine;
    public static event PostSuccessLineDelegate PostSuccessLine {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MessageManagerBase"]["PostSuccessLine"].Method;
            MethodInfo patch = typeof(Native.Events.MessageManagerBase).GetMethod("PostSuccessLine" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _postSuccessLine += value;
        }
        remove {
            NativeManager.UnHook("MessageManagerBase", "PostSuccessLine");
        }
    }
    private static void PostSuccessLineInternal( Int32 thisPointer ,  IntPtr text ) =>  MessageManagerBase. _postSuccessLine?.Invoke( thisPointer ,  text );
    
    public delegate void PostMessageLineFormattedDelegate( Int32 thisPointer ,  IntPtr text ,  UInt32 color );
    private static PostMessageLineFormattedDelegate  _postMessageLineFormatted;
    public static event PostMessageLineFormattedDelegate PostMessageLineFormatted {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MessageManagerBase"]["PostMessageLineFormatted"].Method;
            MethodInfo patch = typeof(Native.Events.MessageManagerBase).GetMethod("PostMessageLineFormatted" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _postMessageLineFormatted += value;
        }
        remove {
            NativeManager.UnHook("MessageManagerBase", "PostMessageLineFormatted");
        }
    }
    private static void PostMessageLineFormattedInternal( Int32 thisPointer ,  IntPtr text ,  UInt32 color ) =>  MessageManagerBase. _postMessageLineFormatted?.Invoke( thisPointer ,  text ,  color );
    
    public delegate void PostMessageLineDelegate( Int32 thisPointer ,  IntPtr text ,  UInt32 color );
    private static PostMessageLineDelegate  _postMessageLine;
    public static event PostMessageLineDelegate PostMessageLine {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MessageManagerBase"]["PostMessageLine"].Method;
            MethodInfo patch = typeof(Native.Events.MessageManagerBase).GetMethod("PostMessageLine" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _postMessageLine += value;
        }
        remove {
            NativeManager.UnHook("MessageManagerBase", "PostMessageLine");
        }
    }
    private static void PostMessageLineInternal( Int32 thisPointer ,  IntPtr text ,  UInt32 color ) =>  MessageManagerBase. _postMessageLine?.Invoke( thisPointer ,  text ,  color );
    
    }
}