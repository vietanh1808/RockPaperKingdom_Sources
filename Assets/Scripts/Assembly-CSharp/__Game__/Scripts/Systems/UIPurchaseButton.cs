using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private Image _buttonIcon;

		[SerializeField]
		private TMP_Text _priceText;

		[Header("Cooldown")]
		[SerializeField]
		private GameObject _cooldownContainer;

		[SerializeField]
		private TMP_Text _cooldownText;

		[Header("Available Slots")]
		[SerializeField]
		private GameObject _availableCountContainer;

		[SerializeField]
		private TMP_Text _availableCountText;

		[Header("Optional")]
		[SerializeField]
		private RectTransform _sourceContainer;

		[SerializeField]
		private PurchaseData _purchaseData;

		[SerializeField]
		private GameObject _alertMark;

		[SerializeField]
		private UnityEvent _onPurchaseSuccessful;

		private PurchaseSystem _purchaseSystem;

		private UIRewardFloating _uiRewardFloating;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private BasePurchaseProvider _purchaseProvider;

		private bool _isSubscribed;

		private bool _hasMultipleSlots;

		public PurchaseData PurchaseData => null;

		public bool IsAvailable => false;

		[Inject]
		private void Inject(PurchaseSystem purchaseSystem, UIRewardFloating uiRewardFloating, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize(PurchaseData purchaseData)
		{
		}

		private void SubscribeListeners()
		{
		}

		private void UnsubscribeListeners()
		{
		}

		private void PurchaseButtonHandler()
		{
		}

		private void TrackMonetisationClick()
		{
		}

		private void SetupRewardSourceContainer()
		{
		}

		private void OnPurchaseCompleted(bool isSuccess)
		{
		}

		private void RefreshUI()
		{
		}

		private void RefreshStateUI(bool isAvailable)
		{
		}

		private void RefreshPrice()
		{
		}

		private void RefreshAlert()
		{
		}

		private void OnCooldownSlotChanged()
		{
		}

		private void OnSlotTimeChanged(TimeSpan time)
		{
		}

		private void RefreshCooldownDisplay()
		{
		}

		private void RefreshAvailableCount()
		{
		}

		private void UpdateCooldownText(TimeSpan time)
		{
		}
	}
}
