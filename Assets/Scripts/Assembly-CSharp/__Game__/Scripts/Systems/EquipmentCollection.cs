using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_Equipment", menuName = "TapHub/Inventory/Equipment/EquipmentCollection")]
	public class EquipmentCollection : SerializedScriptableObject
	{
		[SerializeField]
		private string _folderPath;

		[SerializeField]
		private Dictionary<string, EquipmentItemData> _equipmentInventoryItems;

		[SerializeField]
		private Dictionary<EquipmentType, List<EquipmentItemData>> _equipmentByType;

		public Dictionary<string, EquipmentItemData> EquipmentInventoryItems => null;

		public EquipmentItemData GetItemData(string guid)
		{
			return null;
		}

		public List<EquipmentItemData> GetEquipmentsByType(EquipmentType equipmentType)
		{
			return null;
		}
	}
}
