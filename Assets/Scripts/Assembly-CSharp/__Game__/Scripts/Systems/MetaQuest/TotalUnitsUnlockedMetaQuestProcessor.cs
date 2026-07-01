namespace __Game__.Scripts.Systems.MetaQuest
{
	public class TotalUnitsUnlockedMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly UnitCardSystem _unitCardSystem;

		private TotalUnitsUnlockedMetaQuestData _totalUnitsUnlockedData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public TotalUnitsUnlockedMetaQuestProcessor(UnitCardSystem unitCardSystem)
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

		private void OnCollectibleItemUnlocked(UnitCardItem unitCardItem)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
