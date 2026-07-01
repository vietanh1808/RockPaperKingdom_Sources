using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.DailyStreakQuest
{
	[CreateAssetMenu(fileName = "Config_DailyStreakQuest", menuName = "TapHub/LiveOps/Daily Streak Quest Config")]
	public class DailyStreakQuestConfig : ScriptableObject
	{
		[SerializeField]
		private int _durationDays;

		[SerializeField]
		private int _pointsPerQuest;

		[SerializeField]
		private List<DailyStreakDayData> _days;

		[SerializeField]
		private List<PointsMilestoneData> _milestoneRewards;

		public int DurationDays => 0;

		public int PointsPerQuest => 0;

		public List<DailyStreakDayData> Days => null;

		public List<PointsMilestoneData> MilestoneRewards => null;
	}
}
