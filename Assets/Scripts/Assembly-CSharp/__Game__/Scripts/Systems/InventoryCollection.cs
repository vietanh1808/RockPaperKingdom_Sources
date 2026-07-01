using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_Inventory", menuName = "TapHub/Inventory/Inventory Collection")]
	public class InventoryCollection : ScriptableObject
	{
		public List<InventoryItemData> InventoryItems;
	}
}
