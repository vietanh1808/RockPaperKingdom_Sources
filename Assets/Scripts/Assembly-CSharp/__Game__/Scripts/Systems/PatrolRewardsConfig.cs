using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_PatrolRewards", menuName = "TapHub/LiveOps/Patrol Rewards Config")]
	public class PatrolRewardsConfig : SerializedScriptableObject
	{
		[SerializeField]
		private TimeData _unlockedTime;

		[SerializeField]
		private TimeData _maxPatrolTime;

		[Header("Rewards")]
		[SerializeField]
		private TimeData _noRewardTime;

		[SerializeField]
		private List<PatrolRewardBundle> _rewardsByStage;

		[SerializeField]
		private List<PatrolRewardLimits> _rewardLimits;

		[Header("First Unlock Rewards")]
		[SerializeField]
		private List<Reward> _firstUnlockRewards;

		[Header("Quick Patrol")]
		[SerializeField]
		private int _quickPatrolHours;

		[SerializeField]
		private int _quickPatrolEnergyCost;

		[SerializeField]
		private int _quickPatrolUsesLimit;

		[SerializeField]
		private TimeData _quickPatrolCooldown;

		[SerializeField]
		private InventoryItemData _unlimitedQuickPatrolItemData;

		public TimeData UnlockedTime => default(TimeData);

		public TimeData MaxPatrolTime => default(TimeData);

		public TimeData NoRewardTime => default(TimeData);

		public List<PatrolRewardLimits> RewardLimits => null;

		public List<Reward> FirstUnlockRewards => null;

		public int QuickPatrolHours => 0;

		public int QuickPatrolEnergyCost => 0;

		public int QuickPatrolUsesLimit => 0;

		public TimeData QuickPatrolCooldown => default(TimeData);

		public InventoryItemData UnlimitedQuickPatrolItemData => null;

		public PatrolRewardBundle GetRewardsPerStage(int stage)
		{
			return null;
		}
	}
}
