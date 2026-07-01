namespace __Game__.Scripts.Gameplay
{
	public abstract class SharedAbilityFactory
	{
		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		protected SharedAbilityFactory(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public SharedAbility Get(AbilityData abilityData)
		{
			return null;
		}

		protected virtual void InitializeStats(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}

		private void InitializeAbilityObjectPrefab(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}

		private void InitializeEffects(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}

		private void InitializeDebuffs(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}

		private void InitializeCastOnHit(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}
	}
}
