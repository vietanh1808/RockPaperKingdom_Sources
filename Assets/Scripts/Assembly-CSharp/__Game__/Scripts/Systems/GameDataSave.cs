using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Systems
{
	public class GameDataSave
	{
		public int StageLastAvailableIndex;

		public Dictionary<int, StageAttemptData> StageAttemptDataPerStage;

		public Dictionary<int, float> StageBestRemainingHPPerStage;

		public Dictionary<int, float> StageBestCompletionRatePerStage;

		public Dictionary<int, List<StageChestState>> StageChestStatesPerStage;

		public int HardStageLastAvailableIndex;

		public Dictionary<int, StageAttemptData> HardStageAttemptDataPerStage;

		public Dictionary<int, float> HardStageBestRemainingHPPerStage;

		public Dictionary<int, float> HardStageBestCompletionRatePerStage;

		public Dictionary<int, List<StageChestState>> HardStageChestStatesPerStage;

		public List<string> UnlockedFeatures;

		public List<string> ReadyToViewTutorials;

		public bool IsFreeSpeedUpClaimed;

		public int DailyRewardsWeek;

		public int DailyRewardsDay;

		public List<PatrolDuration> PatrolDurationPerStage;

		public DateTime PatrolStartTime;

		public bool PatrolFirstUnlockRewardsClaimed;

		public int MysteryCardShopPredefinedCardsUsed;

		public bool HasUsedFreeReroll;

		public bool IsAppReviewShown;

		public Dictionary<string, string> RemoteConfigCache;

		public Dictionary<string, OfferState> OfferStates;
	}
}
