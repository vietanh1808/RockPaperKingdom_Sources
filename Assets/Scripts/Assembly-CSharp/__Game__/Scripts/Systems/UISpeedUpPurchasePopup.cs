using System;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpeedUpPurchasePopup : UIBasePopup
	{
		[Header("Purchase")]
		[SerializeField]
		private RectTransform _purchaseContainer;

		[SerializeField]
		private UIButtonClick _adButtonClick;

		[SerializeField]
		private TMP_Text _adButtonText;

		[Header("Cooldown")]
		[SerializeField]
		private RectTransform _cooldownContainer;

		[SerializeField]
		private TMP_Text _cooldownText;

		[Header("Sounds")]
		[SerializeField]
		private SoundData _speedUpPurchaseSound;

		private SpeedUpPurchaseSystem _speedUpPurchaseSystem;

		private IAdsService _adsService;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		[Inject]
		private void Inject(SpeedUpPurchaseSystem speedUpPurchaseSystem, IAdsService adsService, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnAvailableStatusChanged()
		{
		}

		private void RefreshStatusView()
		{
		}

		private void OnCooldownTimeChanged(TimeSpan cooldownTime)
		{
		}

		private void OnRewardedStatusChanged()
		{
		}

		private void OnAdButtonClicked()
		{
		}
	}
}
