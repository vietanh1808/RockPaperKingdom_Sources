using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Arena.UI;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaUpgradesPresenter
	{
		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly UIArenaSceneNavigation _uiArenaSceneNavigation;

		private Action _upgradesCompletedCallback;

		private int _pendingUpgradesCount;

		public int PendingUpgradesCount => 0;

		public event Action<int> OnPendingUpgradesCountChanged
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

		public ArenaUpgradesPresenter(GameplayUpgradesSystem gameplayUpgradesSystem, UIArenaSceneNavigation uiArenaSceneNavigation)
		{
		}

		public void DisplayUpgrades(int upgradesCount, Action onAllUpgradesCompleted)
		{
		}

		public void OnUpgradeApplied()
		{
		}

		public bool HasMorePendingUpgrades()
		{
			return false;
		}

		public void RerollCurrentUpgrades()
		{
		}

		public void RerollThreeUpgrades()
		{
		}

		private void OnAllUpgradesClosed()
		{
		}
	}
}
