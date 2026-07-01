namespace __Game__.Scripts.Systems.MetaQuest
{
	public class ChestUnlockedMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly ChestSystem _chestSystem;

		private ChestUnlockedMetaQuestData _chestUnlockedMetaQuestData;

		public override int CurrentValue => 0;

		public ChestUnlockedMetaQuestProcessor(ChestSystem chestSystem)
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

		private void CheckExistingProgress()
		{
		}

		private void OnChestOpened(ChestData chestData)
		{
		}
	}
}
