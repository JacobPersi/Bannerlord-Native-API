
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
    public static class IMBVoiceManager {
    
    public static Int32 GetVoiceTypeIndex( Byte[] voiceType ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBVoiceManager"]["GetVoiceTypeIndex"]
        .DynamicInvoke(new object[] {  voiceType  } );
    }

    public static Int32 GetVoiceDefinitionCountWithMonsterSoundAndCollisionInfoClassName( Byte[] className ) {
         return   (Int32)  NativeManager.OutboundManifest["IMBVoiceManager"]["GetVoiceDefinitionCountWithMonsterSoundAndCollisionInfoClassName"]
        .DynamicInvoke(new object[] {  className  } );
    }

    public static void GetVoiceDefinitionListWithMonsterSoundAndCollisionInfoClassName( Byte[] className ,  IntPtr definitionIndices ) {
          NativeManager.OutboundManifest["IMBVoiceManager"]["GetVoiceDefinitionListWithMonsterSoundAndCollisionInfoClassName"]
        .DynamicInvoke(new object[] {  className ,  definitionIndices  } );
    }

    }
}