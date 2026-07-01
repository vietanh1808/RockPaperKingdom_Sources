namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public class ArenaEnemySharedUnitFactory : BaseSharedUnitFactory
	{
		private readonly ArenaEnemyStaticStatSystem _enemyStatSystem;

		public ArenaEnemySharedUnitFactory(EnemySharedAbilityFactory sharedAbilityFactory, ArenaEnemyStaticStatSystem enemyStatSystem)
			: base(null)
		{
		}

		protected override void InitializeModifiedStats(UnitData unitData, SharedUnit sharedUnitData)
		{
		}
	}
}
