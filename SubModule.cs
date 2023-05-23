using TaleWorlds.MountAndBlade;

namespace BannerlordUnlocked {
    public class SubModule : MBSubModuleBase {

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
            NativeManager.CollectReferences(generateCode: true);
        }
    }
}