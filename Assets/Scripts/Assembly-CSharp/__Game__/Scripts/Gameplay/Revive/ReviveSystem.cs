using System;
using Zenject;
using __Game__.Scripts.Gameplay.BossChest;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.Experience;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Revive
{
	public class ReviveSystem : IInitializable, IDisposable
	{
		private const float REVIVE_HEALTH_PERCENT = 0.5f;

		private const int REVIVE_BONUS_UPGRADES = 2;

		private readonly WaveSystem _waveSystem;

		private readonly Castle _castle;

		private readonly UnitRepository _enemyUnitRepository;

		private readonly ExperienceObjectManager _experienceObjectManager;

		private readonly GameplayCoinObjectManager _coinObjectManager;

		private readonly BossChestManager _bossChestManager;

		private readonly GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly StageSystem _stageSystem;

		private readonly IAdsService _adsService;

		private bool _hasRevived;

		public bool IsRevivedWave { get; private set; }

		public bool CanOfferRevive => false;

		public ReviveSystem(WaveSystem waveSystem, Castle castle, UnitRepositoryFactory unitRepositoryFactory, ExperienceObjectManager experienceObjectManager, GameplayCoinObjectManager coinObjectManager, BossChestManager bossChestManager, GameplayUpgradesPresenter gameplayUpgradesPresenter, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, IAdsService adsService)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void ConsumeReviveOffer()
		{
		}

		public void TrackSoftFail()
		{
		}

		public void ApplyRevive()
		{
		}

		private void OnWaveCompleted()
		{
		}

		private void KillRemainingEnemies()
		{
		}

		private void TrackMissionStep(string stepName)
		{
		}
	}
}
