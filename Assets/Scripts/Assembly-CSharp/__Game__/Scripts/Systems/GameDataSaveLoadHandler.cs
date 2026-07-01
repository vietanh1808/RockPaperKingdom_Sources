using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.ABTest;
using __Game__.Scripts.Systems.Offers;

namespace __Game__.Scripts.Systems
{
	public class GameDataSaveLoadHandler : BaseSaveLoadHandler
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly MenuTutorialSystem _menuTutorialSystem;

		private readonly StageSystem _stageSystem;

		private readonly StageChestSystem _stageChestSystem;

		private readonly DailyRewardsSystem _dailyRewardsSystem;

		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		private readonly MysteryCardShopRuntimeData _mysteryCardShopRuntimeData;

		private readonly RerollRuntimeData _rerollRuntimeData;

		private readonly AppReviewSystem _appReviewSystem;

		private readonly ABTestService _abTestService;

		private readonly OfferSystem _offerSystem;

		public GameDataSaveLoadHandler(FeatureUnlockSystem featureUnlockSystem, MenuTutorialSystem menuTutorialSystem, StageSystem stageSystem, StageChestSystem stageChestSystem, DailyRewardsSystem dailyRewardsSystem, PatrolRewardsSystem patrolRewardsSystem, MysteryCardShopRuntimeData mysteryCardShopRuntimeData, RerollRuntimeData rerollRuntimeData, AppReviewSystem appReviewSystem, ABTestService abTestService, OfferSystem offerSystem)
		{
		}

		public override void Load()
		{
		}

		public override void Save()
		{
		}

		public override string GetDataPath()
		{
			return null;
		}

		private void LoadStageData(GameDataSave gameDataSave)
		{
		}

		private void LoadStageChestData(GameDataSave gameDataSave)
		{
		}

		private void LoadFeaturesData(GameDataSave gameDataSave)
		{
		}

		private void LoadTutorialsData(GameDataSave gameDataSave)
		{
		}

		private void LoadDailyRewardsData(GameDataSave gameDataSave)
		{
		}

		private void LoadPatrolRewardData(GameDataSave gameDataSave)
		{
		}

		private void LoadMysteryCardShopData(GameDataSave gameDataSave)
		{
		}

		private void LoadRerollData(GameDataSave gameDataSave)
		{
		}

		private void LoadAppReviewData(GameDataSave gameDataSave)
		{
		}

		private void LoadRemoteConfigCache(GameDataSave gameDataSave)
		{
		}

		private void LoadOfferStates(GameDataSave gameDataSave)
		{
		}
	}
}
