namespace __Game__.Scripts.Systems
{
	public class TalentRuntime
	{
		public BaseTalentData Data { get; }

		public int LevelIndex { get; private set; }

		public bool IsUnlocked { get; private set; }

		public TalentRuntime(BaseTalentData data, TalentSave save)
		{
		}

		public void Unlock()
		{
		}

		public void LevelUp()
		{
		}
	}
}
