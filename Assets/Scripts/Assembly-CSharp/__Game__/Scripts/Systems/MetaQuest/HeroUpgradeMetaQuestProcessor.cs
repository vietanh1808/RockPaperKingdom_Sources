namespace __Game__.Scripts.Systems.MetaQuest
{
	public class HeroUpgradeMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly HeroSystem _heroSystem;

		private HeroUpgradeMetaQuestData _heroUpgradeMetaQuestData;

		public override int CurrentValue => 0;

		public override int TargetValue => 0;

		public HeroUpgradeMetaQuestProcessor(HeroSystem heroSystem)
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

		private int GetCurrentLevel()
		{
			return 0;
		}
	}
}
