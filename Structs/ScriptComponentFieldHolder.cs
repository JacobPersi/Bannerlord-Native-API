using System;
using System.Runtime.InteropServices;
using TaleWorlds.Library;

namespace BannerlordUnlocked {
    public struct ScriptComponentFieldHolder {
        public double d;
        public float f;
        public int b;
        public int i;
        public Vec3 v3;
        public UIntPtr entityPointer;
        public UIntPtr texturePointer;
        public UIntPtr meshPointer;
        public UIntPtr materialPointer;
        public Vec3 color;
        public MatrixFrame matrixFrame;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string s;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string enumValue;
    }
}
