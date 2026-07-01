using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroControlPopup : UIHeroInfoPopup
	{
		[Header("Hero Stats")]
		[SerializeField]
		private UIStatElement _uiStatHealth;

		[SerializeField]
		private UIStatElement _uiStatDamage;

		[Header("Tabs")]
		[SerializeField]
		private Toggle _upgradeTab;

		[SerializeField]
		private Toggle _cardsTab;

		[SerializeField]
		private UIButtonClick _upgradeTabLockedButton;

		[Header("Tab Containers")]
		[SerializeField]
		private GameObject _upgradeContainer;

		[SerializeField]
		private GameObject _cardsContainer;

		[Header("Cards")]
		[SerializeField]
		private UIHeroUnitCardInventoryView _unitCardInventoryView;

		[SerializeField]
		private UIHeroUnitCardNewAlert _unitCardNewAlert;

		[SerializeField]
		private TMP_Text _cardsUnlockedCount;

		[Header("Hero Control")]
		[SerializeField]
		private UIButtonClick _selectButton;

		[SerializeField]
		private UIButtonClick _upgradeButton;

		[SerializeField]
		private UIMultiPriceView _multiPriceView;

		[Header("Modifiers")]
		[SerializeField]
		private UICollectibleModifiersView _collectibleModifiersView;

		[Header("Unlock Reward")]
		[SerializeField]
		private UICollectibleRewardButton _rewardButton;

		private FeatureItem _heroUpgradeFeatureItem;

		private UnitCardSystem _unitCardSystem;

		private HeroConfig _heroConfig;

		private InventorySystem _inventorySystem;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private bool _hasNewCards;

		public bool IsCardsTabActive => false;

		public event Action OnCardsTabActivated
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

		[Inject]
		private void Inject(FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig, UnitCardSystem unitCardSystem, HeroConfig heroConfig, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void RefreshSelectControls()
		{
		}

		protected override void RefreshLevel(BaseCollectibleItem<HeroItemData> collectibleItem, bool animated)
		{
		}

		private void RefreshLevelUpControls()
		{
		}

		private void OnHeroUpgradeFeatureStatusChanged(FeatureItem featureItem)
		{
		}

		private void SelectButtonClicked()
		{
		}

		private void UpgradeButtonClicked()
		{
		}

		private void OnUpgradeTabValueChanged(bool isOn)
		{
		}

		private void OnCardsTabValueChanged(bool isOn)
		{
		}

		private void OnUnitCardAlertVisibilityChanged(bool hasNewCards)
		{
		}

		private void RefreshUnitCardAlertVisibility()
		{
		}

		private void RefreshRewardButton()
		{
		}

		private void OnRewardClaimed()
		{
		}

		private void RefreshCardsTitle()
		{
		}

		private void UpdateContainers()
		{
		}

		private void UpdateUpgradeTabLockState()
		{
		}

		private void RefreshStatsView(bool animated)
		{
		}
	}
}
