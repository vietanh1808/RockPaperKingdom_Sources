using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class EquipmentSystem : DirtySaveLoadProvider
	{
		private readonly EquipmentConfig _equipmentConfig;

		private readonly InventorySystem _inventorySystem;

		public readonly Dictionary<EquipmentType, EquipmentTypeLevel> EquipmentTypeLevels;

		public List<EquipmentItem> Items { get; }

		public Dictionary<EquipmentType, EquipmentItem> EquippedItems { get; }

		public event Action<EquipmentItem> OnEquipmentAdded
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

		public event Action<EquipmentItem> OnEquipmentRemoved
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

		public event Action<EquipmentItem> OnEquipped
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

		public event Action<EquipmentItem> OnUnequipped
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

		public event Action OnEquippedItemChanged
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

		public EquipmentSystem(EquipmentConfig equipmentConfig, InventorySystem inventorySystem)
		{
		}

		public void AddItem(EquipmentItem item)
		{
		}

		public void RemoveItem(EquipmentItem item)
		{
		}

		public void EquipItem(EquipmentItem item)
		{
		}

		public void UnequipItem(EquipmentItem item)
		{
		}

		public void LevelUp(EquipmentItem item)
		{
		}

		public void MaxLevelUp(EquipmentItem item)
		{
		}

		public void LevelDown(EquipmentItem item)
		{
		}

		public bool CanUpgrade(EquipmentItem item)
		{
			return false;
		}

		public EquipmentItem CreateEquipmentItem(EquipmentItemData data, RarityType rarity, bool isEquipped = false)
		{
			return null;
		}

		public List<PriceData> GetLevelUpPrice(EquipmentItem item)
		{
			return null;
		}

		public EquipmentItem GetEquippedItem(EquipmentType equipmentType)
		{
			return null;
		}

		private EquipmentTypeLevel GetEquipmentTypeLevel(EquipmentType equipmentType)
		{
			return null;
		}

		private bool TryLevelUp(EquipmentItem item)
		{
			return false;
		}
	}
}
