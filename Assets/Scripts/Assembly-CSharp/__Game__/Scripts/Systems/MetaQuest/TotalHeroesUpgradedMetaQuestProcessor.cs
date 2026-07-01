using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class TotalHeroesUpgradedMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly HeroSystem _heroSystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private TotalHeroesUpgradedMetaQuestData _totalHeroesUpgradedData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public TotalHeroesUpgradedMetaQuestProcessor(HeroSystem heroSystem, DailyStreakQuestSystem dailyStreakQuestSystem)
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

		private void OnItemLevelChanged(HeroItem heroItem)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
