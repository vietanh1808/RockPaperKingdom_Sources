using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class GlobalBuildingCountBonusTracker
	{
		private readonly AssetModuleHolder<BaseBuildingUpgradeModule> _bonusModules;

		private readonly BuildingRuntime _buildingRuntime;

		private readonly BuildingRepository _buildingRepository;

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

		public GlobalBuildingCountBonusTracker(AssetModuleHolder<BaseBuildingUpgradeModule> bonusModules, BuildingRuntime buildingRuntime, BuildingRepository buildingRepository, BaseBuildingData targetBuildingData)
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

		private void OnBuildingChanged(BaseBuilding _)
		{
		}

		private int CountMatchingBuildings()
		{
			return 0;
		}

		private void SyncAppliedValues(int buildingCount)
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
