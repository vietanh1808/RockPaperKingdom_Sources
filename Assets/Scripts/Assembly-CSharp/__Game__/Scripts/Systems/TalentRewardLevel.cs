using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class TalentRewardLevel
	{
		[SerializeField]
		private List<RewardData> _rewards;

		public List<RewardData> Rewards => null;

		public TalentRewardLevel()
		{
		}

		public TalentRewardLevel(List<RewardData> rewards)
		{
		}

		public string GetDescription()
		{
			return null;
		}
	}
}
