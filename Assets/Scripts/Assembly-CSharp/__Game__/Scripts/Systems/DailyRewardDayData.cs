using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class DailyRewardDayData
	{
		[SerializeField]
		private List<RewardData> _rewards;

		public List<Reward> ToRewards()
		{
			return null;
		}
	}
}
