using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena.Enemy
{
	public class ArenaEnemyController
	{
		private readonly BuildingSlotGrid _enemyGrid;

		private readonly BuildingRepository _enemyBuildingRepository;

		private readonly BuildingTargetRepository _enemyBuildingTargetRepository;

		private readonly BuildingFactory _enemyBuildingFactory;

		private readonly BuildingPlacementHand _enemyHand;

		private readonly BuildingPlacementSystem _enemyPlacementSystem;

		private readonly BuildingUpgradeProcessor _enemyUpgradeProcessor;

		private readonly MirrorBuildingProcessor _enemyMirrorProcessor;

		private readonly ResourceBuildingProcessor _enemyResourceProcessor;

		private readonly UnitPoolManager _enemyUnitPoolManager;

		private readonly TowerUpdateIterator _towerUpdateIterator;

		private readonly ArenaEnemySetup _enemySetup;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaConfig _config;

		private readonly List<AddBuildingUpgrade> _pendingBuildings;

		private ArenaEnemyStrategyData _strategyOverride;

		private ArenaEnemyStrategyData _activeStrategy;

		private int _totalReceivedCount;

		private int _availableCoins;

		public BuildingSlotGrid EnemyGrid => null;

		public BuildingRepository EnemyBuildingRepository => null;

		public BuildingTargetRepository EnemyBuildingTargetRepository => null;

		public BuildingUpgradeProcessor EnemyUpgradeProcessor => null;

		public MirrorBuildingProcessor EnemyMirrorProcessor => null;

		public ResourceBuildingProcessor EnemyResourceProcessor => null;

		public Castle EnemyCastle => null;

		public int AvailableCoins => 0;

		public ArenaEnemyController(DiContainer diContainer, UpgradesConfig upgradesConfig, BuildingDataCollection buildingDataCollection, GameplayUpgradesSystem gameplayUpgradesSystem, TowerUpdateIterator towerUpdateIterator, ArenaSystem arenaSystem, ArenaConfig config, ArenaEnemySetup enemySetup)
		{
		}

		public void Initialize()
		{
		}

		public void OverrideStrategy(ArenaEnemyStrategyData strategy)
		{
		}

		private void SetupStrategy()
		{
		}

		public void ReceiveRandomCard()
		{
		}

		public void PlaceAllPendingBuildings()
		{
		}

		public void PreparePendingBuildings()
		{
		}

		public bool PlaceNextBuilding()
		{
			return false;
		}

		public void SpawnAllUnits()
		{
		}

		public void ReceiveShards(int amount)
		{
		}

		public bool TryExpandRandomSlot()
		{
			return false;
		}

		public bool HasExpandableSlots()
		{
			return false;
		}

		private List<Vector2Int> GetExpandableSlots()
		{
			return null;
		}

		private AddBuildingUpgrade TryGetForcedUpgrade()
		{
			return null;
		}

		private bool HasForcedSlotAtCurrentIndex()
		{
			return false;
		}

		private AddBuildingUpgrade SelectUpgradeByPriority(List<AddBuildingUpgrade> available)
		{
			return null;
		}

		private void PlaceBuilding(BuildingUpgradeRuntime upgrade)
		{
		}

		private void ExecutePlacement(Vector2Int position)
		{
		}
	}
}
