using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class TalentCollectionSave
	{
		public Dictionary<string, TalentSave> Items;

		public int FirstUnlockOrderIndex;

		public int TotalDrawCount;
	}
}
