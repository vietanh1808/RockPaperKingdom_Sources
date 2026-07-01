using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class PatrolRewardsSystem : IFeatureUnlockSystem, ITickable
	{
		private readonly PatrolRewardsConfig _patrolRewardsConfig;

		private readonly RewardSystem _rewardSystem;

		private readonly StageSystem _stageSystem;

		private readonly Dictionary<string, PatrolRewardLimits> _rewardLimits;

		private readonly Dictionary<int, PatrolDuration> _durationPerStage;

		private PatrolDuration _currentStageDuration;

		private TimeSpan _maxPatrolDuration;

		private bool _isRewardAvailable;

		private bool _isUnlocked;

		private bool _firstUnlockRewardsClaimed;

		public DateTime PatrolStartTime { get; private set; }

		public TimeSpan TotalPatrolDuration { get; private set; }

		public bool IsRewardAvailable
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public List<PatrolDuration> DurationPerStage => null;

		public bool FirstUnlockRewardsClaimed => false;

		public event Action OnTimeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool> OnRewardStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnRewardsClaimed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public PatrolRewardsSystem(PatrolRewardsConfig patrolRewardsConfig, StageSystem stageSystem, RewardSystem rewardSystem)
		{
		}

		public void LoadData(List<PatrolDuration> patrolDurations, DateTime patrolStartTime, bool firstUnlockRewardsClaimed)
		{
		}

		public void Initialize()
		{
		}

		private void InitRewardLimits()
		{
		}

		public void UnlockFeature(bool isFirstUnlock)
		{
		}

		public void Tick()
		{
		}

		public List<Reward> ClaimRewards(RewardDisplayMode rewardDisplayMode)
		{
			return null;
		}

		public List<Reward> GetRewards()
		{
			return null;
		}

		public List<Reward> GetRewardsPerHour()
		{
			return null;
		}

		private List<Reward> GetRewardsSummary()
		{
			return null;
		}

		private void ApplyLimits(List<Reward> finalRewards)
		{
		}

		private void RefreshAvailabilityStatus()
		{
		}

		private void RecoverDurations()
		{
		}

		private void AddDuration(float deltaTime)
		{
		}

		private void Reset()
		{
		}

		private void RefreshCurrentStageDuration()
		{
		}

		private bool ShouldIncludeFirstUnlockRewards()
		{
			return false;
		}

		private List<Reward> CloneRewards(List<Reward> originalRewards)
		{
			return null;
		}
	}
}
