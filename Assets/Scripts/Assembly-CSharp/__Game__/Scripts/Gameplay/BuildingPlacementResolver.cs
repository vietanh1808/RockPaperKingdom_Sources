using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public static class BuildingPlacementResolver
	{
		public static Vector2Int? FindPosition(BuildingSlotGrid grid, BuildingPlacementRules rules)
		{
			return null;
		}

		public static List<Vector2Int> GetAvailablePlacementSlots(BuildingSlotGrid grid)
		{
			return null;
		}

		public static List<Vector2Int> GetAvailableUpgradeSlots(BuildingSlotGrid grid)
		{
			return null;
		}

		public static Vector2Int? ScoreAndPickSlot(BuildingSlotGrid grid, List<Vector2Int> slots, BuildingPlacementRules rules)
		{
			return null;
		}

		public static Vector2Int? PickHighestLevelUpgrade(BuildingSlotGrid grid, List<Vector2Int> upgradeSlots)
		{
			return null;
		}

		public static Vector2Int? PickSlotWithBestNeighborScore(BuildingSlotGrid grid, List<Vector2Int> slots, BuildingPlacementRules rules)
		{
			return null;
		}

		public static Vector2Int? PickSlotWithMostEmptyNeighbors(BuildingSlotGrid grid, List<Vector2Int> slots)
		{
			return null;
		}

		public static Vector2Int? PickSlotNearPrioritizedOrRandom(BuildingSlotGrid grid, List<Vector2Int> slots, BuildingPlacementRules rules)
		{
			return null;
		}

		public static List<Vector2Int> GetExpandableSlots(BuildingSlotGrid grid)
		{
			return null;
		}

		public static Vector2Int? GetRandomFromList(List<Vector2Int> slots)
		{
			return null;
		}
	}
}
