using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.Data
{
	[Serializable]
	public class PlayerLevelUpData
	{
		[SerializeField]
		private int _experienceAmount;

		[SerializeField]
		private List<RewardData> _rewards;

		public int Experience => 0;

		public List<Reward> Rewards => null;
	}
}
