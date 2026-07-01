using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class ResourceBuildingProcessor
	{
		private const float RESOURCE_APPLICATION_DELAY = 0.5f;

		private readonly BuildingRepository _buildingRepository;

		private readonly GameplayInventorySystem _inventorySystem;

		public ResourceBuildingProcessor(BuildingRepository buildingRepository, GameplayInventorySystem inventorySystem)
		{
		}

		public void ProcessResources(Action onComplete)
		{
		}

		private List<ResourceBuilding> GetResourceBuildings()
		{
			return null;
		}

		private void ProcessBuildingAtIndex(List<ResourceBuilding> resourceBuildings, int index, Action onComplete)
		{
		}

		private void ApplyResourceIteration(ResourceBuilding resourceBuilding, int timesToApply, int currentIteration, Action onComplete)
		{
		}

		private void GrantResourceFromBuilding(ResourceBuilding resourceBuilding)
		{
		}

		private void ProcessNextBuilding(List<ResourceBuilding> resourceBuildings, int currentIndex, Action onComplete)
		{
		}
	}
}
