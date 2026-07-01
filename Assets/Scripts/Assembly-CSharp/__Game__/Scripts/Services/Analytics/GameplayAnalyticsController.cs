using System;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.BossChest;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services.Analytics
{
	public class GameplayAnalyticsController : IDisposable
	{
		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly GameAnalyticsEvents _gameAnalyticsEvents;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly UnitHealthPercentTracker _unitHealthPercentTracker;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly BossChestUpgradeSystem _bossChestUpgradeSystem;

		private readonly MysteryCardShopSystem _mysteryCardShopSystem;

		private readonly Castle _castle;

		private bool _isAbandoned;

		[Inject]
		public GameplayAnalyticsController(GameAnalyticsEvents gameAnalyticsEvents, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, WaveSystem waveSystem, UnitHealthPercentTracker unitHealthPercentTracker, GameplayUpgradesSystem gameplayUpgradesSystem, BossChestUpgradeSystem bossChestUpgradeSystem, MysteryCardShopSystem mysteryCardShopSystem, Castle castle)
		{
		}

		public void Dispose()
		{
		}

		private void SubscribeToEvents()
		{
		}

		private void UnsubscribeFromEvents()
		{
		}

		private void OnWaveStarted()
		{
		}

		private void OnWaveCompleted()
		{
		}

		private void OnStageAbandoned(float completionRate)
		{
		}

		private void OnStageFinished(float completionRate)
		{
		}

		private float GetCastleHealthPercent()
		{
			return 0f;
		}

		private void OnUpgradeApplied(BaseGameplayUpgrade upgrade, UpgradeSource source)
		{
		}

		private void OnBossChestUpgradeApplied(BaseGameplayUpgrade upgrade)
		{
		}

		private void OnMysteryCardPurchased(int index)
		{
		}
	}
}
