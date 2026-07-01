using System;
using System.Collections.Generic;

namespace __Simulation__.Systems
{
	[Serializable]
	public class InventoryItemSnapshot
	{
		public int CurrentBalance;

		public int TotalEarned;

		public int TotalSpend;

		public Dictionary<string, int> SourceByType { get; private set; }

		public Dictionary<string, int> SinkByType { get; private set; }

		public InventoryItemSnapshot GetCopy()
		{
			return null;
		}

		public void Combine(InventoryItemSnapshot snapshot)
		{
		}
	}
}
