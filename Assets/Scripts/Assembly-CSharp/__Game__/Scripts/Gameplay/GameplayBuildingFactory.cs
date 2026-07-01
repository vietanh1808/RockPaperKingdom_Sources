using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayBuildingFactory : BuildingFactory
	{
		private readonly StaticStatSystem _staticStatSystem;

		public GameplayBuildingFactory(DiContainer diContainer, UIDamageView uiDamageView, BaseSharedUnitFactory sharedUnitDataFactory, UnitRepositoryFactory unitRepositoryFactory, SharedAbilityFactory sharedAbilityFactory, AbilityFactory abilityFactory, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid, GameplayInventorySystem gameplayInventorySystem, BuildingRepository buildingRepository, StaticStatSystem staticStatSystem)
			: base(null, null, null, null, null, null, null, null, null, null)
		{
		}

		protected override TowerBuilding CreateTowerBuilding(TowerBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
			return null;
		}

		protected override void InitializeTowerStats(TowerBuildingData towerBuildingData, BuildingRuntime buildingRuntime)
		{
		}
	}
}
