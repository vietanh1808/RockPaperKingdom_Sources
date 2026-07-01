using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class PlayerSharedAbilityFactory : SharedAbilityFactory
	{
		private readonly StaticStatSystem _staticStatSystem;

		public PlayerSharedAbilityFactory(AbilityObjectPoolContainer abilityObjectPoolContainer, StaticStatSystem staticStatSystem)
			: base(null)
		{
		}

		protected override void InitializeStats(AbilityData abilityData, SharedAbility sharedAbility)
		{
		}
	}
}
