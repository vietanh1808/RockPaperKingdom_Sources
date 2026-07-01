using System;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UnitTargetHolderUpdater : ITickable, IInitializable, IDisposable
	{
		private readonly UnitUpdateIterator _playerUpdateIterator;

		private readonly UnitUpdateIterator _enemyUpdateIterator;

		public UnitTargetHolderUpdater(UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void Tick()
		{
		}
	}
}
