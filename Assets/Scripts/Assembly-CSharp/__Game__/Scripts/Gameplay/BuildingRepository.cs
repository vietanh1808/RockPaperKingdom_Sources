using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingRepository
	{
		private readonly List<BaseBuilding> _buildings;

		private readonly List<TowerBuilding> _towerBuildings;

		public IReadOnlyList<BaseBuilding> Buildings => null;

		public IReadOnlyList<TowerBuilding> TowerBuildings => null;

		public event Action<BaseBuilding> OnBuildingAdded
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

		public event Action<BaseBuilding> OnBuildingRemoved
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

		public event Action<TowerBuilding> OnTowerBuildingAdded
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

		public event Action<TowerBuilding> OnTowerBuildingRemoved
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

		public void SetBuildingsDisplayState(BuildingState state)
		{
		}

		public void AddBuilding(BaseBuilding building)
		{
		}

		public void RemoveBuilding(BaseBuilding building)
		{
		}

		private void OnBuildingBeforeDestroy(BaseBuilding building)
		{
		}

		public void SetAllLevelIndicatorsVisible(bool visible)
		{
		}

		public void ResetAllTowerCooldowns()
		{
		}
	}
}
