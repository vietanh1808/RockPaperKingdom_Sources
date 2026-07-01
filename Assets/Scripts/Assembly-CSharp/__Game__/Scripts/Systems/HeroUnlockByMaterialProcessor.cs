namespace __Game__.Scripts.Systems
{
	public class HeroUnlockByMaterialProcessor : BaseCollectibleUnlockByMaterialProcessor<HeroItem, HeroItemData>
	{
		public HeroUnlockByMaterialProcessor(InventorySystem inventorySystem, HeroSystem collectibleSystem)
			: base((InventorySystem)null, (BaseCollectibleSystem<HeroItem, HeroItemData>)null)
		{
		}
	}
}
