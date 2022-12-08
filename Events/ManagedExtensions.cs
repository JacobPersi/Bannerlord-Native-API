
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
    public static class ManagedExtensions {
    
    public delegate void SetObjectFieldDelegate( Int32 managedObject ,  IntPtr fieldName ,   ref ScriptComponentFieldHolder scriptComponentHolder ,  Int32 type ,  Int32 callFieldChangeEventAsInteger );
    private static SetObjectFieldDelegate  _setObjectField;
    public static event SetObjectFieldDelegate SetObjectField {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["SetObjectField"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("SetObjectField" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setObjectField += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "SetObjectField");
        }
    }
    private static void SetObjectFieldInternal( Int32 managedObject ,  IntPtr fieldName ,   ref ScriptComponentFieldHolder scriptComponentHolder ,  Int32 type ,  Int32 callFieldChangeEventAsInteger ) =>  ManagedExtensions. _setObjectField?.Invoke( managedObject ,  fieldName ,  ref scriptComponentHolder ,  type ,  callFieldChangeEventAsInteger );
    
    public delegate void GetObjectFieldDelegate( Int32 managedObject ,   ref ScriptComponentFieldHolder scriptComponentFieldHolder ,  IntPtr fieldName ,  Int32 type );
    private static GetObjectFieldDelegate  _getObjectField;
    public static event GetObjectFieldDelegate GetObjectField {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["GetObjectField"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("GetObjectField" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getObjectField += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "GetObjectField");
        }
    }
    private static void GetObjectFieldInternal( Int32 managedObject ,   ref ScriptComponentFieldHolder scriptComponentFieldHolder ,  IntPtr fieldName ,  Int32 type ) =>  ManagedExtensions. _getObjectField?.Invoke( managedObject ,  ref scriptComponentFieldHolder ,  fieldName ,  type );
    
    public delegate void CopyObjectFieldsFromDelegate( Int32 dst ,  Int32 src ,  IntPtr className ,  Int32 callFieldChangeEventAsInteger );
    private static CopyObjectFieldsFromDelegate  _copyObjectFieldsFrom;
    public static event CopyObjectFieldsFromDelegate CopyObjectFieldsFrom {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["CopyObjectFieldsFrom"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("CopyObjectFieldsFrom" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _copyObjectFieldsFrom += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "CopyObjectFieldsFrom");
        }
    }
    private static void CopyObjectFieldsFromInternal( Int32 dst ,  Int32 src ,  IntPtr className ,  Int32 callFieldChangeEventAsInteger ) =>  ManagedExtensions. _copyObjectFieldsFrom?.Invoke( dst ,  src ,  className ,  callFieldChangeEventAsInteger );
    
    public delegate Int32 CreateScriptComponentInstanceDelegate( IntPtr className ,  NativeObjectPointer entity ,  NativeObjectPointer managedScriptComponent );
    private static CreateScriptComponentInstanceDelegate  _createScriptComponentInstance;
    public static event CreateScriptComponentInstanceDelegate CreateScriptComponentInstance {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["CreateScriptComponentInstance"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("CreateScriptComponentInstance" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createScriptComponentInstance += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "CreateScriptComponentInstance");
        }
    }
    private static Int32 CreateScriptComponentInstanceInternal( IntPtr className ,  NativeObjectPointer entity ,  NativeObjectPointer managedScriptComponent ) =>  (Int32)  ManagedExtensions. _createScriptComponentInstance?.Invoke( className ,  entity ,  managedScriptComponent );
    
    public delegate UIntPtr GetScriptComponentClassNamesDelegate();
    private static GetScriptComponentClassNamesDelegate  _getScriptComponentClassNames;
    public static event GetScriptComponentClassNamesDelegate GetScriptComponentClassNames {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["GetScriptComponentClassNames"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("GetScriptComponentClassNames" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getScriptComponentClassNames += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "GetScriptComponentClassNames");
        }
    }
    private static UIntPtr GetScriptComponentClassNamesInternal() =>  (UIntPtr)  ManagedExtensions. _getScriptComponentClassNames?.Invoke();
    
    public delegate Boolean GetEditorVisibilityOfFieldDelegate( IntPtr className ,  IntPtr fieldName );
    private static GetEditorVisibilityOfFieldDelegate  _getEditorVisibilityOfField;
    public static event GetEditorVisibilityOfFieldDelegate GetEditorVisibilityOfField {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["GetEditorVisibilityOfField"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("GetEditorVisibilityOfField" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getEditorVisibilityOfField += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "GetEditorVisibilityOfField");
        }
    }
    private static Boolean GetEditorVisibilityOfFieldInternal( IntPtr className ,  IntPtr fieldName ) =>  (Boolean)  ManagedExtensions. _getEditorVisibilityOfField?.Invoke( className ,  fieldName );
    
    public delegate Int32 GetTypeOfFieldDelegate( IntPtr className ,  IntPtr fieldName );
    private static GetTypeOfFieldDelegate  _getTypeOfField;
    public static event GetTypeOfFieldDelegate GetTypeOfField {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["GetTypeOfField"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("GetTypeOfField" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getTypeOfField += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "GetTypeOfField");
        }
    }
    private static Int32 GetTypeOfFieldInternal( IntPtr className ,  IntPtr fieldName ) =>  (Int32)  ManagedExtensions. _getTypeOfField?.Invoke( className ,  fieldName );
    
    public delegate void ForceGarbageCollectDelegate();
    private static ForceGarbageCollectDelegate  _forceGarbageCollect;
    public static event ForceGarbageCollectDelegate ForceGarbageCollect {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["ForceGarbageCollect"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("ForceGarbageCollect" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _forceGarbageCollect += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "ForceGarbageCollect");
        }
    }
    private static void ForceGarbageCollectInternal() =>  ManagedExtensions. _forceGarbageCollect?.Invoke();
    
    public delegate void CollectCommandLineFunctionsDelegate();
    private static CollectCommandLineFunctionsDelegate  _collectCommandLineFunctions;
    public static event CollectCommandLineFunctionsDelegate CollectCommandLineFunctions {
        add {
            MethodInfo callback = NativeManager.InboundManifest["ManagedExtensions"]["CollectCommandLineFunctions"].Method;
            MethodInfo patch = typeof(Native.Events.ManagedExtensions).GetMethod("CollectCommandLineFunctions" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _collectCommandLineFunctions += value;
        }
        remove {
            NativeManager.UnHook("ManagedExtensions", "CollectCommandLineFunctions");
        }
    }
    private static void CollectCommandLineFunctionsInternal() =>  ManagedExtensions. _collectCommandLineFunctions?.Invoke();
    
    }
}