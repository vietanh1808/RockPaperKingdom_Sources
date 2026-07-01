using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Arena.UI;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIMenuSceneNavigation : UIBaseSceneNavigation
	{
		[Header("Panels")]
		[SerializeField]
		private RectTransform _mainMenuPanel;

		[SerializeField]
		private RectTransform _equipmentMergePanel;

		[SerializeField]
		private RectTransform _stageChestPanel;

		[Header("Menu Pages")]
		[SerializeField]
		private UINavigationController _uiMenuNavigationController;

		[SerializeField]
		private UIShopPage _uiShopPage;

		[Header("Popups")]
		[SerializeField]
		private UIPurchaseEnergyPopup _purchaseEnergyPopup;

		[SerializeField]
		private UISpeedUpPurchasePopup _uiSpeedUpPurchasePopup;

		[SerializeField]
		private UIEquipmentInfoPopup _uiEquipmentInfoPopup;

		[SerializeField]
		private UIEquipmentUpgradeRefundPopup _uiEquipmentUpgradeRefundPopup;

		[SerializeField]
		private UIHeroUnlockPopup _uiHeroUnlockPopup;

		[SerializeField]
		private UIUnitCardUnlockPopup _uiUnitCardUnlockPopup;

		[SerializeField]
		private UIHeroControlPopup _uiHeroControlPopup;

		[SerializeField]
		private UIUnitCardControlPopup _uiUnitCardControlPopup;

		[SerializeField]
		private UIChestInfoPopup _uiChestInfoPopup;

		[SerializeField]
		private UIDailyRewardsPopup _uiDailyRewardsPopup;

		[SerializeField]
		private UIPatrolRewardsPopup _uiPatrolRewardsPopup;

		[SerializeField]
		private UIAppReviewPopup _uiAppReviewPopup;

		[SerializeField]
		private UITalentDrawPopup _uiTalentDrawPopup;

		[SerializeField]
		private UITalentInfoPopup _uiTalentInfoPopup;

		[SerializeField]
		private UIPurchaseArenaTicketPopup _purchaseArenaTicketPopup;

		[SerializeField]
		private UIArenaLeaderboardPopup _arenaLeaderboardPopup;

		[SerializeField]
		private UIDailyStreakQuestPopup _dailyStreakQuestPopup;

		[Header("Other")]
		[SerializeField]
		private UIRewardChest _uiRewardChest;

		[SerializeField]
		private UIFeaturesUnlockPopup _uiFeaturesUnlockPopup;

		[SerializeField]
		private UIPlayerLevelUpPopup _uiPlayerLevelUpPopup;

		[SerializeField]
		private UICollectibleItemUnlockPopup _uiCollectibleItemUnlockPopup;

		[SerializeField]
		private UIMenuHeader _uiMenuHeader;

		private EventQueueSystem _eventQueueSystem;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private OpenPopupQueueEvent _openLevelUpQueueEvent;

		private OpenPopupQueueEvent _openDailyRewardQueueEvent;

		private OpenPopupQueueEvent _openPatrolQueueEvent;

		public UIMenuHeader UIMenuHeader => null;

		public UIHeroControlPopup HeroControlPopup => null;

		[Inject]
		private void Inject(EventQueueSystem eventQueueSystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void OpenMainMenuPanel()
		{
		}

		public void FocusArenaPage()
		{
		}

		public void OpenShopPanel(float targetPosition = 0f)
		{
		}

		public void OpenEquipmentMergePanel()
		{
		}

		public void OpenStageChestPanel()
		{
		}

		public void OpenTalentDrawPopupImmediate(TalentRuntime talentRuntime, Vector2 targetPosition, Action onLandingCompleted)
		{
		}

		public void OpenTalentInfoPopup(TalentRuntime talentRuntime)
		{
		}

		public void OpenPurchaseEnergyPopup()
		{
		}

		public void OpenPurchaseArenaTicketPopup()
		{
		}

		public void OpenArenaLeaderboardPopup()
		{
		}

		public void OpenDailyStreakQuestPopup()
		{
		}

		public void OpenSpeedUpPurchasePopup()
		{
		}

		public void OpenEquipmentInfoPopup(EquipmentItem equipmentItem)
		{
		}

		public void OpenEquipmentRefundPopup(EquipmentItem equipmentItem)
		{
		}

		public void OpenChestInfoPopup(ChestData chestData)
		{
		}

		public void OpenDailyRewardPopup()
		{
		}

		public void OpenDailyRewardPopupImmediate()
		{
		}

		public void OpenPatrolRewardPopupImmediate()
		{
		}

		public void OpenAppReviewPopup()
		{
		}

		public void ShowLevelUp()
		{
		}

		public void ShowFeatureUnlock(FeatureItem featureItem)
		{
		}

		public void OpenHeroControlPopup<TItem, TItemData>(TItem collectibleItem) where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
		{
		}

		public void ShowHeroItemUnlock(BaseCollectibleItemData collectibleItemData, Action<string> onClosed)
		{
		}

		public void ShowUnitCardItemUnlock(BaseCollectibleItemData collectibleItemData, Action<string> onClosed)
		{
		}

		public void ShowInlineUnitCardUnlock(UnitCardItemData unitCardItemData, Action<string> onClosed)
		{
		}

		public void OpenChest(ChestDataAmount chestDataAmount)
		{
		}

		public void OpenUnitCardControlPopup<TItem, TItemData>(TItem collectibleItem) where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
		{
		}
	}
}
