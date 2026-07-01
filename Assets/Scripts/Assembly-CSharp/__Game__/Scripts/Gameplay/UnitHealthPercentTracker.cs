using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class UnitHealthPercentTracker
	{
		private readonly UnitRepository _playerUnitRepository;

		private readonly WaveSystem _waveSystem;

		private float _initialTotalHealth;

		public UnitHealthPercentTracker(UnitRepositoryFactory unitRepositoryFactory, WaveSystem waveSystem)
		{
		}

		public int GetCurrentHealthPercent()
		{
			return 0;
		}

		public float GetTotalHealth()
		{
			return 0f;
		}

		private void OnWaveStarted()
		{
		}
	}
}
