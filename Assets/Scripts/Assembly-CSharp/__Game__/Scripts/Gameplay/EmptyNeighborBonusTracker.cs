using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class EmptyNeighborBonusTracker
	{
		private readonly AssetModuleHolder<BaseBuildingUpgradeModule> _bonusModules;

		private readonly BuildingRuntime _buildingRuntime;

		private readonly BuildingSlot _buildingSlot;

		private readonly Dictionary<UnitStatType, float> _appliedMultipliers;

		public int CurrentEmptyCount { get; private set; }

		public event Action<int> OnEmptyCountChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public EmptyNeighborBonusTracker(AssetModuleHolder<BaseBuildingUpgradeModule> bonusModules, BuildingRuntime buildingRuntime, BuildingSlot buildingSlot)
		{
		}

		public void ApplyCurrentCount()
		{
		}

		public void RestoreEmptyNeighborCount()
		{
		}

		public void Dispose()
		{
		}

		private void HandleEmptyNeighborCountChanged(int emptyCount)
		{
		}

		private void UpdateEmptyNeighborCount(int emptyCount)
		{
		}

		private void SyncAppliedMultipliers(int emptyCount)
		{
		}

		private void ApplyDeltaModifiers(int emptyCount)
		{
		}
	}
}
