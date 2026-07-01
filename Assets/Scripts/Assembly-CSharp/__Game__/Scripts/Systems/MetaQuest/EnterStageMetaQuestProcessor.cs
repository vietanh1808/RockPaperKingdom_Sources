namespace __Game__.Scripts.Systems.MetaQuest
{
	public class EnterStageMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly StageSystem _stageSystem;

		private EnterStageMetaQuestData _enterStageMetaQuestData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public EnterStageMetaQuestProcessor(StageSystem stageSystem)
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

		private void OnStageStarted()
		{
		}
	}
}
