using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BuildingFactory
	{
		protected readonly DiContainer _diContainer;

		protected readonly UIDamageView _uiDamageView;

		protected readonly BaseSharedUnitFactory _sharedUnitDataFactory;

		protected readonly UnitRepositoryFactory _unitRepositoryFactory;

		protected readonly SharedAbilityFactory _sharedAbilityFactory;

		protected readonly AbilityFactory _abilityFactory;

		protected readonly BuildingUnitSpawner _buildingUnitSpawner;

		protected readonly BuildingSlotGrid _buildingSlotGrid;

		protected readonly GameplayInventorySystem _gameplayInventorySystem;

		protected readonly BuildingRepository _buildingRepository;

		protected BuildingFactory(DiContainer diContainer, UIDamageView uiDamageView, BaseSharedUnitFactory sharedUnitDataFactory, UnitRepositoryFactory unitRepositoryFactory, SharedAbilityFactory sharedAbilityFactory, AbilityFactory abilityFactory, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid, GameplayInventorySystem gameplayInventorySystem, BuildingRepository buildingRepository)
		{
		}

		public BaseBuilding CreateBuilding(BaseBuildingData baseBuildingData, Vector2Int slotGridPosition)
		{
			return null;
		}

		protected virtual UnitSpawnBuilding CreateUnitSpawnBuilding(UnitSpawnBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected abstract TowerBuilding CreateTowerBuilding(TowerBuildingData buildingData, BuildingRuntime buildingRuntime);

		protected virtual PowerUpBuilding CreateUpgradeBuilding(PowerUpBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected virtual MirrorBuilding CreateMirrorBuilding(MirrorBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected virtual ResourceBuilding CreateResourceBuilding(ResourceBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		private BuildingRuntime GetBuildingRuntime(BaseBuildingData baseBuildingData, Vector2Int slotGridPosition)
		{
			return null;
		}

		protected virtual void InitializeTowerStats(TowerBuildingData towerBuildingData, BuildingRuntime buildingRuntime)
		{
		}
	}
}
