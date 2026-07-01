using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class SpecialRewardLayoutEntry
	{
		[SerializeField]
		private List<RectTransform> _rewardPositions;

		public List<RectTransform> RewardPositions => null;

		public int Count => 0;
	}
}
