using System;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.BossChest
{
	public class BossChestSpawningListener : IInitializable, IDisposable
	{
		private readonly UnitRepository _unitRepository;

		private readonly BossChestManager _bossChestManager;

		private readonly WaveSystem _waveSystem;

		public BossChestSpawningListener(UnitRepositoryFactory unitRepositoryFactory, BossChestManager bossChestManager, WaveSystem waveSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnUnitRemoved(BaseUnit unit)
		{
		}
	}
}
