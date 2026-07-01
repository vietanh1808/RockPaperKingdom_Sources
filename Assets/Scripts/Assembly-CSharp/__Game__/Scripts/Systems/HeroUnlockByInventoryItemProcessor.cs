namespace __Game__.Scripts.Systems
{
	public class HeroUnlockByInventoryItemProcessor : BaseCollectibleUnlockByInventoryItemProcessor<HeroItem, HeroItemData>
	{
		public HeroUnlockByInventoryItemProcessor(InventorySystem inventorySystem, HeroSystem collectibleSystem)
			: base((InventorySystem)null, (BaseCollectibleSystem<HeroItem, HeroItemData>)null)
		{
		}
	}
}
