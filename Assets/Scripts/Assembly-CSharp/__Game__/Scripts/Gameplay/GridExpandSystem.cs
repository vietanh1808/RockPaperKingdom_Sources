using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GridExpandSystem
	{
		private const int EXPAND_COST = 1;

		private readonly GridExpandConfig _config;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly BuildingSlotGrid _buildingSlotGrid;

		public bool IsExpandModeActive { get; private set; }

		public InventoryItemData ExpandItemData => null;

		public event Action OnExpandModeChanged
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

		public GridExpandSystem(GridExpandConfig config, GameplayInventorySystem gameplayInventorySystem, BuildingSlotGrid buildingSlotGrid)
		{
		}

		public void ActivateExpandMode()
		{
		}

		public void DeactivateExpandMode()
		{
		}

		public bool CanExpandSlot()
		{
			return false;
		}

		public bool CanReceiveMoreExpandItems()
		{
			return false;
		}

		public int GetCurrentExpandItemCount()
		{
			return 0;
		}

		public void ExpandSlot(Vector2Int position)
		{
		}
	}
}
