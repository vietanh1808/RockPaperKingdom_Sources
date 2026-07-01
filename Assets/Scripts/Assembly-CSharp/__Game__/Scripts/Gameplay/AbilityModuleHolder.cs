using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityModuleHolder
	{
		public IAbilityCast AbilityCast { get; }

		public IAbilitySpawn AbilitySpawn { get; }

		public ITargetProvider SpawnTargetProvider { get; }

		public ITargetProvider EnemyTargetProvider { get; }

		public IRoundEventProvider RoundEventProvider { get; }

		public AbilityModuleHolder(IAbilityCast abilityCast, IAbilitySpawn abilitySpawn, ITargetProvider spawnTargetProvider, ITargetProvider enemyTargetProvider, IRoundEventProvider roundEventProvider)
		{
		}
	}
}
