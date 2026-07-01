using System;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	[Serializable]
	public class TalentItemSnapshot
	{
		public BaseTalentData Data;

		public int LevelIndex;

		public bool IsUnlocked;

		public TalentItemSnapshot GetCopy()
		{
			return null;
		}
	}
}
