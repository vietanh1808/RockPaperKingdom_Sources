using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.DailyStreakQuest
{
	[Serializable]
	public class PointsMilestoneData
	{
		[SerializeField]
		private int _requiredPoints;

		[SerializeField]
		private List<RewardData> _rewards;

		public int RequiredPoints => 0;

		public List<RewardData> Rewards => null;
	}
}
