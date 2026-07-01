using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class EquipmentSave
	{
		public List<EquipmentItemSave> Items;

		public List<EquipmentTypeLevelSave> EquipmentTypeLevels;
	}
}
