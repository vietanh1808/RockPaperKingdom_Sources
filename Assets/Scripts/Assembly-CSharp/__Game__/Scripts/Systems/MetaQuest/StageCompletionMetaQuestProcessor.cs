namespace __Game__.Scripts.Systems.MetaQuest
{
	public class StageCompletionMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly StageSystem _stageSystem;

		private StageCompletionMetaQuestData _stageCompletionMetaQuestData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public StageCompletionMetaQuestProcessor(StageSystem stageSystem)
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

		private void OnLastAvailableIndexChanged()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
