
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
    public static class NativeParallelDriver {
    
    public delegate void ParalelForLoopBodyCallerDelegate( Int64 loopBodyKey ,  Int32 localStartIndex ,  Int32 localEndIndex );
    private static ParalelForLoopBodyCallerDelegate  _paralelForLoopBodyCaller;
    public static event ParalelForLoopBodyCallerDelegate ParalelForLoopBodyCaller {
        add {
            MethodInfo callback = NativeManager.InboundManifest["NativeParallelDriver"]["ParalelForLoopBodyCaller"].Method;
            MethodInfo patch = typeof(Native.Events.NativeParallelDriver).GetMethod("ParalelForLoopBodyCaller" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _paralelForLoopBodyCaller += value;
        }
        remove {
            NativeManager.UnHook("NativeParallelDriver", "ParalelForLoopBodyCaller");
        }
    }
    private static void ParalelForLoopBodyCallerInternal( Int64 loopBodyKey ,  Int32 localStartIndex ,  Int32 localEndIndex ) =>  NativeParallelDriver. _paralelForLoopBodyCaller?.Invoke( loopBodyKey ,  localStartIndex ,  localEndIndex );
    
    public delegate void ParalelForLoopBodyWithDtCallerDelegate( Int64 loopBodyKey ,  Int32 localStartIndex ,  Int32 localEndIndex );
    private static ParalelForLoopBodyWithDtCallerDelegate  _paralelForLoopBodyWithDtCaller;
    public static event ParalelForLoopBodyWithDtCallerDelegate ParalelForLoopBodyWithDtCaller {
        add {
            MethodInfo callback = NativeManager.InboundManifest["NativeParallelDriver"]["ParalelForLoopBodyWithDtCaller"].Method;
            MethodInfo patch = typeof(Native.Events.NativeParallelDriver).GetMethod("ParalelForLoopBodyWithDtCaller" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _paralelForLoopBodyWithDtCaller += value;
        }
        remove {
            NativeManager.UnHook("NativeParallelDriver", "ParalelForLoopBodyWithDtCaller");
        }
    }
    private static void ParalelForLoopBodyWithDtCallerInternal( Int64 loopBodyKey ,  Int32 localStartIndex ,  Int32 localEndIndex ) =>  NativeParallelDriver. _paralelForLoopBodyWithDtCaller?.Invoke( loopBodyKey ,  localStartIndex ,  localEndIndex );
    
    }
}