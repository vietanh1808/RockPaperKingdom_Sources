using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AdjacentUnitsCountBonusTracker
	{
		private readonly AssetModuleHolder<BaseBuildingUpgradeModule> _bonusModules;

		private readonly BuildingRuntime _buildingRuntime;

		private readonly IReadOnlyList<BuildingSlot> _neighborSlots;

		private readonly Dictionary<UnitStatType, float> _appliedUnitMultipliers;

		private readonly Dictionary<AbilityStatType, float> _appliedAbilityMultipliers;

		private readonly Dictionary<BuildingSlot, StatValue> _subscribedStats;

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

		public AdjacentUnitsCountBonusTracker(AssetModuleHolder<BaseBuildingUpgradeModule> bonusModules, BuildingRuntime buildingRuntime, IReadOnlyList<BuildingSlot> neighborSlots)
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

		private void SubscribeToExistingBuildingStats()
		{
		}

		private void TrySubscribeToUnitsStat(BuildingSlot slot)
		{
		}

		private void TryUnsubscribeFromUnitsStat(BuildingSlot slot)
		{
		}

		private void UnsubscribeFromAllStats()
		{
		}

		private void OnNeighborBuildingPlaced(BaseBuilding building)
		{
		}

		private void OnNeighborBuildingDestroyed(BaseBuilding building)
		{
		}

		private void OnNeighborUnitsAmountChanged(StatValue _)
		{
		}

		private BuildingSlot FindSlotForBuilding(BaseBuilding building)
		{
			return null;
		}

		private StatValue GetUnitsAmountStat(BuildingSlot slot)
		{
			return null;
		}

		private int CountAdjacentUnits()
		{
			return 0;
		}

		private void SyncAppliedMultipliers(int unitsCount)
		{
		}

		private void ApplyDeltaModifiers(int unitsCount)
		{
		}

		private void ApplyUnitStatDelta(MultiplyStatUnitBuildingUpgradeModule module, int unitsCount)
		{
		}

		private void ApplyAbilityStatDelta(MultiplyStatAbilityBuildingUpgradeModule module, int unitsCount)
		{
		}
	}
}
