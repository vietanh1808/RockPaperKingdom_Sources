using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class TalentDrawMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private TalentDrawMetaQuestData _talentDrawData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public TalentDrawMetaQuestProcessor(TalentCollectionSystem talentCollectionSystem, DailyStreakQuestSystem dailyStreakQuestSystem)
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

		private void OnTalentDrawCompleted(TalentRuntime talent)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
