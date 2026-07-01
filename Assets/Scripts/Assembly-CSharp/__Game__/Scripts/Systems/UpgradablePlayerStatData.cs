using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "UpgradablePlayerStatData", menuName = "TapHub/Stats/UpgradablePlayerStatData")]
	public class UpgradablePlayerStatData : ScriptableObject
	{
		[SerializeField]
		private PlayerStatType _playerStatType;

		[SerializeField]
		private List<float> _valueByRarity;

		[SerializeField]
		private List<float> _multiplierByLevel;

		public PlayerStatType PlayerStatType => default(PlayerStatType);

		public List<float> MultiplierByLevel => null;

		public float GetStatValue(RarityType rarity, int level)
		{
			return 0f;
		}
	}
}
