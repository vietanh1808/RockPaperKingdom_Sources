namespace __Game__.Scripts.Systems.MetaQuest
{
	public class UnitCardUpgradeMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly UnitCardSystem _unitCardSystem;

		private UnitCardUpgradeMetaQuestData _unitCardUpgradeMetaQuestData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public UnitCardUpgradeMetaQuestProcessor(UnitCardSystem unitCardSystem)
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

		private int GetCurrentLevel()
		{
			return 0;
		}
	}
}
