using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Systems.DailyStreakQuest
{
	[Serializable]
	public class DailyStreakQuestSave
	{
		public DateTime EventStartDate;

		public List<string> CompletedQuestGuids;

		public List<int> ClaimedMilestoneIndices;

		public int TotalPoints;

		public Dictionary<string, int> QuestCounters;
	}
}
