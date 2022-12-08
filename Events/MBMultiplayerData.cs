
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
    public static class MBMultiplayerData {
    
    public delegate UIntPtr GetServerIdDelegate();
    private static GetServerIdDelegate  _getServerId;
    public static event GetServerIdDelegate GetServerId {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetServerId"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetServerId" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getServerId += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetServerId");
        }
    }
    private static UIntPtr GetServerIdInternal() =>  (UIntPtr)  MBMultiplayerData. _getServerId?.Invoke();
    
    public delegate UIntPtr GetServerNameDelegate();
    private static GetServerNameDelegate  _getServerName;
    public static event GetServerNameDelegate GetServerName {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetServerName"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetServerName" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getServerName += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetServerName");
        }
    }
    private static UIntPtr GetServerNameInternal() =>  (UIntPtr)  MBMultiplayerData. _getServerName?.Invoke();
    
    public delegate UIntPtr GetGameModuleDelegate();
    private static GetGameModuleDelegate  _getGameModule;
    public static event GetGameModuleDelegate GetGameModule {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetGameModule"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetGameModule" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getGameModule += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetGameModule");
        }
    }
    private static UIntPtr GetGameModuleInternal() =>  (UIntPtr)  MBMultiplayerData. _getGameModule?.Invoke();
    
    public delegate UIntPtr GetGameTypeDelegate();
    private static GetGameTypeDelegate  _getGameType;
    public static event GetGameTypeDelegate GetGameType {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetGameType"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetGameType" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getGameType += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetGameType");
        }
    }
    private static UIntPtr GetGameTypeInternal() =>  (UIntPtr)  MBMultiplayerData. _getGameType?.Invoke();
    
    public delegate UIntPtr GetMapDelegate();
    private static GetMapDelegate  _getMap;
    public static event GetMapDelegate GetMap {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetMap"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetMap" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getMap += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetMap");
        }
    }
    private static UIntPtr GetMapInternal() =>  (UIntPtr)  MBMultiplayerData. _getMap?.Invoke();
    
    public delegate Int32 GetCurrentPlayerCountDelegate();
    private static GetCurrentPlayerCountDelegate  _getCurrentPlayerCount;
    public static event GetCurrentPlayerCountDelegate GetCurrentPlayerCount {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetCurrentPlayerCount"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetCurrentPlayerCount" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getCurrentPlayerCount += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetCurrentPlayerCount");
        }
    }
    private static Int32 GetCurrentPlayerCountInternal() =>  (Int32)  MBMultiplayerData. _getCurrentPlayerCount?.Invoke();
    
    public delegate Int32 GetPlayerCountLimitDelegate();
    private static GetPlayerCountLimitDelegate  _getPlayerCountLimit;
    public static event GetPlayerCountLimitDelegate GetPlayerCountLimit {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["GetPlayerCountLimit"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("GetPlayerCountLimit" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getPlayerCountLimit += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "GetPlayerCountLimit");
        }
    }
    private static Int32 GetPlayerCountLimitInternal() =>  (Int32)  MBMultiplayerData. _getPlayerCountLimit?.Invoke();
    
    public delegate void UpdateGameServerInfoDelegate( IntPtr id ,  IntPtr gameServer ,  IntPtr gameModule ,  IntPtr gameType ,  IntPtr map ,  Int32 currentPlayerCount ,  Int32 maxPlayerCount ,  IntPtr address ,  Int32 port );
    private static UpdateGameServerInfoDelegate  _updateGameServerInfo;
    public static event UpdateGameServerInfoDelegate UpdateGameServerInfo {
        add {
            MethodInfo callback = NativeManager.InboundManifest["MBMultiplayerData"]["UpdateGameServerInfo"].Method;
            MethodInfo patch = typeof(Native.Events.MBMultiplayerData).GetMethod("UpdateGameServerInfo" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _updateGameServerInfo += value;
        }
        remove {
            NativeManager.UnHook("MBMultiplayerData", "UpdateGameServerInfo");
        }
    }
    private static void UpdateGameServerInfoInternal( IntPtr id ,  IntPtr gameServer ,  IntPtr gameModule ,  IntPtr gameType ,  IntPtr map ,  Int32 currentPlayerCount ,  Int32 maxPlayerCount ,  IntPtr address ,  Int32 port ) =>  MBMultiplayerData. _updateGameServerInfo?.Invoke( id ,  gameServer ,  gameModule ,  gameType ,  map ,  currentPlayerCount ,  maxPlayerCount ,  address ,  port );
    
    }
}