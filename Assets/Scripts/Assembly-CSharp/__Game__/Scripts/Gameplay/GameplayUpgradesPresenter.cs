using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayUpgradesPresenter : IDisposable
	{
		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly GameplayLevelSystem _gameplayLevelSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private Action _upgradesCompletedCallback;

		private int _pendingUpgradesCount;

		private int _pendingLevelUpsCount;

		public int PendingUpgradesCount => 0;

		public bool HasPendingLevelUps => false;

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

		public GameplayUpgradesPresenter(GameplayUpgradesSystem gameplayUpgradesSystem, GameplayLevelSystem gameplayLevelSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void DisplayLevelUpUpgrades(Action onAllUpgradesCompleted)
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

		public void RefreshThreeUpgrades()
		{
		}

		public void RerollThreeUpgrades()
		{
		}

		private void OnAllUpgradesClosed()
		{
		}

		public void AddPendingUpgrades(int count)
		{
		}

		private void OnLevelIncreased()
		{
		}
	}
}
