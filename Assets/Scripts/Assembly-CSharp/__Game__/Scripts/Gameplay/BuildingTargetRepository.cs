using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingTargetRepository
	{
		private readonly List<BaseBuilding> _targetableBuildings;

		private readonly BuildingRepository _buildingRepository;

		public IReadOnlyList<BaseBuilding> TargetableBuildings => null;

		public int TargetCount => 0;

		public BuildingTargetRepository(BuildingRepository buildingRepository)
		{
		}

		public void AddBuilding(BaseBuilding building)
		{
		}

		public void RemoveBuilding(BaseBuilding building)
		{
		}

		public BaseBuilding GetClosestBuilding(Vector3 position)
		{
			return null;
		}

		public void RestoreAllBuildings()
		{
		}

		private void OnBuildingAdded(BaseBuilding building)
		{
		}

		private void OnBuildingRemoved(BaseBuilding building)
		{
		}
	}
}
