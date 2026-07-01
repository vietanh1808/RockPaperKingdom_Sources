using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class TotalUnitsUpgradedMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly UnitCardSystem _unitCardSystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private TotalUnitsUpgradedMetaQuestData _totalUnitsUpgradedData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public TotalUnitsUpgradedMetaQuestProcessor(UnitCardSystem unitCardSystem, DailyStreakQuestSystem dailyStreakQuestSystem)
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

		private void OnItemLevelChanged(UnitCardItem unitCardItem)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
