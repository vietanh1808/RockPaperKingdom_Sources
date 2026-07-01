using System;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayDangerousTracker : IInitializable, IDisposable
	{
		private bool _isDangerous;

		private readonly UnitCountTracker _playerUnitCountTracker;

		private readonly UnitCountTracker _enemyUnitCountTracker;

		public bool IsDangerous
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnDangerousStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GameplayDangerousTracker(UnitCountTrackerFactory unitCountTrackerFactory)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnPlayerUnitCountChanged(int count)
		{
		}

		private void OnEnemyUnitCountChanged(int count)
		{
		}

		private void CheckDangerousStatus()
		{
		}
	}
}
