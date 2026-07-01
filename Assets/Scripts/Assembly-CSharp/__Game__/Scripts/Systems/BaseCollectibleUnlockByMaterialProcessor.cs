using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleUnlockByMaterialProcessor<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly InventorySystem _inventorySystem;

		private readonly BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		private readonly Dictionary<InventoryItem, TItem> _lockedCollectibleByMaterial;

		protected BaseCollectibleUnlockByMaterialProcessor(InventorySystem inventorySystem, BaseCollectibleSystem<TItem, TItemData> collectibleSystem)
		{
		}

		private void OnCollectibleInitialized()
		{
		}

		private void AddToLockedCollectibleByMaterial(TItem collectibleItem)
		{
		}

		private void OnMaterialAmountChanged(InventoryItem materialItem)
		{
		}
	}
}
