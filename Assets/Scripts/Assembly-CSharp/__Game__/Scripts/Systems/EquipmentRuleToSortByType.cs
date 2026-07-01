using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "RuleToSortByType_Equipment", menuName = "TapHub/Inventory/Equipment/EquipmentRuleToSortByType")]
	public class EquipmentRuleToSortByType : ScriptableObject
	{
		[SerializeField]
		private List<EquipmentTypeData> _equipmentTypes;

		public void SortEquipmentByType(List<EquipmentItemData> collection)
		{
		}
	}
}
