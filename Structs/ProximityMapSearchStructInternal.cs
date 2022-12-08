using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace BannerlordUnlocked {
    public struct ProximityMapSearchStructInternal {
        public int CurrentElementIndex;
        public Vec2i Loc;
        public Vec2i GridMin;
        public Vec2i GridMax;
        public Vec2 SearchPos;
        public float SearchDistSq;
        public Agent GetCurrentAgent() => Mission.Current.FindAgentWithIndex(this.CurrentElementIndex);
    }
}
