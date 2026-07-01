namespace __Game__.Scripts.Systems.MetaQuest
{
	public class HeroUnlockMetaQuestProcessor : BaseMetaQuestProcessor
	{
		private readonly HeroSystem _heroSystem;

		private HeroUnlockMetaQuestData _heroUnlockMetaQuestData;

		public override int CurrentValue => 0;

		public HeroUnlockMetaQuestProcessor(HeroSystem heroSystem)
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

		private void OnCollectibleItemUnlocked(HeroItem heroItem)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
