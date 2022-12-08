
# Events:
## Agent:
	- event SetAgentAIPerformingRetreatBehaviorDelegate SetAgentAIPerformingRetreatBehavior
	- event GetMissileRangeWithHeightDifferenceAuxDelegate GetMissileRangeWithHeightDifferenceAux
	- event GetFormationUnitSpacingDelegate GetFormationUnitSpacing
	- event GetSoundAndCollisionInfoClassNameDelegate GetSoundAndCollisionInfoClassName
	- event IsInSameFormationWithDelegate IsInSameFormationWith
	- event OnWeaponSwitchingToAlternativeStartDelegate OnWeaponSwitchingToAlternativeStart
	- event OnWeaponReloadPhaseChangeDelegate OnWeaponReloadPhaseChange
	- event OnWeaponAmmoReloadDelegate OnWeaponAmmoReload
	- event OnWeaponAmmoConsumeDelegate OnWeaponAmmoConsume
	- event OnShieldDamagedDelegate OnShieldDamaged
	- event OnWeaponAmmoRemovedDelegate OnWeaponAmmoRemoved
	- event OnMountDelegate OnMount
	- event OnDismountDelegate OnDismount
	- event OnAgentAlarmedStateChangedDelegate OnAgentAlarmedStateChanged
	- event OnRetreatingDelegate OnRetreating
	- event UpdateMountAgentCacheDelegate UpdateMountAgentCache
	- event UpdateRiderAgentCacheDelegate UpdateRiderAgentCache
	- event UpdateAgentStatsDelegate UpdateAgentStats
	- event GetWeaponInaccuracyDelegate GetWeaponInaccuracy
	- event DebugGetHealthDelegate DebugGetHealth
	- event OnWieldedItemIndexChangeDelegate OnWieldedItemIndexChange
	- event OnRemoveWeaponDelegate OnRemoveWeapon
	- event OnWeaponUsageIndexChangeDelegate OnWeaponUsageIndexChange
	- event OnWeaponAmountChangeDelegate OnWeaponAmountChange

## BannerlordTableauManager:
	- event RequestCharacterTableauSetupDelegate RequestCharacterTableauSetup
	- event RegisterCharacterTableauSceneDelegate RegisterCharacterTableauScene

## CoreManaged:
	- event StartDelegate Start
	- event OnLoadCommonFinishedDelegate OnLoadCommonFinished
	- event FinalizeDelegate Finalize
	- event CheckSharedStructureSizesDelegate CheckSharedStructureSizes
	- event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer
	- event FillEngineApiPointersDelegate FillEngineApiPointers

## CrashInformationCollector:
	- event CollectInformationDelegate CollectInformation

## DotNetObject:
	- event GetAliveDotNetObjectCountDelegate GetAliveDotNetObjectCount
	- event IncreaseReferenceCountDelegate IncreaseReferenceCount
	- event DecreaseReferenceCountDelegate DecreaseReferenceCount
	- event GetAliveDotNetObjectNamesDelegate GetAliveDotNetObjectNames

## EngineController:
	- event InitializeDelegate Initialize
	- event OnConfigChangeDelegate OnConfigChange
	- event OnConstrainedStateChangeDelegate OnConstrainedStateChange
	- event GetVersionStrDelegate GetVersionStr
	- event GetApplicationPlatformNameDelegate GetApplicationPlatformName
	- event GetModulesVersionStrDelegate GetModulesVersionStr
	- event OnControllerDisconnectionDelegate OnControllerDisconnection

## EngineManaged:
	- event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer
	- event CheckSharedStructureSizesDelegate CheckSharedStructureSizes
	- event FillEngineApiPointersDelegate FillEngineApiPointers

## EngineScreenManager:
	- event PreTickDelegate PreTick
	- event TickDelegate Tick
	- event LateTickDelegate LateTick
	- event OnOnscreenKeyboardDoneDelegate OnOnscreenKeyboardDone
	- event OnOnscreenKeyboardCanceledDelegate OnOnscreenKeyboardCanceled
	- event OnGameWindowFocusChangeDelegate OnGameWindowFocusChange
	- event UpdateDelegate Update

## GameNetwork:
	- event HandleRemovePlayerDelegate HandleRemovePlayer
	- event HandleDisconnectDelegate HandleDisconnect
	- event HandleNetworkPacketAsServerDelegate HandleNetworkPacketAsServer
	- event HandleConsoleCommandDelegate HandleConsoleCommand
	- event HandleNetworkPacketAsClientDelegate HandleNetworkPacketAsClient
	- event SyncRelevantGameOptionsToServerDelegate SyncRelevantGameOptionsToServer

## Managed:
	- event SetLogsFolderDelegate SetLogsFolder
	- event GetStackTraceStrDelegate GetStackTraceStr
	- event GetStackTraceRawDelegate GetStackTraceRaw
	- event GetModuleListDelegate GetModuleList
	- event GetVersionIntsDelegate GetVersionInts
	- event CreateCustomParameterStringArrayDelegate CreateCustomParameterStringArray
	- event GarbageCollectDelegate GarbageCollect
	- event SetStringArrayValueAtIndexDelegate SetStringArrayValueAtIndex
	- event GetStringArrayValueAtIndexDelegate GetStringArrayValueAtIndex
	- event CheckSharedStructureSizesDelegate CheckSharedStructureSizes
	- event SetClosingDelegate SetClosing
	- event PreFinalizeDelegate PreFinalize
	- event OnFinalizeDelegate OnFinalize
	- event ApplicationTickDelegate ApplicationTick
	- event CheckClassNameIsValidDelegate CheckClassNameIsValid
	- event GetStringArrayLengthDelegate GetStringArrayLength
	- event GetClassFieldsDelegate GetClassFields
	- event CreateObjectClassInstanceWithPointerDelegate CreateObjectClassInstanceWithPointer
	- event CreateObjectClassInstanceWithIntegerDelegate CreateObjectClassInstanceWithInteger
	- event SetCurrentStringReturnValueDelegate SetCurrentStringReturnValue
	- event SetCurrentStringReturnValueAsUnicodeDelegate SetCurrentStringReturnValueAsUnicode
	- event GetObjectClassNameDelegate GetObjectClassName
	- event EngineApiMethodInterfaceInitializerDelegate EngineApiMethodInterfaceInitializer
	- event FillEngineApiPointersDelegate FillEngineApiPointers
	- event GetMemoryUsageDelegate GetMemoryUsage
	- event PassCustomCallbackMethodPointersDelegate PassCustomCallbackMethodPointers
	- event CallCommandlineFunctionDelegate CallCommandlineFunction
	- event LoadManagedComponentDelegate LoadManagedComponent
	- event IsClassFieldExistsDelegate IsClassFieldExists
	- event GetEnumNamesOfFieldDelegate GetEnumNamesOfField

## ManagedDelegate:
	- event InvokeAuxDelegate InvokeAux

## ManagedExtensions:
	- event SetObjectFieldDelegate SetObjectField
	- event GetObjectFieldDelegate GetObjectField
	- event CopyObjectFieldsFromDelegate CopyObjectFieldsFrom
	- event CreateScriptComponentInstanceDelegate CreateScriptComponentInstance
	- event GetScriptComponentClassNamesDelegate GetScriptComponentClassNames
	- event GetEditorVisibilityOfFieldDelegate GetEditorVisibilityOfField
	- event GetTypeOfFieldDelegate GetTypeOfField
	- event ForceGarbageCollectDelegate ForceGarbageCollect
	- event CollectCommandLineFunctionsDelegate CollectCommandLineFunctions

## ManagedObject:
	- event GetAliveManagedObjectCountDelegate GetAliveManagedObjectCount
	- event GetAliveManagedObjectNamesDelegate GetAliveManagedObjectNames
	- event GetCreationCallstackDelegate GetCreationCallstack
	- event GetClassOfObjectDelegate GetClassOfObject

## ManagedOptions:
	- event GetConfigCountDelegate GetConfigCount
	- event GetConfigValueDelegate GetConfigValue

## ManagedScriptHolder:
	- event CreateManagedScriptHolderDelegate CreateManagedScriptHolder
	- event SetScriptComponentHolderDelegate SetScriptComponentHolder
	- event RemoveScriptComponentFromAllTickListsDelegate RemoveScriptComponentFromAllTickLists
	- event GetNumberOfScriptsDelegate GetNumberOfScripts
	- event TickComponentsDelegate TickComponents
	- event TickComponentsEditorDelegate TickComponentsEditor

## MBEditor:
	- event SetEditorSceneDelegate SetEditorScene
	- event CloseEditorSceneDelegate CloseEditorScene
	- event DestroyEditorDelegate DestroyEditor

## MBMultiplayerData:
	- event GetServerIdDelegate GetServerId
	- event GetServerNameDelegate GetServerName
	- event GetGameModuleDelegate GetGameModule
	- event GetGameTypeDelegate GetGameType
	- event GetMapDelegate GetMap
	- event GetCurrentPlayerCountDelegate GetCurrentPlayerCount
	- event GetPlayerCountLimitDelegate GetPlayerCountLimit
	- event UpdateGameServerInfoDelegate UpdateGameServerInfo

## MessageManagerBase:
	- event PostWarningLineDelegate PostWarningLine
	- event PostSuccessLineDelegate PostSuccessLine
	- event PostMessageLineFormattedDelegate PostMessageLineFormatted
	- event PostMessageLineDelegate PostMessageLine

## Mission:
	- event DebugLogNativeMissionNetworkEventDelegate DebugLogNativeMissionNetworkEvent
	- event PauseMissionDelegate PauseMission
	- event OnAgentRemovedDelegate OnAgentRemoved
	- event SpawnWeaponAsDropFromAgentDelegate SpawnWeaponAsDropFromAgent
	- event OnPreTickDelegate OnPreTick
	- event ApplySkeletonScaleToAllEquippedItemsDelegate ApplySkeletonScaleToAllEquippedItems
	- event EndMissionDelegate EndMission
	- event OnAgentShootMissileDelegate OnAgentShootMissile
	- event GetAgentStateDelegate GetAgentState
	- event MeleeHitCallbackDelegate MeleeHitCallback
	- event OnAgentHitBlockedDelegate OnAgentHitBlocked
	- event MissileAreaDamageCallbackDelegate MissileAreaDamageCallback
	- event OnMissileRemovedDelegate OnMissileRemoved
	- event MissileHitCallbackDelegate MissileHitCallback
	- event ChargeDamageCallbackDelegate ChargeDamageCallback
	- event FallDamageCallbackDelegate FallDamageCallback
	- event GetDefendCollisionResultsDelegate GetDefendCollisionResults
	- event OnAgentAddedAsCorpseDelegate OnAgentAddedAsCorpse
	- event OnAgentDeletedDelegate OnAgentDeleted
	- event UpdateMissionTimeCacheDelegate UpdateMissionTimeCache
	- event ResetMissionDelegate ResetMission
	- event OnSceneCreatedDelegate OnSceneCreated
	- event TickAgentsAndTeamsDelegate TickAgentsAndTeams

## Module:
	- event InitializeDelegate Initialize
	- event RunTestDelegate RunTest
	- event TickTestDelegate TickTest
	- event OnDumpCreatedDelegate OnDumpCreated
	- event OnDumpCreationStartedDelegate OnDumpCreationStarted
	- event GetMetaMeshPackageMappingDelegate GetMetaMeshPackageMapping
	- event GetItemMeshNamesDelegate GetItemMeshNames
	- event GetHorseMaterialNamesDelegate GetHorseMaterialNames
	- event SetEditorScreenAsRootScreenDelegate SetEditorScreenAsRootScreen
	- event GetMissionControllerClassNamesDelegate GetMissionControllerClassNames
	- event MBThrowExceptionDelegate MBThrowException
	- event OnEnterEditModeDelegate OnEnterEditMode
	- event GetInstanceDelegate GetInstance
	- event GetGameStatusDelegate GetGameStatus
	- event SetLoadingFinishedDelegate SetLoadingFinished
	- event OnCloseSceneEditorPresentationDelegate OnCloseSceneEditorPresentation
	- event OnSceneEditorModeOverDelegate OnSceneEditorModeOver
	- event OnSkinsXMLHasChangedDelegate OnSkinsXMLHasChanged
	- event OnImguiProfilerTickDelegate OnImguiProfilerTick
	- event CreateProcessedSkinsXMLForNativeDelegate CreateProcessedSkinsXMLForNative
	- event CreateProcessedActionSetsXMLForNativeDelegate CreateProcessedActionSetsXMLForNative
	- event CreateProcessedActionTypesXMLForNativeDelegate CreateProcessedActionTypesXMLForNative
	- event CreateProcessedAnimationsXMLForNativeDelegate CreateProcessedAnimationsXMLForNative
	- event CreateProcessedVoiceDefinitionsXMLForNativeDelegate CreateProcessedVoiceDefinitionsXMLForNative
	- event CreateProcessedModuleDataXMLForNativeDelegate CreateProcessedModuleDataXMLForNative
	- event StartMissionForEditorDelegate StartMissionForEditor
	- event StartMissionForReplayEditorDelegate StartMissionForReplayEditor

## NativeObject:
	- event GetAliveNativeObjectCountDelegate GetAliveNativeObjectCount
	- event GetAliveNativeObjectNamesDelegate GetAliveNativeObjectNames

## NativeParallelDriver:
	- event ParalelForLoopBodyCallerDelegate ParalelForLoopBodyCaller
	- event ParalelForLoopBodyWithDtCallerDelegate ParalelForLoopBodyWithDtCaller

## RenderTargetComponent:
	- event CreateRenderTargetComponentDelegate CreateRenderTargetComponent
	- event OnPaintNeededDelegate OnPaintNeeded

## SceneProblemChecker:
	- event OnCheckForSceneProblemsDelegate OnCheckForSceneProblems

## ScriptComponentBehavior:
	- event AddScriptComponentToTickDelegate AddScriptComponentToTick
	- event RegisterAsPrefabScriptComponentDelegate RegisterAsPrefabScriptComponent
	- event DeregisterAsPrefabScriptComponentDelegate DeregisterAsPrefabScriptComponent
	- event RegisterAsUndoStackScriptComponentDelegate RegisterAsUndoStackScriptComponent
	- event DeregisterAsUndoStackScriptComponentDelegate DeregisterAsUndoStackScriptComponent
	- event SetSceneDelegate SetScene
	- event OnInitDelegate OnInit
	- event HandleOnRemovedDelegate HandleOnRemoved
	- event OnPreInitDelegate OnPreInit
	- event OnEditorInitDelegate OnEditorInit
	- event OnEditorTickDelegate OnEditorTick
	- event OnEditorValidateDelegate OnEditorValidate
	- event IsOnlyVisualDelegate IsOnlyVisual
	- event MovesEntityDelegate MovesEntity
	- event DisablesOroCreationDelegate DisablesOroCreation
	- event OnEditorVariableChangedDelegate OnEditorVariableChanged
	- event OnSceneSaveDelegate OnSceneSave
	- event ## OnPhysicsCollisionDelegate
	- event OnEditModeVisibilityChangedDelegate OnEditModeVisibilityChanged
	- event GetEditableFieldsDelegate GetEditableFields

## ThumbnailCreatorView:
	- event OnThumbnailRenderCompleteDelegate OnThumbnailRenderComplete

## WeaponComponentMissionExtensions:
	- event CalculateCenterOfMassDelegate CalculateCenterOfMass
