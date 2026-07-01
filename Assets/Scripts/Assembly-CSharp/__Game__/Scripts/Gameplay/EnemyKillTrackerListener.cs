using System;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class EnemyKillTrackerListener : IInitializable, IDisposable
	{
		private readonly UnitRepository _enemyRepository;

		private readonly EnemyKillTracker _enemyKillTracker;

		public EnemyKillTrackerListener(UnitRepositoryFactory unitRepositoryFactory, EnemyKillTracker enemyKillTracker)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnEnemyRemoved(BaseUnit unit)
		{
		}
	}
}
