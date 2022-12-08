
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
    public static class IImgui {
    
    public static void BeginMainThreadScope() {
          NativeManager.OutboundManifest["IImgui"]["BeginMainThreadScope"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void EndMainThreadScope() {
          NativeManager.OutboundManifest["IImgui"]["EndMainThreadScope"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void PushStyleColor( Int32 style ,   ref Vec3 color ) {
          NativeManager.OutboundManifest["IImgui"]["PushStyleColor"]
        .DynamicInvoke(new object[] {  style ,  color  } );
    }

    public static void PopStyleColor() {
          NativeManager.OutboundManifest["IImgui"]["PopStyleColor"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void NewFrame() {
          NativeManager.OutboundManifest["IImgui"]["NewFrame"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void Render() {
          NativeManager.OutboundManifest["IImgui"]["Render"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void Begin( Byte[] text ) {
          NativeManager.OutboundManifest["IImgui"]["Begin"]
        .DynamicInvoke(new object[] {  text  } );
    }

    public static void BeginWithCloseButton( Byte[] text ,   ref Boolean is_open ) {
          NativeManager.OutboundManifest["IImgui"]["BeginWithCloseButton"]
        .DynamicInvoke(new object[] {  text ,  is_open  } );
    }

    public static void End() {
          NativeManager.OutboundManifest["IImgui"]["End"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void Text( Byte[] text ) {
          NativeManager.OutboundManifest["IImgui"]["Text"]
        .DynamicInvoke(new object[] {  text  } );
    }

    public static Boolean Checkbox( Byte[] text ,   ref Boolean is_checked ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["Checkbox"]
        .DynamicInvoke(new object[] {  text ,  is_checked  } );
    }

    public static Boolean TreeNode( Byte[] name ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["TreeNode"]
        .DynamicInvoke(new object[] {  name  } );
    }

    public static void TreePop() {
          NativeManager.OutboundManifest["IImgui"]["TreePop"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void Separator() {
          NativeManager.OutboundManifest["IImgui"]["Separator"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean Button( Byte[] text ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["Button"]
        .DynamicInvoke(new object[] {  text  } );
    }

    public static void PlotLines( Byte[] name ,  IntPtr values ,  Int32 valuesCount ,  Int32 valuesOffset ,  Byte[] overlayText ,  Single minScale ,  Single maxScale ,  Single graphWidth ,  Single graphHeight ,  Int32 stride ) {
          NativeManager.OutboundManifest["IImgui"]["PlotLines"]
        .DynamicInvoke(new object[] {  name ,  values ,  valuesCount ,  valuesOffset ,  overlayText ,  minScale ,  maxScale ,  graphWidth ,  graphHeight ,  stride  } );
    }

    public static void ProgressBar( Single value ) {
          NativeManager.OutboundManifest["IImgui"]["ProgressBar"]
        .DynamicInvoke(new object[] {  value  } );
    }

    public static void NewLine() {
          NativeManager.OutboundManifest["IImgui"]["NewLine"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SameLine( Single posX ,  Single spacingWidth ) {
          NativeManager.OutboundManifest["IImgui"]["SameLine"]
        .DynamicInvoke(new object[] {  posX ,  spacingWidth  } );
    }

    public static Boolean Combo( Byte[] label ,   ref Int32 selectedIndex ,  Byte[] items ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["Combo"]
        .DynamicInvoke(new object[] {  label ,  selectedIndex ,  items  } );
    }

    public static Boolean InputInt( Byte[] label ,   ref Int32 value ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["InputInt"]
        .DynamicInvoke(new object[] {  label ,  value  } );
    }

    public static Boolean SliderFloat( Byte[] label ,   ref Single value ,  Single min ,  Single max ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["SliderFloat"]
        .DynamicInvoke(new object[] {  label ,  value ,  min ,  max  } );
    }

    public static void Columns( Int32 count ,  Byte[] id ,  Boolean border ) {
          NativeManager.OutboundManifest["IImgui"]["Columns"]
        .DynamicInvoke(new object[] {  count ,  id ,  border  } );
    }

    public static void NextColumn() {
          NativeManager.OutboundManifest["IImgui"]["NextColumn"]
        .DynamicInvoke(new object[] {  } );
    }

    public static Boolean RadioButton( Byte[] label ,  Boolean active ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["RadioButton"]
        .DynamicInvoke(new object[] {  label ,  active  } );
    }

    public static Boolean CollapsingHeader( Byte[] label ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["CollapsingHeader"]
        .DynamicInvoke(new object[] {  label  } );
    }

    public static Boolean IsItemHovered() {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["IsItemHovered"]
        .DynamicInvoke(new object[] {  } );
    }

    public static void SetTooltip( Byte[] label ) {
          NativeManager.OutboundManifest["IImgui"]["SetTooltip"]
        .DynamicInvoke(new object[] {  label  } );
    }

    public static Boolean SmallButton( Byte[] label ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["SmallButton"]
        .DynamicInvoke(new object[] {  label  } );
    }

    public static Boolean InputFloat( Byte[] label ,   ref Single val ,  Single step ,  Single stepFast ,  Int32 decimalPrecision ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["InputFloat"]
        .DynamicInvoke(new object[] {  label ,  val ,  step ,  stepFast ,  decimalPrecision  } );
    }

    public static Boolean InputFloat2( Byte[] label ,   ref Single val0 ,   ref Single val1 ,  Int32 decimalPrecision ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["InputFloat2"]
        .DynamicInvoke(new object[] {  label ,  val0 ,  val1 ,  decimalPrecision  } );
    }

    public static Boolean InputFloat3( Byte[] label ,   ref Single val0 ,   ref Single val1 ,   ref Single val2 ,  Int32 decimalPrecision ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["InputFloat3"]
        .DynamicInvoke(new object[] {  label ,  val0 ,  val1 ,  val2 ,  decimalPrecision  } );
    }

    public static Boolean InputFloat4( Byte[] label ,   ref Single val0 ,   ref Single val1 ,   ref Single val2 ,   ref Single val3 ,  Int32 decimalPrecision ) {
         return   (Boolean)  NativeManager.OutboundManifest["IImgui"]["InputFloat4"]
        .DynamicInvoke(new object[] {  label ,  val0 ,  val1 ,  val2 ,  val3 ,  decimalPrecision  } );
    }

    }
}