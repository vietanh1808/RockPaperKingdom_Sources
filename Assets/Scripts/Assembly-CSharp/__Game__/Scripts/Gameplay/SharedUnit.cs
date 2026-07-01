namespace __Game__.Scripts.Gameplay
{
	public class SharedUnit
	{
		public UnitData UnitData { get; }

		public SharedAbility MainSharedAbility { get; private set; }

		public SharedAbility SecondarySharedAbility { get; private set; }

		public SharedAbility DeathSharedAbility { get; private set; }

		public SharedAbility OnDamageReceivedSharedAbility { get; private set; }

		public UnitStats UnitStats { get; }

		public SharedUnit(UnitData unitData)
		{
		}

		public void SetMainAbilityRuntimeData(SharedAbility sharedAbility)
		{
		}

		public void SetSecondaryAbilityRuntimeData(SharedAbility sharedAbility)
		{
		}

		public void SetDeathAbilityRuntimeData(SharedAbility sharedAbility)
		{
		}

		public void SetOnDamageReceivedAbilityRuntimeData(SharedAbility sharedAbility)
		{
		}
	}
}
