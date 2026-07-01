using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "InventoryItemBundle_", menuName = "TapHub/Inventory/Inventory Item Bundle")]
	public class InventoryItemBundleData : InventoryItemData
	{
		[SerializeField]
		private List<InventoryItemWeightData> _items;

		public InventoryItemData GetRandomItem()
		{
			return null;
		}

		private void RecalculateWeightPercents()
		{
		}
	}
}
