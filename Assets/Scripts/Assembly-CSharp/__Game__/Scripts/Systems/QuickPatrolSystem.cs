using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class QuickPatrolSystem : IDisposable
	{
		private const string PLACEMENT = "quick_patrol";

		private const string COOLDOWN_GUID = "quick_patrol_cooldown";

		private readonly PatrolRewardsConfig _patrolRewardsConfig;

		private readonly EnergySystem _energySystem;

		private readonly InventorySystem _inventorySystem;

		private readonly IAdsService _adsService;

		private readonly CooldownSystem _cooldownSystem;

		private readonly RewardSystem _rewardSystem;

		private readonly StageSystem _stageSystem;

		private CooldownListener[] _cooldownSlots;

		private InventoryItem _unlimitedItem;

		private bool _isPurchaseInProgress;

		private bool _isAvailable;

		public int EnergyCost => 0;

		public int UsesLimit => 0;

		public int AvailableSlotsCount => 0;

		public Sprite EnergyIcon => null;

		public bool IsUnlimited => false;

		public bool HasEnoughEnergy => false;

		public bool IsRewardedAdsReady => false;

		public bool AllSlotsOnCooldown => false;

		public TimeSpan MinCooldownTime => default(TimeSpan);

		public event Action OnStatusChanged
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

		public event Action<TimeSpan> OnCooldownTimeChanged
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

		public QuickPatrolSystem(PatrolRewardsConfig patrolRewardsConfig, EnergySystem energySystem, InventorySystem inventorySystem, IAdsService adsService, CooldownSystem cooldownSystem, RewardSystem rewardSystem, StageSystem stageSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public bool IsAvailable()
		{
			return false;
		}

		public void Purchase(Action<bool> onCompleted)
		{
		}

		private void OnVideoRewarded(bool isSuccess, Action<bool> onCompleted)
		{
		}

		private void CompletePurchase()
		{
		}

		private void GrantRewards()
		{
		}

		private void CreateCooldownSlots()
		{
		}

		private void AddCooldownToNextSlot()
		{
		}

		private void OnEnergyAmountChanged(int amount)
		{
		}

		private void OnRewardedStatusChanged()
		{
		}

		private void OnUnlimitedAmountChanged(InventoryItem inventoryItem)
		{
		}

		private void OnCooldownStatusChanged(bool isCooldown)
		{
		}

		private void OnCooldownSlotTimeChanged(TimeSpan time)
		{
		}

		private void RefreshAvailability()
		{
		}

		private bool GetAvailableStatus()
		{
			return false;
		}
	}
}
