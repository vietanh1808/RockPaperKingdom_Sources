using System;

namespace __Game__.Scripts.Systems.Save
{
	[Serializable]
	public class HeroItemSave
	{
		public int Level;

		public bool IsUnlocked;

		public bool IsNew;

		public bool IsRewardCollected;
	}
}
