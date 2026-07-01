using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class DailyRewardsSystem : IFeatureUnlockSystem
	{
		private const string COOLDOWN_GUID = "DailyRewardsCooldown";

		private readonly DailyRewardsConfig _dailyRewardsConfig;

		private readonly CooldownSystem _cooldownSystem;

		private readonly RewardSystem _rewardSystem;

		private readonly HeroSystem _heroSystem;

		private readonly LocalNotificationService _localNotificationService;

		public CooldownListener Cooldown { get; }

		public int CurrentWeek { get; private set; }

		public int CurrentDay { get; private set; }

		public bool IsFeatureUnlocked { get; private set; }

		public bool IsFirstWeek => false;

		public bool IsReadyReward => false;

		public event Action OnWeekChanged
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

		public DailyRewardsSystem(DailyRewardsConfig dailyRewardsConfig, CooldownSystem cooldownSystem, RewardSystem rewardSystem, HeroSystem heroSystem, LocalNotificationService localNotificationService)
		{
		}

		public void LoadData(int week, int day)
		{
		}

		public void UnlockFeature(bool isFirstUnlock)
		{
		}

		public void Initialize()
		{
		}

		public List<Reward> ClaimReward(RewardDisplayMode rewardDisplayMode)
		{
			return null;
		}

		public List<Reward> ClaimDoubleReward(RewardDisplayMode rewardDisplayMode)
		{
			return null;
		}

		private List<Reward> ClaimRewardInternal(RewardDisplayMode rewardDisplayMode, int multiplier)
		{
			return null;
		}

		public bool HasHeroRewardForCurrentDay()
		{
			return false;
		}

		private bool HasHeroReward(List<Reward> rewards)
		{
			return false;
		}

		private void AddPendingHeroUnlocks(List<Reward> rewards)
		{
		}

		private void CheckWeeklyCycle(bool isCooldown)
		{
		}

		public List<Reward> GetRewardsByDay(int day)
		{
			return null;
		}

		private void AddCooldown()
		{
		}
	}
}
