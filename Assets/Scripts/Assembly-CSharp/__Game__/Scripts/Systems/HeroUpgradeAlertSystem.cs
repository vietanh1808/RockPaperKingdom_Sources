namespace __Game__.Scripts.Systems
{
	public class HeroUpgradeAlertSystem : BaseCollectibleUpgradeAlertSystem<HeroItem, HeroItemData>
	{
		public HeroUpgradeAlertSystem(HeroSystem heroSystem, InventorySystem inventorySystem)
			: base((BaseCollectibleSystem<HeroItem, HeroItemData>)null, (InventorySystem)null)
		{
		}
	}
}
