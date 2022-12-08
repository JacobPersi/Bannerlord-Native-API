using System;
using System.Runtime.InteropServices;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace BannerlordUnlocked {
    public struct WeaponDataAsNative {
        public UIntPtr WeaponMesh;
        public UIntPtr HolsterMesh;
        public UIntPtr HolsterMeshWithWeapon;
        public UIntPtr FlyingMesh;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]   
        public string Prefab;
        public UIntPtr Body;
        public UIntPtr CollisionBody;
        public UIntPtr TableauMaterial;
        public MatrixFrame WeaponFrame;
        public int PhysicsMaterialIndex;
        public int WeaponKind;
        public StackArray.StackArray4Int ItemHolsterIndices;
        public int Difficulty;
        public float BaseWeight;
        public float Inertia;
        public short ReloadPhase;
        [MarshalAs(UnmanagedType.U1)]
        public bool HasFlagAnimation;
        public Vec3 AmmoOffset;
        public MatrixFrame StickingFrame;
        public float ScaleFactor;
        public float CenterOfMass;
        public Vec3 CenterOfMassXYZ;
        public Vec3 HolsterPositionShift;
        public int FlyingSoundCode;
        public int PassbySoundCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string TrailParticleName;
        public Vec3 CenterOfMassShift;
        public short DataValue;
        public int CurrentUsageIndex;
        public float AirFrictionConstant;
        public bool HasLowerHolsterPriority;
        public float GlossMultiplier;

        public WeaponDataAsNative(WeaponData weaponData) {
            this.WeaponMesh = ((weaponData.WeaponMesh != null) ? NativeManager.GetNativePtr(weaponData.WeaponMesh) : UIntPtr.Zero);
            this.HolsterMesh = ((weaponData.HolsterMesh != null) ? NativeManager.GetNativePtr(weaponData.HolsterMesh) : UIntPtr.Zero);
            this.Prefab = weaponData.Prefab;
            this.HolsterMeshWithWeapon = ((weaponData.HolsterMeshWithWeapon != null) ? NativeManager.GetNativePtr(weaponData.HolsterMeshWithWeapon) : UIntPtr.Zero);
            this.FlyingMesh = ((weaponData.FlyingMesh != null) ? NativeManager.GetNativePtr(weaponData.FlyingMesh) : UIntPtr.Zero);
            this.Body = ((weaponData.Shape != null) ? NativeManager.GetNativePtr(weaponData.Shape) : UIntPtr.Zero);
            this.CollisionBody = ((weaponData.CollisionShape != null) ? NativeManager.GetNativePtr(weaponData.CollisionShape) : UIntPtr.Zero);
            this.TableauMaterial = ((weaponData.TableauMaterial != null) ? NativeManager.GetNativePtr(weaponData.TableauMaterial) : UIntPtr.Zero);
            this.WeaponFrame = weaponData.WeaponFrame;
            this.PhysicsMaterialIndex = weaponData.PhysicsMaterialIndex;
            this.WeaponKind = weaponData.WeaponKind;
            this.ItemHolsterIndices = weaponData.ItemHolsterIndices;
            this.Difficulty = weaponData.Difficulty;
            this.BaseWeight = weaponData.BaseWeight;
            this.Inertia = weaponData.Inertia;
            this.ReloadPhase = weaponData.ReloadPhase;
            this.HasFlagAnimation = weaponData.HasFlagAnimation;
            this.AmmoOffset = weaponData.AmmoOffset;
            this.StickingFrame = weaponData.StickingFrame;
            this.ScaleFactor = weaponData.ScaleFactor;
            this.CenterOfMass = weaponData.CenterOfMass;
            this.CenterOfMassXYZ = weaponData.CenterOfMass3D;
            this.HolsterPositionShift = weaponData.HolsterPositionShift;
            this.FlyingSoundCode = weaponData.FlyingSoundCode;
            this.PassbySoundCode = weaponData.PassbySoundCode;
            this.TrailParticleName = weaponData.TrailParticleName;
            this.CenterOfMassShift = weaponData.CenterOfMassShift;
            this.DataValue = weaponData.DataValue;
            this.CurrentUsageIndex = weaponData.CurrentUsageIndex;
            this.AirFrictionConstant = weaponData.AirFrictionConstant;
            this.HasLowerHolsterPriority = weaponData.HasLowerHolsterPriority;
            this.GlossMultiplier = weaponData.GlossMultiplier;
        }

        public static implicit operator WeaponData(WeaponDataAsNative agentEntityDataAsNative) {
            return new WeaponData {
                WeaponMesh = ((agentEntityDataAsNative.WeaponMesh != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<MetaMesh>(agentEntityDataAsNative.WeaponMesh) : null),
                HolsterMesh = ((agentEntityDataAsNative.HolsterMesh != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<MetaMesh>(agentEntityDataAsNative.HolsterMesh) : null),
                Prefab = agentEntityDataAsNative.Prefab,
                HolsterMeshWithWeapon = ((agentEntityDataAsNative.HolsterMeshWithWeapon != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<MetaMesh>(agentEntityDataAsNative.HolsterMeshWithWeapon) : null),
                FlyingMesh = ((agentEntityDataAsNative.FlyingMesh != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<MetaMesh>(agentEntityDataAsNative.FlyingMesh) : null),
                Shape = ((agentEntityDataAsNative.Body != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<PhysicsShape>(agentEntityDataAsNative.Body) : null),
                CollisionShape = ((agentEntityDataAsNative.CollisionBody != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<PhysicsShape>(agentEntityDataAsNative.CollisionBody) : null),
                TableauMaterial = ((agentEntityDataAsNative.TableauMaterial != UIntPtr.Zero) ? NativeManager.ConstrutFromNativePointer<Material>(agentEntityDataAsNative.TableauMaterial) : null),
                WeaponFrame = agentEntityDataAsNative.WeaponFrame,
                PhysicsMaterialIndex = agentEntityDataAsNative.PhysicsMaterialIndex,
                WeaponKind = agentEntityDataAsNative.WeaponKind,
                ItemHolsterIndices = agentEntityDataAsNative.ItemHolsterIndices,
                Difficulty = agentEntityDataAsNative.Difficulty,
                BaseWeight = agentEntityDataAsNative.BaseWeight,
                Inertia = agentEntityDataAsNative.Inertia,
                ReloadPhase = agentEntityDataAsNative.ReloadPhase,
                HasFlagAnimation = agentEntityDataAsNative.HasFlagAnimation,
                AmmoOffset = agentEntityDataAsNative.AmmoOffset,
                StickingFrame = agentEntityDataAsNative.StickingFrame,
                ScaleFactor = agentEntityDataAsNative.ScaleFactor,
                CenterOfMass = agentEntityDataAsNative.CenterOfMass,
                CenterOfMass3D = agentEntityDataAsNative.CenterOfMassXYZ,
                HolsterPositionShift = agentEntityDataAsNative.HolsterPositionShift,
                FlyingSoundCode = agentEntityDataAsNative.FlyingSoundCode,
                PassbySoundCode = agentEntityDataAsNative.PassbySoundCode,
                TrailParticleName = agentEntityDataAsNative.TrailParticleName,
                CenterOfMassShift = agentEntityDataAsNative.CenterOfMassShift,
                DataValue = agentEntityDataAsNative.DataValue,
                CurrentUsageIndex = agentEntityDataAsNative.CurrentUsageIndex,
                AirFrictionConstant = agentEntityDataAsNative.AirFrictionConstant,
                HasLowerHolsterPriority = agentEntityDataAsNative.HasLowerHolsterPriority,
                GlossMultiplier = agentEntityDataAsNative.GlossMultiplier
            };
        }
    }
}
