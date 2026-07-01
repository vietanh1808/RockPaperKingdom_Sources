using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Gameplay.Building;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingPlacementSystem
	{
		private readonly BuildingSlotGrid _buildingSlotGrid;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingFactory _buildingFactory;

		private readonly BuildingPlacementHand _placementHand;

		private readonly BuildingDataCollection _buildingDataCollection;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		public BuildingPlacementHand Hand => null;

		public BuildingRepository BuildingRepository => null;

		public BuildingSlotGrid SlotGrid => null;

		public AddCastleUpgrade CastleUpgrade { get; private set; }

		public event Action OnCastlePlaced
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

		public event Action OnBuildingPlaced
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

		public BuildingPlacementSystem(BuildingSlotGrid buildingSlotGrid, BuildingRepository buildingRepository, BuildingFactory buildingFactory, BuildingPlacementHand placementHand, BuildingDataCollection buildingDataCollection, GameplayInventorySystem gameplayInventorySystem)
		{
		}

		public void PlaceCastle(AddCastleUpgrade addCastleUpgrade)
		{
		}

		public void PlaceBuilding(Vector2Int position)
		{
		}

		public void UpgradeBuilding(Vector2Int position)
		{
		}

		public void ApplyBuff(Vector2Int position)
		{
		}

		public void ApplyLevelUp(Vector2Int position)
		{
		}

		public void ApplyDestroyExpand(Vector2Int position)
		{
		}

		public List<BuildingSaveData> GetPlacedBuildingsData()
		{
			return null;
		}

		public void RestoreBuildings(List<BuildingSaveData> buildingsData)
		{
		}

		private void OnSelectedBuildingChanged()
		{
		}
	}
}
