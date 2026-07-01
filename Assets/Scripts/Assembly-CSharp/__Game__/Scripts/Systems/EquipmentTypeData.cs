using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "EquipmentType", menuName = "TapHub/Inventory/Equipment/EquipmentType")]
	public class EquipmentTypeData : ScriptableObject
	{
		[SerializeField]
		private EquipmentType _type;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private Sprite _outlineIcon;

		[SerializeField]
		private InventoryItemData _equipmentMaterial;

		public EquipmentType Type => default(EquipmentType);

		public Sprite Icon => null;

		public Sprite OutlineIcon => null;

		public InventoryItemData EquipmentMaterial => null;
	}
}
