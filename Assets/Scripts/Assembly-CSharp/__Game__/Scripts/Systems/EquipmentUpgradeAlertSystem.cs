using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class EquipmentUpgradeAlertSystem
	{
		private readonly Dictionary<InventoryItem, List<EquipmentItem>> _equipmentListPerPrice;

		private readonly Dictionary<EquipmentItem, List<PriceData>> _pricePerEquipment;

		private readonly EquipmentSystem _equipmentSystem;

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

		public EquipmentUpgradeAlertSystem(EquipmentSystem equipmentSystem, InventorySystem inventorySystem)
		{
		}

		public void Initialize()
		{
		}

		private void AddEquippedItem(EquipmentItem equipmentItem)
		{
		}

		private void RemoveUnequippedItem(EquipmentItem equipmentItem)
		{
		}

		private void RefreshAlertForItem(EquipmentItem equipmentItem)
		{
		}

		private void RefreshAlertByPrice(InventoryItem priceItem)
		{
		}

		private void SubscribeToPrices(EquipmentItem equipmentItem)
		{
		}

		private void UnsubscribeFromPrices(EquipmentItem equipmentItem)
		{
		}

		private void OnUpgradeStatusChangedHandler(bool alertUpgrade)
		{
		}
	}
}
