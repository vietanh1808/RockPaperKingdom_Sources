using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	[Serializable]
	public class ArenaChestData
	{
		[SerializeField]
		private int _requiredRating;

		[SerializeField]
		private List<RewardData> _rewards;

		public int RequiredRating => 0;

		public List<Reward> Rewards => null;
	}
}
