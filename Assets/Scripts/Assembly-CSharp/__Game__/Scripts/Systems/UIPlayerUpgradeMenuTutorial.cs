using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerUpgradeMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _upgradeNavigationButtonContainer;

		[Header("Step 2")]
		[SerializeField]
		private UIPlayerUpgradesPanel _uiPlayerUpgradesPanel;

		[SerializeField]
		private ScrollRect _playerUpgradeScrollRect;

		[SerializeField]
		private RectTransform _elementParentContainer;

		[Header("Step 3")]
		[SerializeField]
		private UICloseOnOutsideClick _messageUpgradeOutsideClick;

		[SerializeField]
		private RectTransform _messageUpgradeContainer;

		[SerializeField]
		private UIButtonClick _purchaseUpgradeButtonClick;

		private RectTransform _elementContainer;

		private UIButtonClick _elementButton;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		private InventorySystem _inventorySystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		[Inject]
		private void Inject(PlayerUpgradesSystem playerUpgradesSystem, InventorySystem inventorySystem, GameAnalyticsEvents gameAnalyticsEvents)
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

		private void UpgradeElementStep()
		{
		}

		private void PurchaseUpgradeStep()
		{
		}

		private void ClearAndCompleteStep()
		{
		}

		private void ValidateRequiredResources()
		{
		}
	}
}
