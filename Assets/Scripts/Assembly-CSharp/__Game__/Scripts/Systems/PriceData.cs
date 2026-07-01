using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PriceData : IInventoryItemHolder
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private int _amount;

		public InventoryItemData InventoryItemData => null;

		public int Amount => 0;

		public PriceData(InventoryItemData inventoryItemData, int amount)
		{
		}

		public InventoryItem ToInventoryItem()
		{
			return null;
		}
	}
}
