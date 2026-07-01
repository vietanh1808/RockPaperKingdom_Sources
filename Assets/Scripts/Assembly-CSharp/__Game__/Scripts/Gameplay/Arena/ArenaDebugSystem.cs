using __Game__.Scripts.Gameplay.Arena.Enemy;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaDebugSystem
	{
		private readonly ArenaDebugSettings _settings;

		private readonly ArenaEnemyStaticStatSystem _enemyStaticStatSystem;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly ArenaSystem _arenaSystem;

		private readonly StaticStatSystem _staticStatSystem;

		private bool IsDebugMode => false;

		public ArenaDebugSystem(ArenaDebugSettings settings, ArenaEnemyStaticStatSystem enemyStaticStatSystem, ArenaEnemyController arenaEnemyController, ArenaSystem arenaSystem, StaticStatSystem staticStatSystem)
		{
		}

		public void Initialize()
		{
		}

		private void OverrideTimeScale()
		{
		}

		private void OverrideTier()
		{
		}

		private void OverrideStrategy()
		{
		}

		private void OverrideEnemyStats()
		{
		}

		private void OverridePlayerStats()
		{
		}
	}
}
