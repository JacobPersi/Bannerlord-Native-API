
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
    public static class IConfig {
    
    public static Boolean CheckGFXSupportStatus( Int32 enum_id ) {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["CheckGFXSupportStatus"]
        .DynamicInvoke(new object[] {  enum_id  } );
    }

    public static Boolean IsDlssAvailable() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["IsDlssAvailable"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean Is120HzAvailable() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["Is120HzAvailable"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDlssTechnique() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetDlssTechnique"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDlssOptionCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetDlssOptionCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetDisableSound() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetDisableSound"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetCheatMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetCheatMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetDevelopmentMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetDevelopmentMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetLocalizationDebugMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetLocalizationDebugMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetDoLocalizationCheckAtStartup() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetDoLocalizationCheckAtStartup"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetTableauCacheMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetTableauCacheMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetEnableEditMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetEnableEditMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetEnableClothSimulation() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetEnableClothSimulation"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetCharacterDetail() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetCharacterDetail"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetInvertMouse() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetInvertMouse"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetLastOpenedScene() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetLastOpenedScene"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void ReadRGLConfigFiles() {
          NativeManager.OutboundManifest["IConfig"]["ReadRGLConfigFiles"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetRGLConfig( Int32 type ,  Single value ) {
          NativeManager.OutboundManifest["IConfig"]["SetRGLConfig"]
        .DynamicInvoke(new object[] {  type ,  value  } );
    }

    public static void ApplyConfigChanges( Boolean resizeWindow ) {
          NativeManager.OutboundManifest["IConfig"]["ApplyConfigChanges"]
        .DynamicInvoke(new object[] {  resizeWindow  } );
    }

    public static Single GetRGLConfigForDefaultSettings( Int32 type ,  Int32 defaultSettings ) {
         return   (Single)  NativeManager.OutboundManifest["IConfig"]["GetRGLConfigForDefaultSettings"]
        .DynamicInvoke(new object[] {  type ,  defaultSettings  } );
    }

    public static Single GetRGLConfig( Int32 type ) {
         return   (Single)  NativeManager.OutboundManifest["IConfig"]["GetRGLConfig"]
        .DynamicInvoke(new object[] {  type  } );
    }

    public static Single GetDefaultRGLConfig( Int32 type ) {
         return   (Single)  NativeManager.OutboundManifest["IConfig"]["GetDefaultRGLConfig"]
        .DynamicInvoke(new object[] {  type  } );
    }

    public static Int32 SaveRGLConfig() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["SaveRGLConfig"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetBrightness( Single brightness ) {
          NativeManager.OutboundManifest["IConfig"]["SetBrightness"]
        .DynamicInvoke(new object[] {  brightness  } );
    }

    public static void SetSharpenAmount( Single sharpen_amount ) {
          NativeManager.OutboundManifest["IConfig"]["SetSharpenAmount"]
        .DynamicInvoke(new object[] {  sharpen_amount  } );
    }

    public static Int32 GetSoundDeviceName( Int32 i ) {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetSoundDeviceName"]
        .DynamicInvoke(new object[] {  i  } );
    }

    public static Int32 GetCurrentSoundDeviceIndex() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetCurrentSoundDeviceIndex"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetSoundDeviceCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetSoundDeviceCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetResolutionCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetResolutionCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetRefreshRateCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetRefreshRateCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetRefreshRateAtIndex( Int32 index ) {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetRefreshRateAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void GetResolution(  ref Int32 width ,   ref Int32 height ) {
          NativeManager.OutboundManifest["IConfig"]["GetResolution"]
        .DynamicInvoke(new object[] {  width ,  height  } );
    }

    public static void GetDesktopResolution(  ref Int32 width ,   ref Int32 height ) {
          NativeManager.OutboundManifest["IConfig"]["GetDesktopResolution"]
        .DynamicInvoke(new object[] {  width ,  height  } );
    }

    public static Vec2 GetResolutionAtIndex( Int32 index ) {
         return   (Vec2)  NativeManager.OutboundManifest["IConfig"]["GetResolutionAtIndex"]
        .DynamicInvoke(new object[] {  index  } );
    }

    public static void SetCustomResolution( Int32 width ,  Int32 height ) {
          NativeManager.OutboundManifest["IConfig"]["SetCustomResolution"]
        .DynamicInvoke(new object[] {  width ,  height  } );
    }

    public static void RefreshOptionsData() {
          NativeManager.OutboundManifest["IConfig"]["RefreshOptionsData"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetSoundDevice( Int32 i ) {
          NativeManager.OutboundManifest["IConfig"]["SetSoundDevice"]
        .DynamicInvoke(new object[] {  i  } );
    }

    public static void Apply( Int32 texture_budget ,  Int32 sharpen_amount ,  Int32 hdr ,  Int32 dof_mode ,  Int32 motion_blur ,  Int32 ssr ,  Int32 size ,  Int32 texture_filtering ,  Int32 trail_amount ,  Int32 dynamic_resolution_target ) {
          NativeManager.OutboundManifest["IConfig"]["Apply"]
        .DynamicInvoke(new object[] {  texture_budget ,  sharpen_amount ,  hdr ,  dof_mode ,  motion_blur ,  ssr ,  size ,  texture_filtering ,  trail_amount ,  dynamic_resolution_target  } );
    }

    public static void SetDefaultGameConfig() {
          NativeManager.OutboundManifest["IConfig"]["SetDefaultGameConfig"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 AutoSaveInMinutes() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["AutoSaveInMinutes"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetUIDebugMode() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetUIDebugMode"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetUIDoNotUseGeneratedPrefabs() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetUIDoNotUseGeneratedPrefabs"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDebugLoginUserName() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetDebugLoginUserName"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetDebugLoginPassword() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetDebugLoginPassword"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean GetDisableGuiMessages() {
         return   (Boolean)  NativeManager.OutboundManifest["IConfig"]["GetDisableGuiMessages"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetAutoGFXQuality() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetAutoGFXQuality"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetAutoConfigWrtHardware() {
          NativeManager.OutboundManifest["IConfig"]["SetAutoConfigWrtHardware"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetMonitorDeviceName( Int32 i ) {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetMonitorDeviceName"]
        .DynamicInvoke(new object[] {  i  } );
    }

    public static Int32 GetVideoDeviceName( Int32 i ) {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetVideoDeviceName"]
        .DynamicInvoke(new object[] {  i  } );
    }

    public static Int32 GetMonitorDeviceCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetMonitorDeviceCount"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Int32 GetVideoDeviceCount() {
         return   (Int32)  NativeManager.OutboundManifest["IConfig"]["GetVideoDeviceCount"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}