using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AdjacentBuildingBonusTracker
	{
		private readonly AssetModuleHolder<BaseBuildingUpgradeModule> _bonusModules;

		private readonly BuildingRuntime _buildingRuntime;

		private readonly IReadOnlyList<BuildingSlot> _neighborSlots;

		private readonly BaseBuildingData _targetBuildingData;

		private readonly Dictionary<UnitStatType, float> _appliedUnitMultipliers;

		private readonly Dictionary<AbilityStatType, float> _appliedAbilityMultipliers;

		private readonly Dictionary<UnitStatType, float> _appliedUnitAdditives;

		private readonly Dictionary<AbilityStatType, float> _appliedAbilityAdditives;

		public int CurrentCount { get; private set; }

		public event Action<int> OnCountChanged
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

		public AdjacentBuildingBonusTracker(AssetModuleHolder<BaseBuildingUpgradeModule> bonusModules, BuildingRuntime buildingRuntime, IReadOnlyList<BuildingSlot> neighborSlots, BaseBuildingData targetBuildingData)
		{
		}

		public void Recalculate()
		{
		}

		public void RestoreCount()
		{
		}

		public void Dispose()
		{
		}

		private void SubscribeToSlots()
		{
		}

		private void UnsubscribeFromSlots()
		{
		}

		private void OnNeighborBuildingChanged(BaseBuilding _)
		{
		}

		private int CountAdjacentBuildings()
		{
			return 0;
		}

		private void SyncAppliedMultipliers(int buildingCount)
		{
		}

		private void ApplyDeltaModifiers(int buildingCount)
		{
		}

		private void ApplyUnitStatDelta(MultiplyStatUnitBuildingUpgradeModule module, int buildingCount)
		{
		}

		private void ApplyAbilityStatDelta(MultiplyStatAbilityBuildingUpgradeModule module, int buildingCount)
		{
		}

		private void ApplyAddUnitStatDelta(AddStatUnitBuildingUpgradeModule module, int buildingCount)
		{
		}

		private void ApplyAddAbilityStatDelta(AddStatAbilityBuildingUpgradeModule module, int buildingCount)
		{
		}
	}
}
