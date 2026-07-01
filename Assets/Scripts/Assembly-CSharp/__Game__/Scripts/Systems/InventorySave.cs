using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class InventorySave
	{
		public Dictionary<string, InventoryItemSave> Items;
	}
}
