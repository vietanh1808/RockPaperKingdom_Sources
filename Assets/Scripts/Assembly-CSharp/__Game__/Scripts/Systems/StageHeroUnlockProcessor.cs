namespace __Game__.Scripts.Systems
{
	public class StageHeroUnlockProcessor : BaseStageCollectibleUnlockProcessor<HeroItem, HeroItemData>
	{
		public StageHeroUnlockProcessor(StageSystem stageSystem, HeroSystem collectibleSystem)
			: base((StageSystem)null, (BaseCollectibleSystem<HeroItem, HeroItemData>)null)
		{
		}
	}
}
