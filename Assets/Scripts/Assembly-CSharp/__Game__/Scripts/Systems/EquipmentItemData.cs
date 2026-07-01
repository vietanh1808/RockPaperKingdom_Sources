using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "EquipmentItem", menuName = "TapHub/Inventory/Equipment/EquipmentItem")]
	public class EquipmentItemData : InventoryItemData
	{
		[SerializeField]
		private EquipmentTypeData _equipmentTypeData;

		[SerializeField]
		private UpgradablePlayerStatData _mainStatData;

		[SerializeField]
		private AssetModuleHolder<BaseModifier> _equipmentModifiers;

		public int MaxLevel => 0;

		public EquipmentTypeData EquipmentTypeData => null;

		public EquipmentType EquipmentType => default(EquipmentType);

		public UpgradablePlayerStatData MainStatData => null;

		public List<BaseModifier> EquipmentModifiers => null;

		private void OnEnable()
		{
		}

		public List<BaseModifier> GetUnlockedModifiers(RarityType rarity)
		{
			return null;
		}
	}
}
