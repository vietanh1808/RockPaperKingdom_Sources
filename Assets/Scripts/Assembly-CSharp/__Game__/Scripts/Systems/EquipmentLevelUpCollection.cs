using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_EquipmentLevelUp", menuName = "TapHub/Inventory/Equipment/LevelUp/EquipmentLevelUpCollection")]
	public class EquipmentLevelUpCollection : SerializedScriptableObject
	{
		[SerializeField]
		private List<EquipmentLevelUpPrices> _priceByRarity;

		public List<PriceData> GetPrice(RarityType rarityType, int level, InventoryItemData materialItemData)
		{
			return null;
		}
	}
}
