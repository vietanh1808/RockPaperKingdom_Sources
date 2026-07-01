using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayPlayerStatsSystem
	{
		private readonly StaticStatSystem _staticStatSystem;

		public PlayerStats PlayerStats { get; }

		public GameplayPlayerStatsSystem(StaticStatSystem staticStatSystem)
		{
		}

		public void Initialize()
		{
		}

		private void OnStaticStatsRefreshed()
		{
		}

		private void SyncStatsFromStaticSystem()
		{
		}
	}
}
