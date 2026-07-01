namespace __Game__.Scripts.Gameplay
{
	public class DelayedMultiShotSpawn : IAbilitySpawn
	{
		private const float DEFAULT_MULTISHOT_INTERVAL = 0.1f;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private readonly UnitRepositoryFactory _unitRepositoryFactory;

		public DelayedMultiShotSpawn(AbilityObjectPoolContainer abilityObjectPoolContainer, UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public void Spawn(Ability ability)
		{
		}

		private void SpawnProjectile(Ability ability, int releaseIndex)
		{
		}

		private int GetTargetsAmountFromHolder(Ability ability)
		{
			return 0;
		}
	}
}
