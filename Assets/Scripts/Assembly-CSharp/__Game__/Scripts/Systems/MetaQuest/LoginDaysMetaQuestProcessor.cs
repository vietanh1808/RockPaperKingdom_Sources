using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class LoginDaysMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private LoginDaysMetaQuestData _loginDaysData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public LoginDaysMetaQuestProcessor(DailyStreakQuestSystem dailyStreakQuestSystem)
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

		private void UpdateProgress()
		{
		}

		private int GetElapsedDays()
		{
			return 0;
		}
	}
}
