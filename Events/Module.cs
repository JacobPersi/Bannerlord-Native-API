
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
    public static class Module {
    
    public delegate void InitializeDelegate( Int32 thisPointer );
    private static InitializeDelegate  _initialize;
    public static event InitializeDelegate Initialize {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["Initialize"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("Initialize" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _initialize += value;
        }
        remove {
            NativeManager.UnHook("Module", "Initialize");
        }
    }
    private static void InitializeInternal( Int32 thisPointer ) =>  Module. _initialize?.Invoke( thisPointer );
    
    public delegate void RunTestDelegate( Int32 thisPointer ,  IntPtr commandLine );
    private static RunTestDelegate  _runTest;
    public static event RunTestDelegate RunTest {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["RunTest"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("RunTest" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _runTest += value;
        }
        remove {
            NativeManager.UnHook("Module", "RunTest");
        }
    }
    private static void RunTestInternal( Int32 thisPointer ,  IntPtr commandLine ) =>  Module. _runTest?.Invoke( thisPointer ,  commandLine );
    
    public delegate void TickTestDelegate( Int32 thisPointer ,  Single dt );
    private static TickTestDelegate  _tickTest;
    public static event TickTestDelegate TickTest {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["TickTest"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("TickTest" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _tickTest += value;
        }
        remove {
            NativeManager.UnHook("Module", "TickTest");
        }
    }
    private static void TickTestInternal( Int32 thisPointer ,  Single dt ) =>  Module. _tickTest?.Invoke( thisPointer ,  dt );
    
    public delegate void OnDumpCreatedDelegate( Int32 thisPointer );
    private static OnDumpCreatedDelegate  _onDumpCreated;
    public static event OnDumpCreatedDelegate OnDumpCreated {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnDumpCreated"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnDumpCreated" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onDumpCreated += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnDumpCreated");
        }
    }
    private static void OnDumpCreatedInternal( Int32 thisPointer ) =>  Module. _onDumpCreated?.Invoke( thisPointer );
    
    public delegate void OnDumpCreationStartedDelegate( Int32 thisPointer );
    private static OnDumpCreationStartedDelegate  _onDumpCreationStarted;
    public static event OnDumpCreationStartedDelegate OnDumpCreationStarted {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnDumpCreationStarted"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnDumpCreationStarted" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onDumpCreationStarted += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnDumpCreationStarted");
        }
    }
    private static void OnDumpCreationStartedInternal( Int32 thisPointer ) =>  Module. _onDumpCreationStarted?.Invoke( thisPointer );
    
    public delegate UIntPtr GetMetaMeshPackageMappingDelegate( Int32 thisPointer );
    private static GetMetaMeshPackageMappingDelegate  _getMetaMeshPackageMapping;
    public static event GetMetaMeshPackageMappingDelegate GetMetaMeshPackageMapping {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetMetaMeshPackageMapping"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetMetaMeshPackageMapping" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getMetaMeshPackageMapping += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetMetaMeshPackageMapping");
        }
    }
    private static UIntPtr GetMetaMeshPackageMappingInternal( Int32 thisPointer ) =>  (UIntPtr)  Module. _getMetaMeshPackageMapping?.Invoke( thisPointer );
    
    public delegate UIntPtr GetItemMeshNamesDelegate( Int32 thisPointer );
    private static GetItemMeshNamesDelegate  _getItemMeshNames;
    public static event GetItemMeshNamesDelegate GetItemMeshNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetItemMeshNames"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetItemMeshNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getItemMeshNames += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetItemMeshNames");
        }
    }
    private static UIntPtr GetItemMeshNamesInternal( Int32 thisPointer ) =>  (UIntPtr)  Module. _getItemMeshNames?.Invoke( thisPointer );
    
    public delegate UIntPtr GetHorseMaterialNamesDelegate( Int32 thisPointer );
    private static GetHorseMaterialNamesDelegate  _getHorseMaterialNames;
    public static event GetHorseMaterialNamesDelegate GetHorseMaterialNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetHorseMaterialNames"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetHorseMaterialNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getHorseMaterialNames += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetHorseMaterialNames");
        }
    }
    private static UIntPtr GetHorseMaterialNamesInternal( Int32 thisPointer ) =>  (UIntPtr)  Module. _getHorseMaterialNames?.Invoke( thisPointer );
    
    public delegate Boolean SetEditorScreenAsRootScreenDelegate( Int32 thisPointer );
    private static SetEditorScreenAsRootScreenDelegate  _setEditorScreenAsRootScreen;
    public static event SetEditorScreenAsRootScreenDelegate SetEditorScreenAsRootScreen {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["SetEditorScreenAsRootScreen"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("SetEditorScreenAsRootScreen" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setEditorScreenAsRootScreen += value;
        }
        remove {
            NativeManager.UnHook("Module", "SetEditorScreenAsRootScreen");
        }
    }
    private static Boolean SetEditorScreenAsRootScreenInternal( Int32 thisPointer ) =>  (Boolean)  Module. _setEditorScreenAsRootScreen?.Invoke( thisPointer );
    
    public delegate UIntPtr GetMissionControllerClassNamesDelegate( Int32 thisPointer );
    private static GetMissionControllerClassNamesDelegate  _getMissionControllerClassNames;
    public static event GetMissionControllerClassNamesDelegate GetMissionControllerClassNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetMissionControllerClassNames"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetMissionControllerClassNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getMissionControllerClassNames += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetMissionControllerClassNames");
        }
    }
    private static UIntPtr GetMissionControllerClassNamesInternal( Int32 thisPointer ) =>  (UIntPtr)  Module. _getMissionControllerClassNames?.Invoke( thisPointer );
    
    public delegate void MBThrowExceptionDelegate();
    private static MBThrowExceptionDelegate  _mBThrowException;
    public static event MBThrowExceptionDelegate MBThrowException {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["MBThrowException"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("MBThrowException" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _mBThrowException += value;
        }
        remove {
            NativeManager.UnHook("Module", "MBThrowException");
        }
    }
    private static void MBThrowExceptionInternal() =>  Module. _mBThrowException?.Invoke();
    
    public delegate void OnEnterEditModeDelegate( Int32 thisPointer ,  Boolean isFirstTime );
    private static OnEnterEditModeDelegate  _onEnterEditMode;
    public static event OnEnterEditModeDelegate OnEnterEditMode {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnEnterEditMode"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnEnterEditMode" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEnterEditMode += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnEnterEditMode");
        }
    }
    private static void OnEnterEditModeInternal( Int32 thisPointer ,  Boolean isFirstTime ) =>  Module. _onEnterEditMode?.Invoke( thisPointer ,  isFirstTime );
    
    public delegate Int32 GetInstanceDelegate();
    private static GetInstanceDelegate  _getInstance;
    public static event GetInstanceDelegate GetInstance {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetInstance"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetInstance" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getInstance += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetInstance");
        }
    }
    private static Int32 GetInstanceInternal() =>  (Int32)  Module. _getInstance?.Invoke();
    
    public delegate UIntPtr GetGameStatusDelegate();
    private static GetGameStatusDelegate  _getGameStatus;
    public static event GetGameStatusDelegate GetGameStatus {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["GetGameStatus"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("GetGameStatus" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getGameStatus += value;
        }
        remove {
            NativeManager.UnHook("Module", "GetGameStatus");
        }
    }
    private static UIntPtr GetGameStatusInternal() =>  (UIntPtr)  Module. _getGameStatus?.Invoke();
    
    public delegate void SetLoadingFinishedDelegate( Int32 thisPointer );
    private static SetLoadingFinishedDelegate  _setLoadingFinished;
    public static event SetLoadingFinishedDelegate SetLoadingFinished {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["SetLoadingFinished"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("SetLoadingFinished" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setLoadingFinished += value;
        }
        remove {
            NativeManager.UnHook("Module", "SetLoadingFinished");
        }
    }
    private static void SetLoadingFinishedInternal( Int32 thisPointer ) =>  Module. _setLoadingFinished?.Invoke( thisPointer );
    
    public delegate void OnCloseSceneEditorPresentationDelegate( Int32 thisPointer );
    private static OnCloseSceneEditorPresentationDelegate  _onCloseSceneEditorPresentation;
    public static event OnCloseSceneEditorPresentationDelegate OnCloseSceneEditorPresentation {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnCloseSceneEditorPresentation"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnCloseSceneEditorPresentation" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onCloseSceneEditorPresentation += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnCloseSceneEditorPresentation");
        }
    }
    private static void OnCloseSceneEditorPresentationInternal( Int32 thisPointer ) =>  Module. _onCloseSceneEditorPresentation?.Invoke( thisPointer );
    
    public delegate void OnSceneEditorModeOverDelegate( Int32 thisPointer );
    private static OnSceneEditorModeOverDelegate  _onSceneEditorModeOver;
    public static event OnSceneEditorModeOverDelegate OnSceneEditorModeOver {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnSceneEditorModeOver"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnSceneEditorModeOver" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onSceneEditorModeOver += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnSceneEditorModeOver");
        }
    }
    private static void OnSceneEditorModeOverInternal( Int32 thisPointer ) =>  Module. _onSceneEditorModeOver?.Invoke( thisPointer );
    
    public delegate void OnSkinsXMLHasChangedDelegate( Int32 thisPointer );
    private static OnSkinsXMLHasChangedDelegate  _onSkinsXMLHasChanged;
    public static event OnSkinsXMLHasChangedDelegate OnSkinsXMLHasChanged {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnSkinsXMLHasChanged"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnSkinsXMLHasChanged" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onSkinsXMLHasChanged += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnSkinsXMLHasChanged");
        }
    }
    private static void OnSkinsXMLHasChangedInternal( Int32 thisPointer ) =>  Module. _onSkinsXMLHasChanged?.Invoke( thisPointer );
    
    public delegate void OnImguiProfilerTickDelegate( Int32 thisPointer );
    private static OnImguiProfilerTickDelegate  _onImguiProfilerTick;
    public static event OnImguiProfilerTickDelegate OnImguiProfilerTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["OnImguiProfilerTick"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("OnImguiProfilerTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onImguiProfilerTick += value;
        }
        remove {
            NativeManager.UnHook("Module", "OnImguiProfilerTick");
        }
    }
    private static void OnImguiProfilerTickInternal( Int32 thisPointer ) =>  Module. _onImguiProfilerTick?.Invoke( thisPointer );
    
    public delegate UIntPtr CreateProcessedSkinsXMLForNativeDelegate(  ref String baseSkinsXmlPath );
    private static CreateProcessedSkinsXMLForNativeDelegate  _createProcessedSkinsXMLForNative;
    public static event CreateProcessedSkinsXMLForNativeDelegate CreateProcessedSkinsXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedSkinsXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedSkinsXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedSkinsXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedSkinsXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedSkinsXMLForNativeInternal(  ref String baseSkinsXmlPath ) =>  (UIntPtr)  Module. _createProcessedSkinsXMLForNative?.Invoke( ref baseSkinsXmlPath );
    
    public delegate UIntPtr CreateProcessedActionSetsXMLForNativeDelegate();
    private static CreateProcessedActionSetsXMLForNativeDelegate  _createProcessedActionSetsXMLForNative;
    public static event CreateProcessedActionSetsXMLForNativeDelegate CreateProcessedActionSetsXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedActionSetsXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedActionSetsXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedActionSetsXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedActionSetsXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedActionSetsXMLForNativeInternal() =>  (UIntPtr)  Module. _createProcessedActionSetsXMLForNative?.Invoke();
    
    public delegate UIntPtr CreateProcessedActionTypesXMLForNativeDelegate();
    private static CreateProcessedActionTypesXMLForNativeDelegate  _createProcessedActionTypesXMLForNative;
    public static event CreateProcessedActionTypesXMLForNativeDelegate CreateProcessedActionTypesXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedActionTypesXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedActionTypesXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedActionTypesXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedActionTypesXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedActionTypesXMLForNativeInternal() =>  (UIntPtr)  Module. _createProcessedActionTypesXMLForNative?.Invoke();
    
    public delegate UIntPtr CreateProcessedAnimationsXMLForNativeDelegate(  ref String animationsXmlPaths );
    private static CreateProcessedAnimationsXMLForNativeDelegate  _createProcessedAnimationsXMLForNative;
    public static event CreateProcessedAnimationsXMLForNativeDelegate CreateProcessedAnimationsXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedAnimationsXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedAnimationsXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedAnimationsXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedAnimationsXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedAnimationsXMLForNativeInternal(  ref String animationsXmlPaths ) =>  (UIntPtr)  Module. _createProcessedAnimationsXMLForNative?.Invoke( ref animationsXmlPaths );
    
    public delegate UIntPtr CreateProcessedVoiceDefinitionsXMLForNativeDelegate();
    private static CreateProcessedVoiceDefinitionsXMLForNativeDelegate  _createProcessedVoiceDefinitionsXMLForNative;
    public static event CreateProcessedVoiceDefinitionsXMLForNativeDelegate CreateProcessedVoiceDefinitionsXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedVoiceDefinitionsXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedVoiceDefinitionsXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedVoiceDefinitionsXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedVoiceDefinitionsXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedVoiceDefinitionsXMLForNativeInternal() =>  (UIntPtr)  Module. _createProcessedVoiceDefinitionsXMLForNative?.Invoke();
    
    public delegate UIntPtr CreateProcessedModuleDataXMLForNativeDelegate( IntPtr xmlType );
    private static CreateProcessedModuleDataXMLForNativeDelegate  _createProcessedModuleDataXMLForNative;
    public static event CreateProcessedModuleDataXMLForNativeDelegate CreateProcessedModuleDataXMLForNative {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["CreateProcessedModuleDataXMLForNative"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("CreateProcessedModuleDataXMLForNative" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createProcessedModuleDataXMLForNative += value;
        }
        remove {
            NativeManager.UnHook("Module", "CreateProcessedModuleDataXMLForNative");
        }
    }
    private static UIntPtr CreateProcessedModuleDataXMLForNativeInternal( IntPtr xmlType ) =>  (UIntPtr)  Module. _createProcessedModuleDataXMLForNative?.Invoke( xmlType );
    
    public delegate void StartMissionForEditorDelegate( Int32 thisPointer ,  IntPtr missionName ,  IntPtr sceneName ,  IntPtr levels );
    private static StartMissionForEditorDelegate  _startMissionForEditor;
    public static event StartMissionForEditorDelegate StartMissionForEditor {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["StartMissionForEditor"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("StartMissionForEditor" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _startMissionForEditor += value;
        }
        remove {
            NativeManager.UnHook("Module", "StartMissionForEditor");
        }
    }
    private static void StartMissionForEditorInternal( Int32 thisPointer ,  IntPtr missionName ,  IntPtr sceneName ,  IntPtr levels ) =>  Module. _startMissionForEditor?.Invoke( thisPointer ,  missionName ,  sceneName ,  levels );
    
    public delegate void StartMissionForReplayEditorDelegate( Int32 thisPointer ,  IntPtr missionName ,  IntPtr sceneName ,  IntPtr levels ,  IntPtr fileName ,  Boolean record ,  Single startTime ,  Single endTime );
    private static StartMissionForReplayEditorDelegate  _startMissionForReplayEditor;
    public static event StartMissionForReplayEditorDelegate StartMissionForReplayEditor {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Module"]["StartMissionForReplayEditor"].Method;
            MethodInfo patch = typeof(Native.Events.Module).GetMethod("StartMissionForReplayEditor" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _startMissionForReplayEditor += value;
        }
        remove {
            NativeManager.UnHook("Module", "StartMissionForReplayEditor");
        }
    }
    private static void StartMissionForReplayEditorInternal( Int32 thisPointer ,  IntPtr missionName ,  IntPtr sceneName ,  IntPtr levels ,  IntPtr fileName ,  Boolean record ,  Single startTime ,  Single endTime ) =>  Module. _startMissionForReplayEditor?.Invoke( thisPointer ,  missionName ,  sceneName ,  levels ,  fileName ,  record ,  startTime ,  endTime );
    
    }
}