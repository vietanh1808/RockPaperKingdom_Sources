using System;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	[Serializable]
	public class EquipmentItemSnapshot
	{
		public EquipmentItem EquipmentItem;

		public int Level;

		public EquipmentItemSnapshot GetCopy()
		{
			return null;
		}
	}
}
