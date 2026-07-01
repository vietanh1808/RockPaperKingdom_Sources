using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityFactory
	{
		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private readonly TargetProviderFactory _targetProviderFactory;

		private readonly AbilityCastFactory _abilityCastFactory;

		private readonly AbilitySpawnFactory _abilitySpawnFactory;

		private readonly IRoundEventProvider _roundEventProvider;

		public AbilityFactory(AbilityObjectPoolContainer abilityObjectPoolContainer, TargetProviderFactory targetProviderFactory, AbilityCastFactory abilityCastFactory, AbilitySpawnFactory abilitySpawnFactory, IRoundEventProvider roundEventProvider)
		{
		}

		public Ability Get(SharedAbility sharedAbility, AbilityOwner abilityOwner)
		{
			return null;
		}
	}
}
