using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "RewardsPerWeekData", menuName = "TapHub/LiveOps/Rewards Per Week")]
	public class RewardsPerWeekData : ScriptableObject
	{
		[SerializeField]
		private List<DailyRewardDayData> _days;

		public List<Reward> GetRewardsByDay(int day)
		{
			return null;
		}
	}
}
