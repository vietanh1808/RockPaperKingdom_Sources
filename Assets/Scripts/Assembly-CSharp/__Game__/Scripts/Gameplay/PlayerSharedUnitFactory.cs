using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class PlayerSharedUnitFactory : BaseSharedUnitFactory
	{
		private readonly StaticStatSystem _staticStatSystem;

		public PlayerSharedUnitFactory(SharedAbilityFactory sharedAbilityFactory, StaticStatSystem staticStatSystem)
			: base(null)
		{
		}

		protected override void InitializeBaseStats(UnitData unitData, SharedUnit sharedUnitData)
		{
		}

		protected override void InitializeModifiedStats(UnitData unitData, SharedUnit sharedUnitData)
		{
		}
	}
}
