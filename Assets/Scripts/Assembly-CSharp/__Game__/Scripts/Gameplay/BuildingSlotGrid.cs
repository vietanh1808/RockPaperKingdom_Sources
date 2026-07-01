using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingSlotGrid
	{
		private const int GRID_SIZE = 5;

		private const int INNER_START = 1;

		private const int INNER_END = 3;

		private readonly int _maxBuildingLevelIndex;

		private readonly Dictionary<Vector2Int, BuildingSlotState> _savedNeighborStates;

		private GameplayInventorySystem _inventorySystem;

		private int _lockedSlotsCount;

		private bool _hasEmptySlots;

		public BuildingSlot[,] Slots { get; }

		public int LockedSlotsCount => 0;

		public bool HasEmptySlots => false;

		public event Action<bool> OnHasEmptySlotsChanged
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

		public BuildingSlotGrid(UpgradesConfig upgradesConfig, GameplayInventorySystem inventorySystem = null)
		{
		}

		private void InitializeSlotNeighbors()
		{
		}

		private List<BuildingSlot> GetNeighborSlots(Vector2Int position)
		{
			return null;
		}

		public void ActivatePlacementMode(AddBuildingUpgrade selectedUpgrade)
		{
		}

		public void DeactivatePlacementMode()
		{
		}

		public void ActivateExpandMode()
		{
		}

		public void DeactivateExpandMode()
		{
		}

		public void ExpandSlot(Vector2Int position)
		{
		}

		public void UnlockLockedNeighbors(Vector2Int position)
		{
		}

		public BuildingSlot GetSlot(Vector2Int position)
		{
			return null;
		}

		public void HighlightNeighborsForBuilding(Vector2Int position, BaseBuildingData buildingData)
		{
		}

		public void HighlightLockedNeighbors(Vector2Int position)
		{
		}

		public void ClearNeighborHighlights(Vector2Int position)
		{
		}

		public bool IsInnerSlot(Vector2Int position)
		{
			return false;
		}

		public bool IsValidGridPosition(Vector2Int position)
		{
			return false;
		}

		public bool HasUnlockedNeighbor(Vector2Int position)
		{
			return false;
		}

		public List<Vector2Int> GetExpandedSlots()
		{
			return null;
		}

		private void SubscribeToSlotEvents()
		{
		}

		private void RecalculateEmptySlots()
		{
		}

		private bool CalculateHasEmptySlots()
		{
			return false;
		}

		private int CalculateLockedSlotsCount()
		{
			return 0;
		}

		public void RestoreExpandedSlots(List<Vector2Int> expandedPositions)
		{
		}

		public List<Vector2Int> GetNeighborPositions(Vector2Int position)
		{
			return null;
		}

		public bool HasValidPlacement(AddBuildingUpgrade upgrade)
		{
			return false;
		}

		private BuildingSlotState GetActiveState(BaseBuilding building, AddBuildingUpgrade selectedUpgrade)
		{
			return default(BuildingSlotState);
		}

		private BuildingSlotState GetActiveStateForTargetedBuff(BaseBuilding building, Func<BaseBuilding, bool> canTarget)
		{
			return default(BuildingSlotState);
		}

		private BuildingSlotState GetActiveStateForDestroyExpand(BaseBuilding building)
		{
			return default(BuildingSlotState);
		}
	}
}
