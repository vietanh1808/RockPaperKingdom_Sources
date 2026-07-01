using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleUnlockByInventoryItemProcessor<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly InventorySystem _inventorySystem;

		private readonly BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		private readonly Dictionary<InventoryItem, List<TItem>> _lockedCollectiblesByInventoryItem;

		protected BaseCollectibleUnlockByInventoryItemProcessor(InventorySystem inventorySystem, BaseCollectibleSystem<TItem, TItemData> collectibleSystem)
		{
		}

		private void OnCollectibleInitialized()
		{
		}

		private void TrackCollectible(TItem collectibleItem)
		{
		}

		private void OnInventoryItemAmountChanged(InventoryItem inventoryItem)
		{
		}
	}
}
