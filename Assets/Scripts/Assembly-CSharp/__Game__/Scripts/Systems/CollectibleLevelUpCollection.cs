using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_CollectibleLevelUp", menuName = "TapHub/Collectible/Level Up/Level Up Collection")]
	public class CollectibleLevelUpCollection : SerializedScriptableObject
	{
		[SerializeField]
		private List<CollectibleLevelUpPrices> _priceByRarity;

		public List<PriceData> GetPrice(RarityType rarity, int level, InventoryItemData materialItemData)
		{
			return null;
		}

		public int GetMaterialPrice(RarityType rarity, int level)
		{
			return 0;
		}

		public int GetMaxLevel(RarityType rarity)
		{
			return 0;
		}

		private CollectibleLevelUpPrices GetLevelUpPrices(RarityType rarity)
		{
			return null;
		}
	}
}
