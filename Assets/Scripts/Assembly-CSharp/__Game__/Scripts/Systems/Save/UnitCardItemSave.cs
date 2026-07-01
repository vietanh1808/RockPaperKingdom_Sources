using System;

namespace __Game__.Scripts.Systems.Save
{
	[Serializable]
	public class UnitCardItemSave
	{
		public int Level;

		public bool IsUnlocked;

		public bool IsNew;

		public bool IsNewGameplay;

		public bool IsRewardCollected;
	}
}
