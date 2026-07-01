namespace __Game__.Scripts.Gameplay
{
	public class MultiShotSpawn : IAbilitySpawn
	{
		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private readonly UnitRepositoryFactory _unitRepositoryFactory;

		public MultiShotSpawn(AbilityObjectPoolContainer abilityObjectPoolContainer, UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public void Spawn(Ability ability)
		{
		}

		private int GetTargetsAmountFromHolder(Ability ability)
		{
			return 0;
		}
	}
}
