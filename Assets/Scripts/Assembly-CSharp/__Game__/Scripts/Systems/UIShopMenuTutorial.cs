using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIShopMenuTutorial : UIBaseMenuTutorial
	{
		[SerializeField]
		private ChestData _chestData;

		[Header("Step 1")]
		[SerializeField]
		private RectTransform _shopNavigationButtonContainer;

		[SerializeField]
		private UIButtonClick _shopNavigationButtonClick;

		[Header("Step 2")]
		[SerializeField]
		private UIShopPage _uiShopPage;

		[SerializeField]
		private RectTransform _chestIconContainer;

		[SerializeField]
		private RectTransform _chestDrawButtonContainer;

		[SerializeField]
		private UIButtonClick _chestDrawButtonClick;

		[SerializeField]
		private ScrollRect _shopScroll;

		[Header("Step 3")]
		[SerializeField]
		private Image _imageBackground;

		[SerializeField]
		private UIRewardChest _uiRewardChest;

		private InventorySystem _inventorySystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		private Canvas _chestIconCanvas;

		private GraphicRaycaster _chestIconRaycaster;

		[Inject]
		private void Inject(InventorySystem inventorySystem, GameAnalyticsEvents gameAnalyticsEvents)
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

		private void ChestButtonStep()
		{
		}

		private void DrawButtonStep()
		{
		}

		private void OnChestPopupClosed()
		{
		}

		private void CompleteTutorialStep()
		{
		}

		private void ValidateRequiredResources()
		{
		}

		private void HighlightChestIcon()
		{
		}

		private void ClearChestIconHighlight()
		{
		}
	}
}
