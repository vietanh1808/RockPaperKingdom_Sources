using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingUpgradeProcessor
	{
		private const float UPGRADE_APPLICATION_DELAY = 0.5f;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingSlotGrid _buildingSlotGrid;

		public BuildingUpgradeProcessor(BuildingRepository buildingRepository, BuildingSlotGrid buildingSlotGrid)
		{
		}

		public void ProcessUpgrades(Action onComplete)
		{
		}

		private List<PowerUpBuilding> GetUpgradeBuildings()
		{
			return null;
		}

		private void ProcessBuildingAtIndex(List<PowerUpBuilding> upgradeBuildings, int index, Action onComplete)
		{
		}

		private void ApplyUpgradeIteration(PowerUpBuilding powerUpBuilding, int timesToApply, int currentIteration, Action onComplete)
		{
		}

		private int CalculateTimesToApply(PowerUpBuilding powerUpBuilding)
		{
			return 0;
		}

		private void ProcessNextBuilding(List<PowerUpBuilding> upgradeBuildings, int currentIndex, Action onComplete)
		{
		}
	}
}
