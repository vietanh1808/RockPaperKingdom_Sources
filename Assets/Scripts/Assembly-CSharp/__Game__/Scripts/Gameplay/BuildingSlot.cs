using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingSlot
	{
		private BuildingSlotState _state;

		private List<BuildingSlot> _neighbors;

		private int _emptyNeighborCount;

		public Vector2Int Position { get; private set; }

		public BaseBuilding Building { get; private set; }

		public int EmptyNeighborCount => 0;

		public IReadOnlyList<BuildingSlot> Neighbors => null;

		public BuildingSlotState State
		{
			get
			{
				return default(BuildingSlotState);
			}
			set
			{
			}
		}

		public event Action OnStateChanged
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

		public event Action<BaseBuilding> OnBuildingPlaced
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

		public event Action<BaseBuilding> OnBuildingDestroyed
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

		public event Action<int> OnEmptyNeighborCountChanged
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

		public BuildingSlot(Vector2Int position)
		{
		}

		public void InitializeNeighbors(List<BuildingSlot> neighbors)
		{
		}

		public void UpdateSkinForPlacement(BaseBuildingData selectedBuildingData)
		{
		}

		public void ResetSkinActive()
		{
		}

		public void AttachBuilding(BaseBuilding building)
		{
		}

		public void ClearBuilding()
		{
		}

		private void OnBuildingBeforeDestroy(BaseBuilding building)
		{
		}

		private void OnNeighborBuildingChanged(BaseBuilding _)
		{
		}

		private void OnNeighborStateChanged()
		{
		}

		private void RecalculateEmptyNeighborCount()
		{
		}

		private bool IsNeighborEmpty(BuildingSlot neighbor)
		{
			return false;
		}
	}
}
