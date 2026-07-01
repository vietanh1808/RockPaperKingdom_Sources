using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroUpgradeMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _targetPage;

		[SerializeField]
		private RectTransform _targetNavigationButtonContainer;

		[Header("Step 2")]
		[SerializeField]
		private UIHeroSlotView _uiHeroSlotView;

		[SerializeField]
		private RectTransform _collectibleRootContainer;

		[Header("Step 3")]
		[SerializeField]
		private UIHeroControlPopup _uiHeroControlPopup;

		[SerializeField]
		private RectTransform _collectibleUpgradeButtonContainer;

		[SerializeField]
		private UIButtonClick _collectibleUpgradeButtonClick;

		[Header("Step 4")]
		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private RectTransform _closeButtonContainer;

		[SerializeField]
		private UIButtonClick _closeButtonClick;

		[Header("Step 5")]
		[SerializeField]
		private RectTransform _homeNavigationButtonContainer;

		[SerializeField]
		private UIButtonClick _homeNavigationButtonClick;

		[Header("Step 6")]
		[SerializeField]
		private RectTransform _playButtonContainer;

		[SerializeField]
		private UIButtonClick _playButtonClick;

		private HeroUpgradeAlertSystem _heroUpgradeAlertSystem;

		private HeroSystem _heroSystem;

		private InventorySystem _inventorySystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		private UIButtonClick _uiCollectibleItemButtonClick;

		[Inject]
		private void Inject(HeroUpgradeAlertSystem heroUpgradeAlertSystem, HeroSystem heroSystem, InventorySystem inventorySystem, GameAnalyticsEvents gameAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartTutorial(Action onTutorialFinished)
		{
		}

		private void OpenItemStep()
		{
		}

		private void CollectiblePopupStep()
		{
		}

		private void CloseButtonStep()
		{
		}

		private void HomeNavigationButtonStep()
		{
		}

		private void PlayButtonStep()
		{
		}

		private void ClearAndCompleteStep()
		{
		}

		private void ValidateRequiredResources()
		{
		}

		private HeroItem GetHeroWithMinimumRequiredResource()
		{
			return null;
		}
	}
}
