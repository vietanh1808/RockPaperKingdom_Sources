using __Game__.Scripts.Services;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class WatchRVMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly IAdsService _adsService;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private WatchRVMetaQuestData _watchRVData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public WatchRVMetaQuestProcessor(IAdsService adsService, DailyStreakQuestSystem dailyStreakQuestSystem)
		{
		}

		public override void Initialize(BaseMetaQuestData data)
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void OnRewardedAdFinished()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
