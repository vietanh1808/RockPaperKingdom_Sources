using System;
using System.Collections.Generic;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class RewardSystem : IDisposable
	{
		private readonly InventorySystem _inventorySystem;

		private readonly EquipmentSystem _equipmentSystem;

		private readonly EnergySystem _energySystem;

		private readonly ArenaTicketSystem _arenaTicketSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly StageSystem _stageSystem;

		private readonly PatrolRewardsConfig _patrolRewardsConfig;

		private readonly UIRewardOverlay _uiRewardOverlay;

		private readonly UIRewardOverlaySpecial _uiRewardOverlaySpecial;

		private readonly UIRewardFloating _uiRewardFloating;

		private readonly ChestAvailableUnitCardProvider _chestAvailableUnitCardProvider;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private List<Reward> _pendingRewards;

		public RewardSystem(EquipmentSystem equipmentSystem, EnergySystem energySystem, ArenaTicketSystem arenaTicketSystem, InventorySystem inventorySystem, PlayerLevelSystem playerLevelSystem, StageSystem stageSystem, PatrolRewardsConfig patrolRewardsConfig, UIRewardOverlay uiRewardOverlay, UIRewardOverlaySpecial uiRewardOverlaySpecial, UIRewardFloating uiRewardFloating, ChestAvailableUnitCardProvider chestAvailableUnitCardProvider, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public List<Reward> ClaimReward(List<Reward> rewards, RewardDisplayMode rewardDisplayMode)
		{
			return null;
		}

		public List<Reward> ClaimReward(List<Reward> rewards, RewardDisplayMode rewardDisplayMode, EconomyEventData economyEventData)
		{
			return null;
		}

		private void ProceedPendingRewards()
		{
		}

		private void ProceedPendingReward(Reward reward)
		{
		}

		private void ProceedClaimEquipmentReward(Reward reward, EquipmentItemData data)
		{
		}

		private List<Reward> GetCombinedRewardsWithoutBundles(List<Reward> rewardsWithBundles)
		{
			return null;
		}
	}
}
