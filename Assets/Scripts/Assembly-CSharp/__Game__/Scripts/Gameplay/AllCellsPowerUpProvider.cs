using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AllCellsPowerUpProvider : IPowerUpCellsProvider
	{
		public List<BaseBuilding> GetTargetBuildings(PowerUpBuilding powerUpBuilding, BuildingSlotGrid grid)
		{
			return null;
		}

		private void CheckAndAddNeighbor(PowerUpBuilding powerUpBuilding, BuildingSlotGrid grid, Vector2Int position, List<BaseBuilding> neighbors)
		{
		}
	}
}
