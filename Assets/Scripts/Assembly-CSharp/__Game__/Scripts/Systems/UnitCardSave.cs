using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems.Save;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class UnitCardSave
	{
		public Dictionary<string, UnitCardItemSave> Items;

		public List<string> PendingUnlockGuids;
	}
}
