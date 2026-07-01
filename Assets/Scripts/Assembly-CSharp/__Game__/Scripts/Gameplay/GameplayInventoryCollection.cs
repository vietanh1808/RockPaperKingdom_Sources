using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Collection_GameplayInventory", menuName = "TapHub/Gameplay/Gameplay Inventory Collection")]
	public class GameplayInventoryCollection : ScriptableObject
	{
		public List<InventoryItemData> InventoryItems;
	}
}
