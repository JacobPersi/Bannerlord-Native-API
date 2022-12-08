
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
    public static class IMBFaceGen {
    
    public static Int32 GetNumEditableDeformKeys( Int32 race ,  Boolean initialGender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetNumEditableDeformKeys"]
        .DynamicInvoke(new object[] {  race ,  initialGender ,  age  } );
    }

    public static void GetParamsFromKey(  ref FaceGenerationParams faceGenerationParams ,   ref BodyProperties bodyProperties ,  Boolean earsAreHidden ,  Boolean mouthHidden ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetParamsFromKey"]
        .DynamicInvoke(new object[] {  faceGenerationParams ,  bodyProperties ,  earsAreHidden ,  mouthHidden  } );
    }

    public static void GetParamsMax( Int32 race ,  Int32 curGender ,  Single curAge ,   ref Int32 hairNum ,   ref Int32 beardNum ,   ref Int32 faceTextureNum ,   ref Int32 mouthTextureNum ,   ref Int32 faceTattooNum ,   ref Int32 soundNum ,   ref Int32 eyebrowNum ,   ref Single scale ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetParamsMax"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  curAge ,  hairNum ,  beardNum ,  faceTextureNum ,  mouthTextureNum ,  faceTattooNum ,  soundNum ,  eyebrowNum ,  scale  } );
    }

    public static void GetZeroProbabilities( Int32 race ,  Int32 curGender ,  Single curAge ,   ref Single tattooZeroProbability ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetZeroProbabilities"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  curAge ,  tattooZeroProbability  } );
    }

    public static void ProduceNumericKeyWithParams(  ref FaceGenerationParams faceGenerationParams ,  Boolean earsAreHidden ,  Boolean mouthIsHidden ,   ref BodyProperties bodyProperties ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["ProduceNumericKeyWithParams"]
        .DynamicInvoke(new object[] {  faceGenerationParams ,  earsAreHidden ,  mouthIsHidden ,  bodyProperties  } );
    }

    public static void ProduceNumericKeyWithDefaultValues(  ref BodyProperties initialBodyProperties ,  Boolean earsAreHidden ,  Boolean mouthIsHidden ,  Int32 race ,  Int32 gender ,  Single age ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["ProduceNumericKeyWithDefaultValues"]
        .DynamicInvoke(new object[] {  initialBodyProperties ,  earsAreHidden ,  mouthIsHidden ,  race ,  gender ,  age  } );
    }

    public static void TransformFaceKeysToDefaultFace(  ref FaceGenerationParams faceGenerationParams ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["TransformFaceKeysToDefaultFace"]
        .DynamicInvoke(new object[] {  faceGenerationParams  } );
    }

    public static void GetRandomBodyProperties( Int32 race ,  Int32 gender ,   ref BodyProperties bodyPropertiesMin ,   ref BodyProperties bodyPropertiesMax ,  Int32 hairCoverType ,  Int32 seed ,  Byte[] hairTags ,  Byte[] beardTags ,  Byte[] tatooTags ,   ref BodyProperties outBodyProperties ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetRandomBodyProperties"]
        .DynamicInvoke(new object[] {  race ,  gender ,  bodyPropertiesMin ,  bodyPropertiesMax ,  hairCoverType ,  seed ,  hairTags ,  beardTags ,  tatooTags ,  outBodyProperties  } );
    }

    public static Boolean EnforceConstraints(  ref FaceGenerationParams faceGenerationParams ) {
         return   (Boolean)  NativeManager.OutboundManifest["IMBFaceGen"]["EnforceConstraints"]
        .DynamicInvoke(new object[] {  faceGenerationParams  } );
    }

    public static void GetDeformKeyData( Int32 keyNo ,   ref DeformKeyData deformKeyData ,  Int32 race ,  Int32 gender ,  Single age ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetDeformKeyData"]
        .DynamicInvoke(new object[] {  keyNo ,  deformKeyData ,  race ,  gender ,  age  } );
    }

    public static Int32 GetFaceGenInstancesLength( Int32 race ,  Int32 gender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetFaceGenInstancesLength"]
        .DynamicInvoke(new object[] {  race ,  gender ,  age  } );
    }

    public static Single GetScaleFromKey( Int32 race ,  Int32 gender ,   ref BodyProperties initialBodyProperties ) {
         return   (Single)  NativeManager.OutboundManifest["IMBFaceGen"]["GetScaleFromKey"]
        .DynamicInvoke(new object[] {  race ,  gender ,  initialBodyProperties  } );
    }

    public static Int32 GetVoiceRecordsCount( Int32 race ,  Int32 curGender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetVoiceRecordsCount"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age  } );
    }

    public static Int32 GetHairColorCount( Int32 race ,  Int32 curGender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetHairColorCount"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age  } );
    }

    public static void GetHairColorGradientPoints( Int32 race ,  Int32 curGender ,  Single age ,  IntPtr colors ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetHairColorGradientPoints"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age ,  colors  } );
    }

    public static Int32 GetTatooColorCount( Int32 race ,  Int32 curGender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetTatooColorCount"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age  } );
    }

    public static void GetTatooColorGradientPoints( Int32 race ,  Int32 curGender ,  Single age ,  IntPtr colors ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetTatooColorGradientPoints"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age ,  colors  } );
    }

    public static Int32 GetSkinColorCount( Int32 race ,  Int32 curGender ,  Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetSkinColorCount"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age  } );
    }

    public static Int32 GetMaturityType( Single age ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetMaturityType"]
        .DynamicInvoke(new object[] {  age  } );
    }

    public static void GetVoiceTypeUsableForPlayerData( Int32 race ,  Int32 curGender ,  Single age ,  IntPtr aiArray ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetVoiceTypeUsableForPlayerData"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age ,  aiArray  } );
    }

    public static void GetSkinColorGradientPoints( Int32 race ,  Int32 curGender ,  Single age ,  IntPtr colors ) {
          NativeManager.OutboundManifest["IMBFaceGen"]["GetSkinColorGradientPoints"]
        .DynamicInvoke(new object[] {  race ,  curGender ,  age ,  colors  } );
    }

    public static Int32 GetRaceIds() {
         return   (Int32)  NativeManager.OutboundManifest["IMBFaceGen"]["GetRaceIds"]
        .DynamicInvoke(new object[] {  } );
    }

    }
}