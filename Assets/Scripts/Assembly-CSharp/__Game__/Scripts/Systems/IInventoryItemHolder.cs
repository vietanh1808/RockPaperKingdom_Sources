namespace __Game__.Scripts.Systems
{
	public interface IInventoryItemHolder
	{
		InventoryItemData InventoryItemData { get; }

		int Amount { get; }
	}
}
