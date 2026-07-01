namespace __Game__.Scripts.Systems
{
	public class UnitCardUpgradeAlertSystem : BaseCollectibleUpgradeAlertSystem<UnitCardItem, UnitCardItemData>
	{
		public UnitCardUpgradeAlertSystem(UnitCardSystem UnitCardSystem, InventorySystem inventorySystem)
			: base((BaseCollectibleSystem<UnitCardItem, UnitCardItemData>)null, (InventorySystem)null)
		{
		}
	}
}
