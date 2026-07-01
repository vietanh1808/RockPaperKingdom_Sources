using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "EquipmentLevelUpPrice", menuName = "TapHub/Inventory/Equipment/LevelUp/EquipmentLevelUpPrice")]
	public class EquipmentLevelUpPrices : ScriptableObject
	{
		[SerializeField]
		private List<EquipmentLevelUpPrice> _priceByLevel;

		public EquipmentLevelUpPrice GetPrice(int level)
		{
			return null;
		}
	}
}
