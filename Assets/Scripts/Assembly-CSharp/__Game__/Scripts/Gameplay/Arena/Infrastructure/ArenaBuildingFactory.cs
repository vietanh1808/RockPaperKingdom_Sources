using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public abstract class ArenaBuildingFactory : BuildingFactory
	{
		protected abstract UnitType Side { get; }

		protected ArenaBuildingFactory(DiContainer diContainer, UIDamageView uiDamageView, BaseSharedUnitFactory sharedUnitDataFactory, UnitRepositoryFactory unitRepositoryFactory, SharedAbilityFactory sharedAbilityFactory, AbilityFactory abilityFactory, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid, GameplayInventorySystem gameplayInventorySystem, BuildingRepository buildingRepository)
			: base(null, null, null, null, null, null, null, null, null, null)
		{
		}

		protected override TowerBuilding CreateTowerBuilding(TowerBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected override UnitSpawnBuilding CreateUnitSpawnBuilding(UnitSpawnBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected override PowerUpBuilding CreateUpgradeBuilding(PowerUpBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected override MirrorBuilding CreateMirrorBuilding(MirrorBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected override ResourceBuilding CreateResourceBuilding(ResourceBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected void ApplySide(BaseBuilding building)
		{
		}
	}
}
