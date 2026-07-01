using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.Bundles
{
	[CreateAssetMenu(fileName = "RarityItemBundle_UnitCard", menuName = "TapHub/Inventory/UnitCard Rarity Item Bundle")]
	public class UnitCardRarityBundleData : InventoryItemData
	{
		[SerializeField]
		private List<RarityItemWeightData> _items;

		public RarityType GetRandomRarity()
		{
			return default(RarityType);
		}

		private void RecalculateWeightPercents()
		{
		}
	}
}
