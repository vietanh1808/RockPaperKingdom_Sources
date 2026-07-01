using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class SpendResourceMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly InventorySystem _inventorySystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private SpendResourceMetaQuestData _spendResourceData;

		private InventoryItem _trackedItem;

		private int _previousAmount;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public SpendResourceMetaQuestProcessor(InventorySystem inventorySystem, DailyStreakQuestSystem dailyStreakQuestSystem)
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

		private void OnAmountChanged(InventoryItem item)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
