
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
    public static class ScriptComponentBehavior {
    
    public delegate void AddScriptComponentToTickDelegate( Int32 thisPointer );
    private static AddScriptComponentToTickDelegate  _addScriptComponentToTick;
    public static event AddScriptComponentToTickDelegate AddScriptComponentToTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["AddScriptComponentToTick"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("AddScriptComponentToTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _addScriptComponentToTick += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "AddScriptComponentToTick");
        }
    }
    private static void AddScriptComponentToTickInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _addScriptComponentToTick?.Invoke( thisPointer );
    
    public delegate void RegisterAsPrefabScriptComponentDelegate( Int32 thisPointer );
    private static RegisterAsPrefabScriptComponentDelegate  _registerAsPrefabScriptComponent;
    public static event RegisterAsPrefabScriptComponentDelegate RegisterAsPrefabScriptComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["RegisterAsPrefabScriptComponent"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("RegisterAsPrefabScriptComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _registerAsPrefabScriptComponent += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "RegisterAsPrefabScriptComponent");
        }
    }
    private static void RegisterAsPrefabScriptComponentInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _registerAsPrefabScriptComponent?.Invoke( thisPointer );
    
    public delegate void DeregisterAsPrefabScriptComponentDelegate( Int32 thisPointer );
    private static DeregisterAsPrefabScriptComponentDelegate  _deregisterAsPrefabScriptComponent;
    public static event DeregisterAsPrefabScriptComponentDelegate DeregisterAsPrefabScriptComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["DeregisterAsPrefabScriptComponent"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("DeregisterAsPrefabScriptComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _deregisterAsPrefabScriptComponent += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "DeregisterAsPrefabScriptComponent");
        }
    }
    private static void DeregisterAsPrefabScriptComponentInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _deregisterAsPrefabScriptComponent?.Invoke( thisPointer );
    
    public delegate void RegisterAsUndoStackScriptComponentDelegate( Int32 thisPointer );
    private static RegisterAsUndoStackScriptComponentDelegate  _registerAsUndoStackScriptComponent;
    public static event RegisterAsUndoStackScriptComponentDelegate RegisterAsUndoStackScriptComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["RegisterAsUndoStackScriptComponent"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("RegisterAsUndoStackScriptComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _registerAsUndoStackScriptComponent += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "RegisterAsUndoStackScriptComponent");
        }
    }
    private static void RegisterAsUndoStackScriptComponentInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _registerAsUndoStackScriptComponent?.Invoke( thisPointer );
    
    public delegate void DeregisterAsUndoStackScriptComponentDelegate( Int32 thisPointer );
    private static DeregisterAsUndoStackScriptComponentDelegate  _deregisterAsUndoStackScriptComponent;
    public static event DeregisterAsUndoStackScriptComponentDelegate DeregisterAsUndoStackScriptComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["DeregisterAsUndoStackScriptComponent"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("DeregisterAsUndoStackScriptComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _deregisterAsUndoStackScriptComponent += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "DeregisterAsUndoStackScriptComponent");
        }
    }
    private static void DeregisterAsUndoStackScriptComponentInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _deregisterAsUndoStackScriptComponent?.Invoke( thisPointer );
    
    public delegate void SetSceneDelegate( Int32 thisPointer ,  NativeObjectPointer scene );
    private static SetSceneDelegate  _setScene;
    public static event SetSceneDelegate SetScene {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["SetScene"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("SetScene" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setScene += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "SetScene");
        }
    }
    private static void SetSceneInternal( Int32 thisPointer ,  NativeObjectPointer scene ) =>  ScriptComponentBehavior. _setScene?.Invoke( thisPointer ,  scene );
    
    public delegate void OnInitDelegate( Int32 thisPointer );
    private static OnInitDelegate  _onInit;
    public static event OnInitDelegate OnInit {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnInit"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnInit" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onInit += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnInit");
        }
    }
    private static void OnInitInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _onInit?.Invoke( thisPointer );
    
    public delegate void HandleOnRemovedDelegate( Int32 thisPointer ,  Int32 removeReason );
    private static HandleOnRemovedDelegate  _handleOnRemoved;
    public static event HandleOnRemovedDelegate HandleOnRemoved {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["HandleOnRemoved"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("HandleOnRemoved" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _handleOnRemoved += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "HandleOnRemoved");
        }
    }
    private static void HandleOnRemovedInternal( Int32 thisPointer ,  Int32 removeReason ) =>  ScriptComponentBehavior. _handleOnRemoved?.Invoke( thisPointer ,  removeReason );
    
    public delegate void OnPreInitDelegate( Int32 thisPointer );
    private static OnPreInitDelegate  _onPreInit;
    public static event OnPreInitDelegate OnPreInit {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnPreInit"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnPreInit" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onPreInit += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnPreInit");
        }
    }
    private static void OnPreInitInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _onPreInit?.Invoke( thisPointer );
    
    public delegate void OnEditorInitDelegate( Int32 thisPointer );
    private static OnEditorInitDelegate  _onEditorInit;
    public static event OnEditorInitDelegate OnEditorInit {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnEditorInit"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnEditorInit" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEditorInit += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnEditorInit");
        }
    }
    private static void OnEditorInitInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _onEditorInit?.Invoke( thisPointer );
    
    public delegate void OnEditorTickDelegate( Int32 thisPointer ,  Single dt );
    private static OnEditorTickDelegate  _onEditorTick;
    public static event OnEditorTickDelegate OnEditorTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnEditorTick"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnEditorTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEditorTick += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnEditorTick");
        }
    }
    private static void OnEditorTickInternal( Int32 thisPointer ,  Single dt ) =>  ScriptComponentBehavior. _onEditorTick?.Invoke( thisPointer ,  dt );
    
    public delegate void OnEditorValidateDelegate( Int32 thisPointer );
    private static OnEditorValidateDelegate  _onEditorValidate;
    public static event OnEditorValidateDelegate OnEditorValidate {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnEditorValidate"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnEditorValidate" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEditorValidate += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnEditorValidate");
        }
    }
    private static void OnEditorValidateInternal( Int32 thisPointer ) =>  ScriptComponentBehavior. _onEditorValidate?.Invoke( thisPointer );
    
    public delegate Boolean IsOnlyVisualDelegate( Int32 thisPointer );
    private static IsOnlyVisualDelegate  _isOnlyVisual;
    public static event IsOnlyVisualDelegate IsOnlyVisual {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["IsOnlyVisual"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("IsOnlyVisual" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _isOnlyVisual += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "IsOnlyVisual");
        }
    }
    private static Boolean IsOnlyVisualInternal( Int32 thisPointer ) =>  (Boolean)  ScriptComponentBehavior. _isOnlyVisual?.Invoke( thisPointer );
    
    public delegate Boolean MovesEntityDelegate( Int32 thisPointer );
    private static MovesEntityDelegate  _movesEntity;
    public static event MovesEntityDelegate MovesEntity {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["MovesEntity"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("MovesEntity" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _movesEntity += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "MovesEntity");
        }
    }
    private static Boolean MovesEntityInternal( Int32 thisPointer ) =>  (Boolean)  ScriptComponentBehavior. _movesEntity?.Invoke( thisPointer );
    
    public delegate Boolean DisablesOroCreationDelegate( Int32 thisPointer );
    private static DisablesOroCreationDelegate  _disablesOroCreation;
    public static event DisablesOroCreationDelegate DisablesOroCreation {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["DisablesOroCreation"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("DisablesOroCreation" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _disablesOroCreation += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "DisablesOroCreation");
        }
    }
    private static Boolean DisablesOroCreationInternal( Int32 thisPointer ) =>  (Boolean)  ScriptComponentBehavior. _disablesOroCreation?.Invoke( thisPointer );
    
    public delegate void OnEditorVariableChangedDelegate( Int32 thisPointer ,  IntPtr variableName );
    private static OnEditorVariableChangedDelegate  _onEditorVariableChanged;
    public static event OnEditorVariableChangedDelegate OnEditorVariableChanged {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnEditorVariableChanged"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnEditorVariableChanged" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEditorVariableChanged += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnEditorVariableChanged");
        }
    }
    private static void OnEditorVariableChangedInternal( Int32 thisPointer ,  IntPtr variableName ) =>  ScriptComponentBehavior. _onEditorVariableChanged?.Invoke( thisPointer ,  variableName );
    
    public delegate void OnSceneSaveDelegate( Int32 thisPointer ,  IntPtr saveFolder );
    private static OnSceneSaveDelegate  _onSceneSave;
    public static event OnSceneSaveDelegate OnSceneSave {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnSceneSave"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnSceneSave" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onSceneSave += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnSceneSave");
        }
    }
    private static void OnSceneSaveInternal( Int32 thisPointer ,  IntPtr saveFolder ) =>  ScriptComponentBehavior. _onSceneSave?.Invoke( thisPointer ,  saveFolder );
    
    public delegate Boolean OnCheckForProblemsDelegate( Int32 thisPointer );
    private static OnCheckForProblemsDelegate  _onCheckForProblems;
    public static event OnCheckForProblemsDelegate OnCheckForProblems {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnCheckForProblems"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnCheckForProblems" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onCheckForProblems += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnCheckForProblems");
        }
    }
    private static Boolean OnCheckForProblemsInternal( Int32 thisPointer ) =>  (Boolean)  ScriptComponentBehavior. _onCheckForProblems?.Invoke( thisPointer );
    
    public delegate void OnPhysicsCollisionDelegate( Int32 thisPointer ,   ref PhysicsContact contact );
    private static OnPhysicsCollisionDelegate  _onPhysicsCollision;
    public static event OnPhysicsCollisionDelegate OnPhysicsCollision {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnPhysicsCollision"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnPhysicsCollision" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onPhysicsCollision += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnPhysicsCollision");
        }
    }
    private static void OnPhysicsCollisionInternal( Int32 thisPointer ,   ref PhysicsContact contact ) =>  ScriptComponentBehavior. _onPhysicsCollision?.Invoke( thisPointer ,  ref contact );
    
    public delegate void OnEditModeVisibilityChangedDelegate( Int32 thisPointer ,  Boolean currentVisibility );
    private static OnEditModeVisibilityChangedDelegate  _onEditModeVisibilityChanged;
    public static event OnEditModeVisibilityChangedDelegate OnEditModeVisibilityChanged {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["OnEditModeVisibilityChanged"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("OnEditModeVisibilityChanged" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onEditModeVisibilityChanged += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "OnEditModeVisibilityChanged");
        }
    }
    private static void OnEditModeVisibilityChangedInternal( Int32 thisPointer ,  Boolean currentVisibility ) =>  ScriptComponentBehavior. _onEditModeVisibilityChanged?.Invoke( thisPointer ,  currentVisibility );
    
    public delegate Int32 GetEditableFieldsDelegate( IntPtr className );
    private static GetEditableFieldsDelegate  _getEditableFields;
    public static event GetEditableFieldsDelegate GetEditableFields {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ScriptComponentBehavior"]["GetEditableFields"].Method;
            MethodInfo patch = typeof(Native.Events.ScriptComponentBehavior).GetMethod("GetEditableFields" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getEditableFields += value;
        }
        remove {
            NativeManager.UnHook("ScriptComponentBehavior", "GetEditableFields");
        }
    }
    private static Int32 GetEditableFieldsInternal( IntPtr className ) =>  (Int32)  ScriptComponentBehavior. _getEditableFields?.Invoke( className );
    
    }
}