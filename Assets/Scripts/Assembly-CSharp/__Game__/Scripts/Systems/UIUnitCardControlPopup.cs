using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardControlPopup : UIUnitCardInfoPopup
	{
		[Header("UnitCard Control")]
		[SerializeField]
		private UIButtonClick _upgradeButton;

		[SerializeField]
		private GameObject _footerContainer;

		[SerializeField]
		private UIMultiPriceView _multiPriceView;

		[SerializeField]
		private UICollectibleAmountElement _collectibleAmountElement;

		[Header("Delta Stats")]
		[SerializeField]
		private UIStatDeltaElement _uiDeltaStatHealth;

		[SerializeField]
		private UIStatDeltaElement _uiDeltaStatDamage;

		[Header("Unlock Reward")]
		[SerializeField]
		private UICollectibleRewardButton _rewardButton;

		private StaticStatSystem _staticStatSystem;

		private UnitCardConfig _unitCardConfig;

		private InventorySystem _inventorySystem;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private InventoryItem _materialItem;

		[Inject]
		private void Inject(StaticStatSystem staticStatSystem, UnitCardConfig unitCardConfig, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void SetupView()
		{
		}

		protected override void RefreshLevel(BaseCollectibleItem<UnitCardItemData> collectibleItem, bool animated)
		{
		}

		protected override void RefreshStatsView(bool animated)
		{
		}

		private void OnStaticStatsRefreshed()
		{
		}

		private void RefreshDeltaStats(bool animated)
		{
		}

		private void RefreshUnitSpawnDeltaStats(bool animated)
		{
		}

		private void RefreshTowerDeltaStats(bool animated)
		{
		}

		private void SetDeltaStat(UIStatDeltaElement element, UnitStatType statType, Dictionary<UnitStatType, float> rawBaseStats, Dictionary<UnitStatType, float> levelStats, Dictionary<UnitStatType, float> multipliers, Dictionary<UnitStatType, float> additives, bool animated)
		{
		}

		private void SetupDeltaStatsVisibility()
		{
		}

		private void SetupUpgradeControlsVisibility()
		{
		}

		private void RefreshRewardButton()
		{
		}

		private void OnRewardClaimed()
		{
		}

		private void RefreshLevelUpControls()
		{
		}

		private void UpgradeButtonClicked()
		{
		}

		private void OnMaterialAmountChanged(InventoryItem inventoryItem)
		{
		}

		private void RefreshAmount()
		{
		}
	}
}
