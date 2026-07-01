namespace __Game__.Scripts.Systems.MetaQuest
{
	public class HeroSelectMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly HeroSystem _heroSystem;

		private HeroSelectMetaQuestData _heroSelectMetaQuestData;

		public override int CurrentValue => 0;

		public HeroSelectMetaQuestProcessor(HeroSystem heroSystem)
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

		private void OnActiveHeroesChanged()
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
