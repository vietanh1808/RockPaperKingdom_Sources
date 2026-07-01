using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class BaseCollectibleUpgradeAlertSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly Dictionary<InventoryItem, List<BaseCollectibleItem<TItemData>>> _priceDictionary;

		private readonly Dictionary<BaseCollectibleItem<TItemData>, List<PriceData>> _collectibleDictionary;

		private readonly BaseCollectibleSystem<TItem, TItemData> _heroSystem;

		private readonly InventorySystem _inventorySystem;

		private int _upgradeCount;

		private bool _alertUpgrade;

		public bool AlertUpgrade
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnAlertUpgradeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BaseCollectibleUpgradeAlertSystem(BaseCollectibleSystem<TItem, TItemData> heroSystem, InventorySystem inventorySystem)
		{
		}

		public void Initialize()
		{
		}

		private void AddUnlockedItem(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		private void RemoveLockedItem(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		private void RefreshAlertForItem(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		private void RefreshAlertByPrice(InventoryItem priceItem)
		{
		}

		private void SubscribeToPrices(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		private void UnsubscribeFromPrices(BaseCollectibleItem<TItemData> baseCollectibleItem)
		{
		}

		private void OnAlertUpgradeChangedHandler(bool alertUpgrade)
		{
		}
	}
}
