
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
    public static class Managed {
    
    public delegate void SetLogsFolderDelegate( IntPtr logFolder );
    private static SetLogsFolderDelegate  _setLogsFolder;
    public static event SetLogsFolderDelegate SetLogsFolder {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["SetLogsFolder"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("SetLogsFolder" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setLogsFolder += value;
        }
        remove {
            NativeManager.UnHook("Managed", "SetLogsFolder");
        }
    }
    private static void SetLogsFolderInternal( IntPtr logFolder ) =>  Managed. _setLogsFolder?.Invoke( logFolder );
    
    public delegate UIntPtr GetStackTraceStrDelegate( Int32 skipCount );
    private static GetStackTraceStrDelegate  _getStackTraceStr;
    public static event GetStackTraceStrDelegate GetStackTraceStr {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetStackTraceStr"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetStackTraceStr" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getStackTraceStr += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetStackTraceStr");
        }
    }
    private static UIntPtr GetStackTraceStrInternal( Int32 skipCount ) =>  (UIntPtr)  Managed. _getStackTraceStr?.Invoke( skipCount );
    
    public delegate UIntPtr GetStackTraceRawDelegate( Int32 skipCount );
    private static GetStackTraceRawDelegate  _getStackTraceRaw;
    public static event GetStackTraceRawDelegate GetStackTraceRaw {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetStackTraceRaw"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetStackTraceRaw" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getStackTraceRaw += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetStackTraceRaw");
        }
    }
    private static UIntPtr GetStackTraceRawInternal( Int32 skipCount ) =>  (UIntPtr)  Managed. _getStackTraceRaw?.Invoke( skipCount );
    
    public delegate UIntPtr GetModuleListDelegate();
    private static GetModuleListDelegate  _getModuleList;
    public static event GetModuleListDelegate GetModuleList {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetModuleList"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetModuleList" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getModuleList += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetModuleList");
        }
    }
    private static UIntPtr GetModuleListInternal() =>  (UIntPtr)  Managed. _getModuleList?.Invoke();
    
    public delegate void GetVersionIntsDelegate(  ref Int32 major ,   ref Int32 minor ,   ref Int32 revision );
    private static GetVersionIntsDelegate  _getVersionInts;
    public static event GetVersionIntsDelegate GetVersionInts {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetVersionInts"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetVersionInts" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getVersionInts += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetVersionInts");
        }
    }
    private static void GetVersionIntsInternal(  ref Int32 major ,   ref Int32 minor ,   ref Int32 revision ) =>  Managed. _getVersionInts?.Invoke( ref major ,  ref minor ,  ref revision );
    
    public delegate Int32 CreateCustomParameterStringArrayDelegate( Int32 length );
    private static CreateCustomParameterStringArrayDelegate  _createCustomParameterStringArray;
    public static event CreateCustomParameterStringArrayDelegate CreateCustomParameterStringArray {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CreateCustomParameterStringArray"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CreateCustomParameterStringArray" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createCustomParameterStringArray += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CreateCustomParameterStringArray");
        }
    }
    private static Int32 CreateCustomParameterStringArrayInternal( Int32 length ) =>  (Int32)  Managed. _createCustomParameterStringArray?.Invoke( length );
    
    public delegate void GarbageCollectDelegate( Boolean forceTimer );
    private static GarbageCollectDelegate  _garbageCollect;
    public static event GarbageCollectDelegate GarbageCollect {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GarbageCollect"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GarbageCollect" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _garbageCollect += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GarbageCollect");
        }
    }
    private static void GarbageCollectInternal( Boolean forceTimer ) =>  Managed. _garbageCollect?.Invoke( forceTimer );
    
    public delegate void SetStringArrayValueAtIndexDelegate( Int32 array ,  Int32 index ,  IntPtr value );
    private static SetStringArrayValueAtIndexDelegate  _setStringArrayValueAtIndex;
    public static event SetStringArrayValueAtIndexDelegate SetStringArrayValueAtIndex {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["SetStringArrayValueAtIndex"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("SetStringArrayValueAtIndex" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setStringArrayValueAtIndex += value;
        }
        remove {
            NativeManager.UnHook("Managed", "SetStringArrayValueAtIndex");
        }
    }
    private static void SetStringArrayValueAtIndexInternal( Int32 array ,  Int32 index ,  IntPtr value ) =>  Managed. _setStringArrayValueAtIndex?.Invoke( array ,  index ,  value );
    
    public delegate UIntPtr GetStringArrayValueAtIndexDelegate( Int32 array ,  Int32 index );
    private static GetStringArrayValueAtIndexDelegate  _getStringArrayValueAtIndex;
    public static event GetStringArrayValueAtIndexDelegate GetStringArrayValueAtIndex {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetStringArrayValueAtIndex"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetStringArrayValueAtIndex" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getStringArrayValueAtIndex += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetStringArrayValueAtIndex");
        }
    }
    private static UIntPtr GetStringArrayValueAtIndexInternal( Int32 array ,  Int32 index ) =>  (UIntPtr)  Managed. _getStringArrayValueAtIndex?.Invoke( array ,  index );
    
    public delegate void CheckSharedStructureSizesDelegate();
    private static CheckSharedStructureSizesDelegate  _checkSharedStructureSizes;
    public static event CheckSharedStructureSizesDelegate CheckSharedStructureSizes {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CheckSharedStructureSizes"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CheckSharedStructureSizes" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _checkSharedStructureSizes += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CheckSharedStructureSizes");
        }
    }
    private static void CheckSharedStructureSizesInternal() =>  Managed. _checkSharedStructureSizes?.Invoke();
    
    public delegate void SetClosingDelegate();
    private static SetClosingDelegate  _setClosing;
    public static event SetClosingDelegate SetClosing {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["SetClosing"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("SetClosing" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setClosing += value;
        }
        remove {
            NativeManager.UnHook("Managed", "SetClosing");
        }
    }
    private static void SetClosingInternal() =>  Managed. _setClosing?.Invoke();
    
    public delegate void PreFinalizeDelegate();
    private static PreFinalizeDelegate  _preFinalize;
    public static event PreFinalizeDelegate PreFinalize {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["PreFinalize"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("PreFinalize" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _preFinalize += value;
        }
        remove {
            NativeManager.UnHook("Managed", "PreFinalize");
        }
    }
    private static void PreFinalizeInternal() =>  Managed. _preFinalize?.Invoke();
    
    public delegate void OnFinalizeDelegate();
    private static OnFinalizeDelegate  _onFinalize;
    public static event OnFinalizeDelegate OnFinalize {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["OnFinalize"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("OnFinalize" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _onFinalize += value;
        }
        remove {
            NativeManager.UnHook("Managed", "OnFinalize");
        }
    }
    private static void OnFinalizeInternal() =>  Managed. _onFinalize?.Invoke();
    
    public delegate void ApplicationTickDelegate( Single dt );
    private static ApplicationTickDelegate  _applicationTick;
    public static event ApplicationTickDelegate ApplicationTick {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["ApplicationTick"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("ApplicationTick" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _applicationTick += value;
        }
        remove {
            NativeManager.UnHook("Managed", "ApplicationTick");
        }
    }
    private static void ApplicationTickInternal( Single dt ) =>  Managed. _applicationTick?.Invoke( dt );
    
    public delegate Boolean CheckClassNameIsValidDelegate( IntPtr className );
    private static CheckClassNameIsValidDelegate  _checkClassNameIsValid;
    public static event CheckClassNameIsValidDelegate CheckClassNameIsValid {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CheckClassNameIsValid"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CheckClassNameIsValid" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _checkClassNameIsValid += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CheckClassNameIsValid");
        }
    }
    private static Boolean CheckClassNameIsValidInternal( IntPtr className ) =>  (Boolean)  Managed. _checkClassNameIsValid?.Invoke( className );
    
    public delegate Int32 GetStringArrayLengthDelegate( Int32 array );
    private static GetStringArrayLengthDelegate  _getStringArrayLength;
    public static event GetStringArrayLengthDelegate GetStringArrayLength {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetStringArrayLength"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetStringArrayLength" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getStringArrayLength += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetStringArrayLength");
        }
    }
    private static Int32 GetStringArrayLengthInternal( Int32 array ) =>  (Int32)  Managed. _getStringArrayLength?.Invoke( array );
    
    public delegate Int32 GetClassFieldsDelegate( IntPtr className ,  Boolean recursive ,  Boolean includeInternal ,  Boolean includeProtected ,  Boolean includePrivate );
    private static GetClassFieldsDelegate  _getClassFields;
    public static event GetClassFieldsDelegate GetClassFields {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetClassFields"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetClassFields" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getClassFields += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetClassFields");
        }
    }
    private static Int32 GetClassFieldsInternal( IntPtr className ,  Boolean recursive ,  Boolean includeInternal ,  Boolean includeProtected ,  Boolean includePrivate ) =>  (Int32)  Managed. _getClassFields?.Invoke( className ,  recursive ,  includeInternal ,  includeProtected ,  includePrivate );
    
    public delegate Int32 CreateObjectClassInstanceWithPointerDelegate( IntPtr className ,  IntPtr pointer );
    private static CreateObjectClassInstanceWithPointerDelegate  _createObjectClassInstanceWithPointer;
    public static event CreateObjectClassInstanceWithPointerDelegate CreateObjectClassInstanceWithPointer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CreateObjectClassInstanceWithPointer"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CreateObjectClassInstanceWithPointer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createObjectClassInstanceWithPointer += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CreateObjectClassInstanceWithPointer");
        }
    }
    private static Int32 CreateObjectClassInstanceWithPointerInternal( IntPtr className ,  IntPtr pointer ) =>  (Int32)  Managed. _createObjectClassInstanceWithPointer?.Invoke( className ,  pointer );
    
    public delegate Int32 CreateObjectClassInstanceWithIntegerDelegate( IntPtr className ,  Int32 value );
    private static CreateObjectClassInstanceWithIntegerDelegate  _createObjectClassInstanceWithInteger;
    public static event CreateObjectClassInstanceWithIntegerDelegate CreateObjectClassInstanceWithInteger {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CreateObjectClassInstanceWithInteger"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CreateObjectClassInstanceWithInteger" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _createObjectClassInstanceWithInteger += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CreateObjectClassInstanceWithInteger");
        }
    }
    private static Int32 CreateObjectClassInstanceWithIntegerInternal( IntPtr className ,  Int32 value ) =>  (Int32)  Managed. _createObjectClassInstanceWithInteger?.Invoke( className ,  value );
    
    public delegate void SetCurrentStringReturnValueDelegate( IntPtr pointer );
    private static SetCurrentStringReturnValueDelegate  _setCurrentStringReturnValue;
    public static event SetCurrentStringReturnValueDelegate SetCurrentStringReturnValue {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["SetCurrentStringReturnValue"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("SetCurrentStringReturnValue" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setCurrentStringReturnValue += value;
        }
        remove {
            NativeManager.UnHook("Managed", "SetCurrentStringReturnValue");
        }
    }
    private static void SetCurrentStringReturnValueInternal( IntPtr pointer ) =>  Managed. _setCurrentStringReturnValue?.Invoke( pointer );
    
    public delegate void SetCurrentStringReturnValueAsUnicodeDelegate( IntPtr pointer );
    private static SetCurrentStringReturnValueAsUnicodeDelegate  _setCurrentStringReturnValueAsUnicode;
    public static event SetCurrentStringReturnValueAsUnicodeDelegate SetCurrentStringReturnValueAsUnicode {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["SetCurrentStringReturnValueAsUnicode"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("SetCurrentStringReturnValueAsUnicode" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _setCurrentStringReturnValueAsUnicode += value;
        }
        remove {
            NativeManager.UnHook("Managed", "SetCurrentStringReturnValueAsUnicode");
        }
    }
    private static void SetCurrentStringReturnValueAsUnicodeInternal( IntPtr pointer ) =>  Managed. _setCurrentStringReturnValueAsUnicode?.Invoke( pointer );
    
    public delegate UIntPtr GetObjectClassNameDelegate( IntPtr className );
    private static GetObjectClassNameDelegate  _getObjectClassName;
    public static event GetObjectClassNameDelegate GetObjectClassName {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetObjectClassName"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetObjectClassName" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getObjectClassName += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetObjectClassName");
        }
    }
    private static UIntPtr GetObjectClassNameInternal( IntPtr className ) =>  (UIntPtr)  Managed. _getObjectClassName?.Invoke( className );
    
    public delegate void EngineApiMethodInterfaceInitializerDelegate( Int32 id ,  IntPtr pointer );
    private static EngineApiMethodInterfaceInitializerDelegate  _engineApiMethodInterfaceInitializer;
    public static event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["EngineApiMethodInterfaceInitializer"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("EngineApiMethodInterfaceInitializer" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _engineApiMethodInterfaceInitializer += value;
        }
        remove {
            NativeManager.UnHook("Managed", "EngineApiMethodInterfaceInitializer");
        }
    }
    private static void EngineApiMethodInterfaceInitializerInternal( Int32 id ,  IntPtr pointer ) =>  Managed. _engineApiMethodInterfaceInitializer?.Invoke( id ,  pointer );
    
    public delegate void FillEngineApiPointersDelegate();
    private static FillEngineApiPointersDelegate  _fillEngineApiPointers;
    public static event FillEngineApiPointersDelegate FillEngineApiPointers {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["FillEngineApiPointers"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("FillEngineApiPointers" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _fillEngineApiPointers += value;
        }
        remove {
            NativeManager.UnHook("Managed", "FillEngineApiPointers");
        }
    }
    private static void FillEngineApiPointersInternal() =>  Managed. _fillEngineApiPointers?.Invoke();
    
    public delegate Int64 GetMemoryUsageDelegate();
    private static GetMemoryUsageDelegate  _getMemoryUsage;
    public static event GetMemoryUsageDelegate GetMemoryUsage {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetMemoryUsage"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetMemoryUsage" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getMemoryUsage += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetMemoryUsage");
        }
    }
    private static Int64 GetMemoryUsageInternal() =>  (Int64)  Managed. _getMemoryUsage?.Invoke();
    
    public delegate void PassCustomCallbackMethodPointersDelegate( IntPtr name ,  IntPtr initalizer );
    private static PassCustomCallbackMethodPointersDelegate  _passCustomCallbackMethodPointers;
    public static event PassCustomCallbackMethodPointersDelegate PassCustomCallbackMethodPointers {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["PassCustomCallbackMethodPointers"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("PassCustomCallbackMethodPointers" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _passCustomCallbackMethodPointers += value;
        }
        remove {
            NativeManager.UnHook("Managed", "PassCustomCallbackMethodPointers");
        }
    }
    private static void PassCustomCallbackMethodPointersInternal( IntPtr name ,  IntPtr initalizer ) =>  Managed. _passCustomCallbackMethodPointers?.Invoke( name ,  initalizer );
    
    public delegate UIntPtr CallCommandlineFunctionDelegate( IntPtr functionName ,  IntPtr arguments );
    private static CallCommandlineFunctionDelegate  _callCommandlineFunction;
    public static event CallCommandlineFunctionDelegate CallCommandlineFunction {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["CallCommandlineFunction"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("CallCommandlineFunction" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _callCommandlineFunction += value;
        }
        remove {
            NativeManager.UnHook("Managed", "CallCommandlineFunction");
        }
    }
    private static UIntPtr CallCommandlineFunctionInternal( IntPtr functionName ,  IntPtr arguments ) =>  (UIntPtr)  Managed. _callCommandlineFunction?.Invoke( functionName ,  arguments );
    
    public delegate void LoadManagedComponentDelegate( IntPtr assemblyName ,  IntPtr managedInterface );
    private static LoadManagedComponentDelegate  _loadManagedComponent;
    public static event LoadManagedComponentDelegate LoadManagedComponent {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["LoadManagedComponent"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("LoadManagedComponent" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _loadManagedComponent += value;
        }
        remove {
            NativeManager.UnHook("Managed", "LoadManagedComponent");
        }
    }
    private static void LoadManagedComponentInternal( IntPtr assemblyName ,  IntPtr managedInterface ) =>  Managed. _loadManagedComponent?.Invoke( assemblyName ,  managedInterface );
    
    public delegate Boolean IsClassFieldExistsDelegate( IntPtr className ,  IntPtr fieldName );
    private static IsClassFieldExistsDelegate  _isClassFieldExists;
    public static event IsClassFieldExistsDelegate IsClassFieldExists {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["IsClassFieldExists"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("IsClassFieldExists" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _isClassFieldExists += value;
        }
        remove {
            NativeManager.UnHook("Managed", "IsClassFieldExists");
        }
    }
    private static Boolean IsClassFieldExistsInternal( IntPtr className ,  IntPtr fieldName ) =>  (Boolean)  Managed. _isClassFieldExists?.Invoke( className ,  fieldName );
    
    public delegate UIntPtr GetEnumNamesOfFieldDelegate( IntPtr className ,  IntPtr fieldName );
    private static GetEnumNamesOfFieldDelegate  _getEnumNamesOfField;
    public static event GetEnumNamesOfFieldDelegate GetEnumNamesOfField {
        add {
            MethodInfo callback = NativeManager.InboundManifest["Managed"]["GetEnumNamesOfField"].Method;
            MethodInfo patch = typeof(Native.Events.Managed).GetMethod("GetEnumNamesOfField" + "Internal", BindingFlags.NonPublic | BindingFlags.Static);
            NativeManager.Harmony.Patch(callback, prefix: new HarmonyMethod(patch));
             _getEnumNamesOfField += value;
        }
        remove {
            NativeManager.UnHook("Managed", "GetEnumNamesOfField");
        }
    }
    private static UIntPtr GetEnumNamesOfFieldInternal( IntPtr className ,  IntPtr fieldName ) =>  (UIntPtr)  Managed. _getEnumNamesOfField?.Invoke( className ,  fieldName );
    
    }
}