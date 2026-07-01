using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleSystem<TItem, TItemData> : DirtySaveLoadProvider, IFeatureUnlockSystem where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly BaseCollectibleConfig<TItemData> _collectibleConfig;

		private readonly InventorySystem _inventorySystem;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		public Dictionary<string, TItem> Items { get; }

		public List<BaseCollectibleItemData> PendingUnlockItems { get; }

		public List<TItem> UnlockedItems { get; }

		public bool IsUnlockedFeature { get; private set; }

		protected abstract string UpgradeTransactionName { get; }

		public event Action OnInitialized
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

		public event Action<TItem> OnCollectibleItemUnlocked
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

		public event Action<TItem> OnCollectibleItemLocked
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

		public event Action<TItemData> OnPendingUnlockItemAdded
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

		public event Action<TItem> OnItemLevelChanged
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

		protected BaseCollectibleSystem(BaseCollectibleConfig<TItemData> collectibleConfig, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void UnlockFeature(bool isFirstUnlock)
		{
		}

		public virtual void Initialize()
		{
		}

		protected virtual bool IsItemUnlockedByDefault(TItem item)
		{
			return false;
		}

		public void AddPendingUnlockItem(TItem item)
		{
		}

		public bool IsUnlockedOrPendingUnlock(TItem item)
		{
			return false;
		}

		public virtual void UnlockItem(string guid)
		{
		}

		public void LockItem(string guid)
		{
		}

		public bool LevelUp(TItem item)
		{
			return false;
		}

		private bool TryLevelUp(TItem item)
		{
			return false;
		}

		public bool CanUpgrade(TItem item)
		{
			return false;
		}

		public InventoryItem GetMaterialItem(TItem item)
		{
			return null;
		}

		public virtual List<TItem> GetActiveItems()
		{
			return null;
		}

		public int GetRequiredAmountMaterialForLevelUp(RarityType rarity, int levelIndex)
		{
			return 0;
		}

		public int GetMaxLevel(TItem item)
		{
			return 0;
		}

		public List<PriceData> GetLevelUpPriceList(TItem item)
		{
			return null;
		}

		public TItem GetItemByGuid(string guid)
		{
			return null;
		}

		public TItem GetItemByData(TItemData data)
		{
			return null;
		}

		public void ClearIsNew(TItem item)
		{
		}
	}
}
