using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class StageChestData
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float _castleHPPercent;

		[SerializeField]
		private StageChestType _chestType;

		[SerializeField]
		private List<RewardData> _rewards;

		public float CastleHPPercent => 0f;

		public StageChestType ChestType => default(StageChestType);

		public List<Reward> Rewards => null;

		public void SetCastleHPPercent(float value)
		{
		}

		public string GetShortMessage()
		{
			return null;
		}

		public string GetLongMessage()
		{
			return null;
		}
	}
}
