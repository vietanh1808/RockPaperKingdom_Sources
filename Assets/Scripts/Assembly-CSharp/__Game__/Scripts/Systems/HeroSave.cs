using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems.Save;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class HeroSave
	{
		public Dictionary<string, HeroItemSave> Items;

		public List<string> ActiveHeroGuids;

		public List<string> PendingUnlockGuids;
	}
}
