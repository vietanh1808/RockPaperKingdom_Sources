using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_DailyRewards", menuName = "TapHub/LiveOps/Daily Rewards Config")]
	public class DailyRewardsConfig : ScriptableObject
	{
		[SerializeField]
		private List<RewardsPerWeekData> _rewardsPerWeeks;

		public List<Reward> GetRewardsByWeekDay(int week, int day)
		{
			return null;
		}
	}
}
