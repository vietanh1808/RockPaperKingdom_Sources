using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PatrolRewardBundle
	{
		[SerializeField]
		private List<PatrolReward> _rewards;

		public List<Reward> GetRewards(float hours)
		{
			return null;
		}
	}
}
