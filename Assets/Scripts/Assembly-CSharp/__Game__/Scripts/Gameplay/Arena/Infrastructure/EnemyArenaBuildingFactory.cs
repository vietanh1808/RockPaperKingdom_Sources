using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public class EnemyArenaBuildingFactory : ArenaBuildingFactory
	{
		private readonly ArenaEnemyStaticStatSystem _enemyStatSystem;

		protected override UnitType Side => default(UnitType);

		public EnemyArenaBuildingFactory(DiContainer diContainer, UIDamageView uiDamageView, ArenaEnemySharedUnitFactory sharedUnitDataFactory, UnitRepositoryFactory unitRepositoryFactory, EnemySharedAbilityFactory sharedAbilityFactory, AbilityFactory abilityFactory, BuildingUnitSpawner buildingUnitSpawner, BuildingSlotGrid buildingSlotGrid, GameplayInventorySystem gameplayInventorySystem, BuildingRepository buildingRepository, ArenaEnemyStaticStatSystem enemyStatSystem)
			: base(null, null, null, null, null, null, null, null, null, null)
		{
		}

		protected override void InitializeTowerStats(TowerBuildingData towerBuildingData, BuildingRuntime buildingRuntime)
		{
		}
	}
}
