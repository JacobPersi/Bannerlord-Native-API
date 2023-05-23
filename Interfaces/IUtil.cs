
using System;
using TaleWorlds.Library;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using static TaleWorlds.Engine.GameEntity;
using static TaleWorlds.MountAndBlade.Agent;
using static TaleWorlds.MountAndBlade.CompressionInfo;
using static TaleWorlds.MountAndBlade.MBCommon;
using static TaleWorlds.MountAndBlade.GameNetwork;
using static TaleWorlds.Core.ArmorComponent;

namespace BannerlordUnlocked.Native {
    public static class IUtil {
    
    public static void OpenOnscreenKeyboard( Byte[] initialText ,  Byte[] descriptionText ,  Int32 maxLength ,  Int32 keyboardTypeEnum ) {
          NativeManager.OutboundManifest["IUtil"]["OpenOnscreenKeyboard"]
        .DynamicInvoke(new object[] {  initialText ,  descriptionText ,  maxLength ,  keyboardTypeEnum  } );
    }

    public static Int32 RegisterGPUAllocationGroup( Byte[] name ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["RegisterGPUAllocationGroup"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static Int32 GetMemoryUsageOfCategory( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetMemoryUsageOfCategory"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static Int32 GetVertexBufferChunkSystemMemoryUsage() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetVertexBufferChunkSystemMemoryUsage"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDetailedXBOXMemoryInfo() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetDetailedXBOXMemoryInfo"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void OutputBenchmarkValuesToPerformanceReporter() {
          NativeManager.OutboundManifest["IUtil"]["OutputBenchmarkValuesToPerformanceReporter"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetLoadingScreenPercentage( Single value ) {
          NativeManager.OutboundManifest["IUtil"]["SetLoadingScreenPercentage"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetFixedDt( Boolean enabled ,  Single dt ) {
          NativeManager.OutboundManifest["IUtil"]["SetFixedDt"]
        .DynamicInvoke(new object[] {  enabled ,  dt  } );
    }

    public static void SetBenchmarkStatus( Int32 status ,  Byte[] def ) {
          NativeManager.OutboundManifest["IUtil"]["SetBenchmarkStatus"]
        .DynamicInvoke(new object[] {  status ,  def  } );
    }

    public static Int32 GetBenchmarkStatus() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetBenchmarkStatus"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsBenchmarkQuited() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["IsBenchmarkQuited"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetApplicationMemoryStatistics() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetApplicationMemoryStatistics"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetNativeMemoryStatistics() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetNativeMemoryStatistics"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean CommandLineArgumentExists( Byte[] str ) {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["CommandLineArgumentExists"]
        .DynamicInvoke(new object[] {  str  } );
    }

    public static Int32 ExportNavMeshFaceMarks( Byte[] file_name ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["ExportNavMeshFaceMarks"]
        .DynamicInvoke(new object[] {  file_name  } );
    }

    public static Int32 TakeSSFromTop( Byte[] file_name ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["TakeSSFromTop"]
        .DynamicInvoke(new object[] {  file_name  } );
    }

    public static void CheckIfAssetsAndSourcesAreSame() {
          NativeManager.OutboundManifest["IUtil"]["CheckIfAssetsAndSourcesAreSame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetSnowAmountData( ManagedArray snowData ) {
          NativeManager.OutboundManifest["IUtil"]["GetSnowAmountData"]
        .DynamicInvoke(new object[] {  snowData  } );
    }

    public static void GatherCoreGameReferences( Byte[] scene_names ) {
          NativeManager.OutboundManifest["IUtil"]["GatherCoreGameReferences"]
        .DynamicInvoke(new object[] {  scene_names  } );
    }

    public static Single GetApplicationMemory() {
         return   (Single)  NativeManager.OutboundManifest["IUtil"]["GetApplicationMemory"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DisableCoreGame() {
          NativeManager.OutboundManifest["IUtil"]["DisableCoreGame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void FindMeshesWithoutLods( Byte[] module_name ) {
          NativeManager.OutboundManifest["IUtil"]["FindMeshesWithoutLods"]
        .DynamicInvoke(new object[] {  module_name  } );
    }

    public static void SetPrintCallstackAtCrahses( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetPrintCallstackAtCrahses"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetDisableDumpGeneration( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetDisableDumpGeneration"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Int32 GetModulesCode() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetModulesCode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetFullModulePath( Byte[] moduleName ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetFullModulePath"]
        .DynamicInvoke(new object[] {  moduleName  } );
    }

    public static Int32 GetFullModulePaths() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetFullModulePaths"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetFullFilePathOfScene( Byte[] sceneName ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetFullFilePathOfScene"]
        .DynamicInvoke(new object[] {  sceneName  } );
    }

    public static void PairSceneNameToModuleName( Byte[] sceneName ,  Byte[] moduleName ) {
          NativeManager.OutboundManifest["IUtil"]["PairSceneNameToModuleName"]
        .DynamicInvoke(new object[] {  sceneName ,  moduleName  } );
    }

    public static Int32 GetSingleModuleScenesOfModule( Byte[] moduleName ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetSingleModuleScenesOfModule"]
        .DynamicInvoke(new object[] {  moduleName  } );
    }

    public static Int32 GetExecutableWorkingDirectory() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetExecutableWorkingDirectory"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void AddMainThreadPerformanceQuery( Byte[] parent ,  Byte[] name ,  Single seconds ) {
          NativeManager.OutboundManifest["IUtil"]["AddMainThreadPerformanceQuery"]
        .DynamicInvoke(new object[] {  parent ,  name ,  seconds  } );
    }

    public static void SetDumpFolderPath( Byte[] path ) {
          NativeManager.OutboundManifest["IUtil"]["SetDumpFolderPath"]
        .DynamicInvoke(new object[] {  path  } );
    }

    public static void CheckSceneForProblems( Byte[] path ) {
          NativeManager.OutboundManifest["IUtil"]["CheckSceneForProblems"]
        .DynamicInvoke(new object[] {  path  } );
    }

    public static void SetScreenTextRenderingState( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetScreenTextRenderingState"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetMessageLineRenderingState( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetMessageLineRenderingState"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Boolean CheckShaderCompilation() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["CheckShaderCompilation"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetCrashOnAsserts( Boolean val ) {
          NativeManager.OutboundManifest["IUtil"]["SetCrashOnAsserts"]
        .DynamicInvoke(new object[] {  val  } );
    }

    public static Boolean CheckIfTerrainShaderHeaderGenerationFinished() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["CheckIfTerrainShaderHeaderGenerationFinished"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetCrashOnWarnings( Boolean val ) {
          NativeManager.OutboundManifest["IUtil"]["SetCrashOnWarnings"]
        .DynamicInvoke(new object[] {  val  } );
    }

    public static void GenerateTerrainShaderHeaders( Byte[] targetPlatform ,  Byte[] targetConfig ,  Byte[] output_path ) {
          NativeManager.OutboundManifest["IUtil"]["GenerateTerrainShaderHeaders"]
        .DynamicInvoke(new object[] {  targetPlatform ,  targetConfig ,  output_path  } );
    }

    public static void CompileTerrainShadersDist( Byte[] targetPlatform ,  Byte[] targetConfig ,  Byte[] output_path ) {
          NativeManager.OutboundManifest["IUtil"]["CompileTerrainShadersDist"]
        .DynamicInvoke(new object[] {  targetPlatform ,  targetConfig ,  output_path  } );
    }

    public static void CompileAllShaders( Byte[] targetPlatform ) {
          NativeManager.OutboundManifest["IUtil"]["CompileAllShaders"]
        .DynamicInvoke(new object[] {  targetPlatform  } );
    }

    public static void ToggleRender() {
          NativeManager.OutboundManifest["IUtil"]["ToggleRender"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetForceDrawEntityID( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetForceDrawEntityID"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetRenderAgents( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetRenderAgents"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Int32 GetCoreGameState() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetCoreGameState"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetCoreGameState( Int32 state ) {
          NativeManager.OutboundManifest["IUtil"]["SetCoreGameState"]
        .DynamicInvoke(new object[] {  state  } );
    }

    public static Int32 ExecuteCommandLineCommand( Byte[] command ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["ExecuteCommandLineCommand"]
        .DynamicInvoke(new object[] {  command  } );
    }

    public static void QuitGame() {
          NativeManager.OutboundManifest["IUtil"]["QuitGame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ExitProcess( Int32 exitCode ) {
          NativeManager.OutboundManifest["IUtil"]["ExitProcess"]
        .DynamicInvoke(new object[] {  exitCode  } );
    }

    public static void StartScenePerformanceReport( Byte[] folderPath ) {
          NativeManager.OutboundManifest["IUtil"]["StartScenePerformanceReport"]
        .DynamicInvoke(new object[] {  folderPath  } );
    }

    public static Int32 GetBaseDirectory() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetBaseDirectory"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetVisualTestsTestFilesPath() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetVisualTestsTestFilesPath"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetVisualTestsValidatePath() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetVisualTestsValidatePath"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetAttachmentsPath() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetAttachmentsPath"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsSceneReportFinished() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["IsSceneReportFinished"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void FlushManagedObjectsMemory() {
          NativeManager.OutboundManifest["IUtil"]["FlushManagedObjectsMemory"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetRenderMode( Int32 mode ) {
          NativeManager.OutboundManifest["IUtil"]["SetRenderMode"]
        .DynamicInvoke(new object[] {  mode  } );
    }

    public static void AddPerformanceReportToken( Byte[] performance_type ,  Byte[] name ,  Single loading_time ) {
          NativeManager.OutboundManifest["IUtil"]["AddPerformanceReportToken"]
        .DynamicInvoke(new object[] {  performance_type ,  name ,  loading_time  } );
    }

    public static void AddSceneObjectReport( Byte[] scene_name ,  Byte[] report_name ,  Single report_value ) {
          NativeManager.OutboundManifest["IUtil"]["AddSceneObjectReport"]
        .DynamicInvoke(new object[] {  scene_name ,  report_name ,  report_value  } );
    }

    public static void OutputPerformanceReports() {
          NativeManager.OutboundManifest["IUtil"]["OutputPerformanceReports"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void AddCommandLineFunction( Byte[] concatName ) {
          NativeManager.OutboundManifest["IUtil"]["AddCommandLineFunction"]
        .DynamicInvoke(new object[] {  concatName  } );
    }

    public static Int32 GetNumberOfShaderCompilationsInProgress() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetNumberOfShaderCompilationsInProgress"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetEditorSelectedEntityCount() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetEditorSelectedEntityCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetEntityCountOfSelectionSet( Byte[] name ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetEntityCountOfSelectionSet"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static Int32 GetBuildNumber() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetBuildNumber"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetEntitiesOfSelectionSet( Byte[] name ,  IntPtr gameEntitiesTemp ) {
          NativeManager.OutboundManifest["IUtil"]["GetEntitiesOfSelectionSet"]
        .DynamicInvoke(new object[] {  name ,  gameEntitiesTemp  } );
    }

    public static void GetEditorSelectedEntities( IntPtr gameEntitiesTemp ) {
          NativeManager.OutboundManifest["IUtil"]["GetEditorSelectedEntities"]
        .DynamicInvoke(new object[] {  gameEntitiesTemp  } );
    }

    public static void DeleteEntitiesInEditorScene( IntPtr gameEntities ,  Int32 entityCount ) {
          NativeManager.OutboundManifest["IUtil"]["DeleteEntitiesInEditorScene"]
        .DynamicInvoke(new object[] {  gameEntities ,  entityCount  } );
    }

    public static void CreateSelectionInEditor( IntPtr gameEntities ,  Int32 entityCount ,  Byte[] name ) {
          NativeManager.OutboundManifest["IUtil"]["CreateSelectionInEditor"]
        .DynamicInvoke(new object[] {  gameEntities ,  entityCount ,  name  } );
    }

    public static void SelectEntities( IntPtr gameEntities ,  Int32 entityCount ) {
          NativeManager.OutboundManifest["IUtil"]["SelectEntities"]
        .DynamicInvoke(new object[] {  gameEntities ,  entityCount  } );
    }

    public static UInt64 GetCurrentCpuMemoryUsage() {
         return   (UInt64)  NativeManager.OutboundManifest["IUtil"]["GetCurrentCpuMemoryUsage"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void GetGPUMemoryStats(  ref Single totalMemory ,   ref Single renderTargetMemory ,   ref Single depthTargetMemory ,   ref Single srvMemory ,   ref Single bufferMemory ) {
          NativeManager.OutboundManifest["IUtil"]["GetGPUMemoryStats"]
        .DynamicInvoke(new object[] {  totalMemory ,  renderTargetMemory ,  depthTargetMemory ,  srvMemory ,  bufferMemory  } );
    }

    public static UInt64 GetGpuMemoryOfAllocationGroup( Byte[] allocationName ) {
         return   (UInt64)  NativeManager.OutboundManifest["IUtil"]["GetGpuMemoryOfAllocationGroup"]
        .DynamicInvoke(new object[] {  allocationName  } );
    }

    public static void GetDetailedGPUBufferMemoryStats(  ref Int32 totalMemoryAllocated ,   ref Int32 totalMemoryUsed ,   ref Int32 emptyChunkCount ) {
          NativeManager.OutboundManifest["IUtil"]["GetDetailedGPUBufferMemoryStats"]
        .DynamicInvoke(new object[] {  totalMemoryAllocated ,  totalMemoryUsed ,  emptyChunkCount  } );
    }

    public static Int32 IsDetailedSoundLogOn() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["IsDetailedSoundLogOn"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetMainFps() {
         return   (Single)  NativeManager.OutboundManifest["IUtil"]["GetMainFps"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void OnLoadingWindowEnabled() {
          NativeManager.OutboundManifest["IUtil"]["OnLoadingWindowEnabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DebugSetGlobalLoadingWindowState( Boolean s ) {
          NativeManager.OutboundManifest["IUtil"]["DebugSetGlobalLoadingWindowState"]
        .DynamicInvoke(new object[] {  s  } );
    }

    public static void OnLoadingWindowDisabled() {
          NativeManager.OutboundManifest["IUtil"]["OnLoadingWindowDisabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DisableGlobalLoadingWindow() {
          NativeManager.OutboundManifest["IUtil"]["DisableGlobalLoadingWindow"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EnableGlobalLoadingWindow() {
          NativeManager.OutboundManifest["IUtil"]["EnableGlobalLoadingWindow"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EnableGlobalEditDataCacher() {
          NativeManager.OutboundManifest["IUtil"]["EnableGlobalEditDataCacher"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Single GetRendererFps() {
         return   (Single)  NativeManager.OutboundManifest["IUtil"]["GetRendererFps"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DisableGlobalEditDataCacher() {
          NativeManager.OutboundManifest["IUtil"]["DisableGlobalEditDataCacher"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EnableSingleGPUQueryPerFrame() {
          NativeManager.OutboundManifest["IUtil"]["EnableSingleGPUQueryPerFrame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void clear_decal_atlas( DecalAtlasGroup atlasGroup ) {
          NativeManager.OutboundManifest["IUtil"]["clear_decal_atlas"]
        .DynamicInvoke(new object[] {  atlasGroup  } );
    }

    public static Single GetFps() {
         return   (Single)  NativeManager.OutboundManifest["IUtil"]["GetFps"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetFullCommandLineString() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetFullCommandLineString"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void TakeScreenshotFromStringPath( Byte[] path ) {
          NativeManager.OutboundManifest["IUtil"]["TakeScreenshotFromStringPath"]
        .DynamicInvoke(new object[] {  path  } );
    }

    public static void TakeScreenshotFromPlatformPath( PlatformFilePath path ) {
          NativeManager.OutboundManifest["IUtil"]["TakeScreenshotFromPlatformPath"]
        .DynamicInvoke(new object[] {  path  } );
    }

    public static void CheckResourceModifications() {
          NativeManager.OutboundManifest["IUtil"]["CheckResourceModifications"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetGraphicsPreset( Int32 preset ) {
          NativeManager.OutboundManifest["IUtil"]["SetGraphicsPreset"]
        .DynamicInvoke(new object[] {  preset  } );
    }

    public static void ClearOldResourcesAndObjects() {
          NativeManager.OutboundManifest["IUtil"]["ClearOldResourcesAndObjects"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void LoadVirtualTextureTileset( Byte[] name ) {
          NativeManager.OutboundManifest["IUtil"]["LoadVirtualTextureTileset"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static Single GetDeltaTime( Int32 timerId ) {
         return   (Single)  NativeManager.OutboundManifest["IUtil"]["GetDeltaTime"]
        .DynamicInvoke(new object[] {  timerId  } );
    }

    public static void LoadSkyBoxes() {
          NativeManager.OutboundManifest["IUtil"]["LoadSkyBoxes"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetEngineFrameNo() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetEngineFrameNo"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetAllocationAlwaysValidScene( UIntPtr scene ) {
          NativeManager.OutboundManifest["IUtil"]["SetAllocationAlwaysValidScene"]
        .DynamicInvoke(new object[] {  scene  } );
    }

    public static Int32 GetConsoleHostMachine() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetConsoleHostMachine"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean IsEditModeEnabled() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["IsEditModeEnabled"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetPCInfo() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetPCInfo"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetGPUMemoryMB() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetGPUMemoryMB"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetCurrentEstimatedGPUMemoryCostMB() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetCurrentEstimatedGPUMemoryCostMB"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DumpGPUMemoryStatistics( Byte[] filePath ) {
          NativeManager.OutboundManifest["IUtil"]["DumpGPUMemoryStatistics"]
        .DynamicInvoke(new object[] {  filePath  } );
    }

    public static Int32 SaveDataAsTexture( Byte[] path ,  Int32 width ,  Int32 height ,  IntPtr data ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["SaveDataAsTexture"]
        .DynamicInvoke(new object[] {  path ,  width ,  height ,  data  } );
    }

    public static Int32 GetApplicationName() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetApplicationName"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetWindowTitle( Byte[] title ) {
          NativeManager.OutboundManifest["IUtil"]["SetWindowTitle"]
        .DynamicInvoke(new object[] {  title  } );
    }

    public static Int32 ProcessWindowTitle( Byte[] title ) {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["ProcessWindowTitle"]
        .DynamicInvoke(new object[] {  title  } );
    }

    public static UInt32 GetCurrentProcessID() {
         return   (UInt32)  NativeManager.OutboundManifest["IUtil"]["GetCurrentProcessID"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DoDelayedexit( Int32 returnCode ) {
          NativeManager.OutboundManifest["IUtil"]["DoDelayedexit"]
        .DynamicInvoke(new object[] {  returnCode  } );
    }

    public static void SetReportMode( Boolean reportMode ) {
          NativeManager.OutboundManifest["IUtil"]["SetReportMode"]
        .DynamicInvoke(new object[] {  reportMode  } );
    }

    public static void SetAssertionsAndWarningsSetExitCode( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetAssertionsAndWarningsSetExitCode"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void SetAssertionAtShaderCompile( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetAssertionAtShaderCompile"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Boolean DidAutomatedGIBakeFinished() {
         return   (Boolean)  NativeManager.OutboundManifest["IUtil"]["DidAutomatedGIBakeFinished"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DoFullBakeAllLevelsAutomated( Byte[] module ,  Byte[] sceneName ) {
          NativeManager.OutboundManifest["IUtil"]["DoFullBakeAllLevelsAutomated"]
        .DynamicInvoke(new object[] {  module ,  sceneName  } );
    }

    public static void DoFullBakeSingleLevelAutomated( Byte[] module ,  Byte[] sceneName ) {
          NativeManager.OutboundManifest["IUtil"]["DoFullBakeSingleLevelAutomated"]
        .DynamicInvoke(new object[] {  module ,  sceneName  } );
    }

    public static Int32 GetReturnCode() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetReturnCode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void DoLightOnlyBakeSingleLevelAutomated( Byte[] module ,  Byte[] sceneName ) {
          NativeManager.OutboundManifest["IUtil"]["DoLightOnlyBakeSingleLevelAutomated"]
        .DynamicInvoke(new object[] {  module ,  sceneName  } );
    }

    public static void DoLightOnlyBakeAllLevelsAutomated( Byte[] module ,  Byte[] sceneName ) {
          NativeManager.OutboundManifest["IUtil"]["DoLightOnlyBakeAllLevelsAutomated"]
        .DynamicInvoke(new object[] {  module ,  sceneName  } );
    }

    public static Int32 GetLocalOutputPath() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetLocalOutputPath"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetCrashReportCustomString( Byte[] customString ) {
          NativeManager.OutboundManifest["IUtil"]["SetCrashReportCustomString"]
        .DynamicInvoke(new object[] {  customString  } );
    }

    public static void SetCrashReportCustomStack( Byte[] customStack ) {
          NativeManager.OutboundManifest["IUtil"]["SetCrashReportCustomStack"]
        .DynamicInvoke(new object[] {  customStack  } );
    }

    public static Int32 GetSteamAppId() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetSteamAppId"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetForceVsync( Boolean value ) {
          NativeManager.OutboundManifest["IUtil"]["SetForceVsync"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static Int32 GetSystemLanguage() {
         return   (Int32)  NativeManager.OutboundManifest["IUtil"]["GetSystemLanguage"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ManagedParallelFor( Int32 fromInclusive ,  Int32 toExclusive ,  Int64 curKey ,  Int32 grainSize ) {
          NativeManager.OutboundManifest["IUtil"]["ManagedParallelFor"]
        .DynamicInvoke(new object[] {  fromInclusive ,  toExclusive ,  curKey ,  grainSize  } );
    }

    public static UInt64 GetMainThreadId() {
         return   (UInt64)  NativeManager.OutboundManifest["IUtil"]["GetMainThreadId"]
        .DynamicInvoke(new object[] {  } );
    }

    public static UInt64 GetCurrentThreadId() {
         return   (UInt64)  NativeManager.OutboundManifest["IUtil"]["GetCurrentThreadId"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void RegisterMeshForGPUMorph( Byte[] metaMeshName ) {
          NativeManager.OutboundManifest["IUtil"]["RegisterMeshForGPUMorph"]
        .DynamicInvoke(new object[] {  metaMeshName  } );
    }

    public static void ManagedParallelForWithDt( Int32 fromInclusive ,  Int32 toExclusive ,  Int64 curKey ,  Int32 grainSize ) {
          NativeManager.OutboundManifest["IUtil"]["ManagedParallelForWithDt"]
        .DynamicInvoke(new object[] {  fromInclusive ,  toExclusive ,  curKey ,  grainSize  } );
    }

    public static void ClearShaderMemory() {
          NativeManager.OutboundManifest["IUtil"]["ClearShaderMemory"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}