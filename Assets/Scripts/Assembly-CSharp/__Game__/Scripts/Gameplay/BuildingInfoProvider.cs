using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingInfoProvider
	{
		private readonly BuildingPlacementHand _placementHand;

		private readonly BaseSharedUnitFactory _sharedUnitFactory;

		private readonly SharedAbilityFactory _sharedAbilityFactory;

		private readonly StaticStatSystem _staticStatSystem;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		public BuildingInfoProvider(BuildingPlacementHand placementHand, BaseSharedUnitFactory sharedUnitFactory, SharedAbilityFactory sharedAbilityFactory, StaticStatSystem staticStatSystem, GameplayInventorySystem gameplayInventorySystem)
		{
		}

		public string GetStatsText(BuildingSlot slot)
		{
			return null;
		}

		public string GetPlacedBuildingName(BaseBuilding building)
		{
			return null;
		}

		public string GetPlacedBuildingStats(BaseBuilding building)
		{
			return null;
		}

		private void AddPlacedTowerStats(List<string> stats, TowerBuilding towerBuilding)
		{
		}

		private void AddPlacedUnitSpawnStats(List<string> stats, UnitSpawnBuilding unitSpawnBuilding)
		{
		}

		private string GetSelectedBuildingStats(BuildingUpgradeRuntime selectedUpgrade)
		{
			return null;
		}

		private string GetStatsText(BuildingSlot slot, BuildingUpgradeRuntime selectedUpgrade)
		{
			return null;
		}

		private string[] GetUpgradeStats(BuildingSlot slot, BuildingUpgradeRuntime selectedUpgrade)
		{
			return null;
		}

		private string[] GetBuffApplyStats(BuffBuildingData buffBuildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		private string[] GetResourceBuffApplyStats(ResourceBuffBuildingData resourceBuffData)
		{
			return null;
		}

		private string[] GetLevelUpStats(BuildingSlot slot, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		private string[] GetNewBuildingStats(BaseBuildingData buildingData)
		{
			return null;
		}

		private void AddUnitSpawnStats(List<string> stats, UnitSpawnBuildingData buildingData)
		{
		}

		private void AddTowerStats(List<string> stats, TowerBuildingData buildingData)
		{
		}

		private TowerStats CreateTowerStats(TowerData towerData)
		{
			return null;
		}

		private void AddAbilityStats(List<string> stats, AbilityStats abilityStats, float damage, bool showTargetsAmount)
		{
		}

		private void AddUnitStat(List<string> stats, UnitStats unitStats, UnitStatType statType)
		{
		}

		private void AddAbilityStat(List<string> stats, AbilityStats abilityStats, AbilityStatType statType)
		{
		}

		private string FormatStatValue(float value)
		{
			return null;
		}

		private ModularBuildingLevelUp GetNextLevelUp(BaseBuilding building)
		{
			return null;
		}
	}
}
