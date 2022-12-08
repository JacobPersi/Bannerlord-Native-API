
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
    public static class IParticleSystem {
    
    public static void SetEnable( UIntPtr psysPointer ,  Boolean enable ) {
          NativeManager.OutboundManifest["IParticleSystem"]["SetEnable"]
        .DynamicInvoke(new object[] {  psysPointer ,  enable  } );
    }

    public static void SetRuntimeEmissionRateMultiplier( UIntPtr pointer ,  Single multiplier ) {
          NativeManager.OutboundManifest["IParticleSystem"]["SetRuntimeEmissionRateMultiplier"]
        .DynamicInvoke(new object[] {  pointer ,  multiplier  } );
    }

    public static void Restart( UIntPtr psysPointer ) {
          NativeManager.OutboundManifest["IParticleSystem"]["Restart"]
        .DynamicInvoke(new object[] {  psysPointer  } );
    }

    public static void SetLocalFrame( UIntPtr pointer ,   ref MatrixFrame newFrame ) {
          NativeManager.OutboundManifest["IParticleSystem"]["SetLocalFrame"]
        .DynamicInvoke(new object[] {  pointer ,  newFrame  } );
    }

    public static void GetLocalFrame( UIntPtr pointer ,   ref MatrixFrame frame ) {
          NativeManager.OutboundManifest["IParticleSystem"]["GetLocalFrame"]
        .DynamicInvoke(new object[] {  pointer ,  frame  } );
    }

    public static Int32 GetRuntimeIdByName( Byte[] particleSystemName ) {
         return   (Int32)  NativeManager.OutboundManifest["IParticleSystem"]["GetRuntimeIdByName"]
        .DynamicInvoke(new object[] {  particleSystemName  } );
    }

    public static NativeObjectPointer CreateParticleSystemAttachedToBone( Int32 runtimeId ,  UIntPtr skeletonPtr ,  SByte boneIndex ,   ref MatrixFrame boneLocalFrame ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IParticleSystem"]["CreateParticleSystemAttachedToBone"]
        .DynamicInvoke(new object[] {  runtimeId ,  skeletonPtr ,  boneIndex ,  boneLocalFrame  } );
    }

    public static NativeObjectPointer CreateParticleSystemAttachedToEntity( Int32 runtimeId ,  UIntPtr entityPtr ,   ref MatrixFrame boneLocalFrame ) {
         return   (NativeObjectPointer)  NativeManager.OutboundManifest["IParticleSystem"]["CreateParticleSystemAttachedToEntity"]
        .DynamicInvoke(new object[] {  runtimeId ,  entityPtr ,  boneLocalFrame  } );
    }

    public static void SetParticleEffectByName( UIntPtr pointer ,  Byte[] effectName ) {
          NativeManager.OutboundManifest["IParticleSystem"]["SetParticleEffectByName"]
        .DynamicInvoke(new object[] {  pointer ,  effectName  } );
    }

    }
}