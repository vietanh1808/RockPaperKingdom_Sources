using System;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UnitCountTrackerFactory : IInitializable, IDisposable
	{
		private readonly UnitCountTracker _playerUnitCountTracker;

		private readonly UnitCountTracker _enemyUnitCountTracker;

		public UnitCountTrackerFactory(UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public UnitCountTracker GetTracker(UnitType unitType)
		{
			return null;
		}
	}
}
