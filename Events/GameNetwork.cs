
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
    public static class GameNetwork {
    
    public delegate void HandleRemovePlayerDelegate( Int32 peer ,  Boolean isTimedOut );
    private static HandleRemovePlayerDelegate  _handleRemovePlayer;
    public static event HandleRemovePlayerDelegate HandleRemovePlayer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["HandleRemovePlayer"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("HandleRemovePlayer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleRemovePlayer += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "HandleRemovePlayer");
        }
    }
    private static void HandleRemovePlayerInternal( Int32 peer ,  Boolean isTimedOut ) =>  GameNetwork. _handleRemovePlayer?.Invoke( peer ,  isTimedOut );
    
    public delegate void HandleDisconnectDelegate();
    private static HandleDisconnectDelegate  _handleDisconnect;
    public static event HandleDisconnectDelegate HandleDisconnect {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["HandleDisconnect"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("HandleDisconnect" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleDisconnect += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "HandleDisconnect");
        }
    }
    private static void HandleDisconnectInternal() =>  GameNetwork. _handleDisconnect?.Invoke();
    
    public delegate Boolean HandleNetworkPacketAsServerDelegate( Int32 networkPeer );
    private static HandleNetworkPacketAsServerDelegate  _handleNetworkPacketAsServer;
    public static event HandleNetworkPacketAsServerDelegate HandleNetworkPacketAsServer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["HandleNetworkPacketAsServer"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("HandleNetworkPacketAsServer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleNetworkPacketAsServer += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "HandleNetworkPacketAsServer");
        }
    }
    private static Boolean HandleNetworkPacketAsServerInternal( Int32 networkPeer ) =>  (Boolean)  GameNetwork. _handleNetworkPacketAsServer?.Invoke( networkPeer );
    
    public delegate void HandleConsoleCommandDelegate( IntPtr command );
    private static HandleConsoleCommandDelegate  _handleConsoleCommand;
    public static event HandleConsoleCommandDelegate HandleConsoleCommand {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["HandleConsoleCommand"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("HandleConsoleCommand" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleConsoleCommand += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "HandleConsoleCommand");
        }
    }
    private static void HandleConsoleCommandInternal( IntPtr command ) =>  GameNetwork. _handleConsoleCommand?.Invoke( command );
    
    public delegate Boolean HandleNetworkPacketAsClientDelegate();
    private static HandleNetworkPacketAsClientDelegate  _handleNetworkPacketAsClient;
    public static event HandleNetworkPacketAsClientDelegate HandleNetworkPacketAsClient {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["HandleNetworkPacketAsClient"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("HandleNetworkPacketAsClient" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleNetworkPacketAsClient += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "HandleNetworkPacketAsClient");
        }
    }
    private static Boolean HandleNetworkPacketAsClientInternal() =>  (Boolean)  GameNetwork. _handleNetworkPacketAsClient?.Invoke();
    
    public delegate void SyncRelevantGameOptionsToServerDelegate();
    private static SyncRelevantGameOptionsToServerDelegate  _syncRelevantGameOptionsToServer;
    public static event SyncRelevantGameOptionsToServerDelegate SyncRelevantGameOptionsToServer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["GameNetwork"]["SyncRelevantGameOptionsToServer"].Method;
            MethodInfo patch = typeof(Native.Events.GameNetwork).GetMethod("SyncRelevantGameOptionsToServer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _syncRelevantGameOptionsToServer += value;
        }
        remove {
            NativeManager.UnHook("GameNetwork", "SyncRelevantGameOptionsToServer");
        }
    }
    private static void SyncRelevantGameOptionsToServerInternal() =>  GameNetwork. _syncRelevantGameOptionsToServer?.Invoke();
    
    }
}