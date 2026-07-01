namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseSharedUnitFactory
	{
		private readonly SharedAbilityFactory _sharedAbilityFactory;

		protected BaseSharedUnitFactory(SharedAbilityFactory sharedAbilityFactory)
		{
		}

		public SharedUnit Create(UnitData unitData)
		{
			return null;
		}

		protected virtual void InitializeBaseStats(UnitData unitData, SharedUnit sharedUnitData)
		{
		}

		protected virtual void InitializeModifiedStats(UnitData unitData, SharedUnit sharedUnitData)
		{
		}

		private void InitializeAbilityData(UnitData unitData, SharedUnit sharedUnitData)
		{
		}

		private void InitializeAbilityDamage(SharedUnit sharedUnitData)
		{
		}
	}
}
