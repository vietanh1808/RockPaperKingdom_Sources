using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_Equipment", menuName = "TapHub/Configs/Equipment Config")]
	public class EquipmentConfig : SerializedScriptableObject
	{
		[SerializeField]
		private EquipmentCollection _equipmentCollection;

		[SerializeField]
		private EquipmentLevelUpCollection _equipmentLevelUpCollection;

		[SerializeField]
		private EquipmentRuleToSortByType _equipmentRuleToSortByType;

		[SerializeField]
		private InventoryItemBundleData _equipmentItemBundle;

		public EquipmentCollection Equipments => null;

		public EquipmentLevelUpCollection LevelUp => null;

		public EquipmentRuleToSortByType RuleToSortByType => null;

		public InventoryItemBundleData EquipmentItemBundle => null;
	}
}
