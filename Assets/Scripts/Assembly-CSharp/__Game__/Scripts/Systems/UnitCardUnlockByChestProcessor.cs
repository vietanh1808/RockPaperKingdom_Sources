namespace __Game__.Scripts.Systems
{
	public class UnitCardUnlockByChestProcessor
	{
		private readonly ChestSystem _chestSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly InventorySystem _inventorySystem;

		public UnitCardUnlockByChestProcessor(ChestSystem chestSystem, UnitCardSystem unitCardSystem, InventorySystem inventorySystem)
		{
		}

		private void OnChestRewardClaimed(ChestRewardItem chestRewardItem)
		{
		}
	}
}
