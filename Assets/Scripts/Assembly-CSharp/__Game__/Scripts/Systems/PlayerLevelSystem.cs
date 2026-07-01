using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PlayerLevelSystem
	{
		private readonly PlayerLevelUpConfig _playerLevelUpConfig;

		private readonly RewardStorage _rewardStorage;

		public int PreviousLevelIndex { get; private set; }

		public int CurrentLevelIndex { get; private set; }

		public int RequiredExperience { get; private set; }

		public int CurrentExperience { get; private set; }

		public float PreviousExperienceProgress { get; private set; }

		public event Action OnLevelChanged
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

		public event Action OnLevelUpCompleted
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

		public event Action OnExperienceChanged
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

		public PlayerLevelSystem(PlayerLevelUpConfig playerLevelUpConfig)
		{
		}

		public void LoadData(int level, int experience)
		{
		}

		public void AddExperience(int amount)
		{
		}

		public bool TryLevelUp()
		{
			return false;
		}

		public void CompleteLevelUp()
		{
		}

		public List<Reward> GetRewards()
		{
			return null;
		}

		private void PlayerLevelUp()
		{
		}

		private void UpdateRewardsByLevelDictionary()
		{
		}

		private void UpdateRequiredExperience()
		{
		}
	}
}
