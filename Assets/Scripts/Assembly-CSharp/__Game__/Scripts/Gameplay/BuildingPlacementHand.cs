using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingPlacementHand
	{
		private readonly List<BuildingUpgradeRuntime> _pendingBuildings;

		public int PendingBuildingsCount => 0;

		public BuildingUpgradeRuntime SelectedBuilding { get; private set; }

		public event Action<BuildingUpgradeRuntime> OnBuildingAdded
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

		public event Action<BuildingUpgradeRuntime> OnBuildingRemoved
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

		public event Action OnSelectedBuildingChanged
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

		public void AddPendingBuilding(AddBuildingUpgrade addedUpgrade)
		{
		}

		public void RemovePendingBuilding(BuildingUpgradeRuntime removedUpgrade)
		{
		}

		public void SelectUpgrade(BuildingUpgradeRuntime selectedUpgrade)
		{
		}

		public List<string> GetPendingBuildingGuids()
		{
			return null;
		}

		public List<BuildingUpgradeRuntime> GetPendingBuildings()
		{
			return null;
		}

		public void RestorePendingBuildings(List<string> guids, GameplayUpgradeCollection upgradeCollection)
		{
		}
	}
}
