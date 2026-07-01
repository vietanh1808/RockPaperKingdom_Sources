using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Services
{
	public class HardModeUnlockDebugAction
	{
		private const int TARGET_PLAYER_LEVEL = 8;

		private readonly DebuggerSystem _debuggerSystem;

		private readonly DebuggerConfig _debuggerConfig;

		private readonly MenuTutorialSystem _menuTutorialSystem;

		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly StageSystem _stageSystem;

		private readonly StageChestSystem _stageChestSystem;

		private readonly ChestSystem _chestSystem;

		private readonly InventorySystem _inventorySystem;

		private readonly RewardSystem _rewardSystem;

		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		private readonly DailyRewardsSystem _dailyRewardsSystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly ISaveLoadDataService _saveLoadDataService;

		public HardModeUnlockDebugAction(DebuggerSystem debuggerSystem, DebuggerConfig debuggerConfig, MenuTutorialSystem menuTutorialSystem, FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig, StageSystem stageSystem, StageChestSystem stageChestSystem, ChestSystem chestSystem, InventorySystem inventorySystem, RewardSystem rewardSystem, PatrolRewardsSystem patrolRewardsSystem, DailyRewardsSystem dailyRewardsSystem, DailyStreakQuestSystem dailyStreakQuestSystem, TalentCollectionSystem talentCollectionSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem, PlayerLevelSystem playerLevelSystem, ISaveLoadDataService saveLoadDataService)
		{
		}

		public void Execute()
		{
		}

		private void DisableTutorials()
		{
		}

		private void ReachTargetPlayerLevel()
		{
		}

		private void UnlockAllFeatures()
		{
		}

		private void CompleteStagesUpToHardMode()
		{
		}

		private void ClaimAllStageChests()
		{
		}

		private void ClaimChestsForMode(StageModeType modeType)
		{
		}

		private void ClaimPatrolRewards()
		{
		}

		private void ClaimDailyRewards()
		{
		}

		private void ClaimDailyStreakRewards()
		{
		}

		private void OpenAllChests()
		{
		}

		private void OpenChestUntilKeysRunOut(ChestData chestData)
		{
		}

		private void DrawAllTalents()
		{
		}

		private void UpgradeCollectibles()
		{
		}
	}
}
