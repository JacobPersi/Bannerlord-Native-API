using System.Runtime.InteropServices;

namespace BannerlordUnlocked {
    public struct EngineClassTypeDefinition {
        public int TypeId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string TypeName;
    }
}
