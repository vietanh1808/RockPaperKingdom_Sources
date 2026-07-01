using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "TalentRewardData", menuName = "TapHub/Talents/Talent Reward Data")]
	public class TalentRewardData : BaseTalentData
	{
		[Header("Base Rewards")]
		[SerializeField]
		private List<RewardData> _baseRewards;

		[Header("Generate Settings")]
		[SerializeField]
		private int _levelsAmount;

		[SerializeField]
		private int _addPerLevel;

		[Header("Generated Rewards Per Level")]
		[SerializeField]
		private List<TalentRewardLevel> _rewardLevels;

		public override int MaxLevelIndex => 0;

		private bool ShowGenerateButton => false;

		public List<Reward> GetRewards(int levelIndex)
		{
			return null;
		}

		public override string GetDescription(int levelIndex)
		{
			return null;
		}
	}
}
