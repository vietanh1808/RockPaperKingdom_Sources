using System;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class RewardedVideoPurchaseProvider : BasePurchaseProvider
	{
		private readonly IAdsService _adsService;

		private readonly PurchaseButtonConfig _purchaseButtonConfig;

		private Action<bool> _onPurchaseCompleted;

		private bool _isRewardedAdsReady;

		private bool _isCooldown;

		private bool _isAvailable;

		public RewardedVideoPurchaseProvider(PurchaseSystem purchaseSystem, IAdsService adsService, PurchaseButtonConfig purchaseButtonConfig)
			: base(null)
		{
		}

		public override void Initialize(PurchaseData purchaseData)
		{
		}

		public override void Purchase(Action<bool> onPurchaseCompleted)
		{
		}

		public override Sprite GetPriceIcon()
		{
			return null;
		}

		public override Sprite GetButtonBackground()
		{
			return null;
		}

		public override string GetPriceText()
		{
			return null;
		}

		public override string GetButtonMessageText()
		{
			return null;
		}

		public override bool IsAvailable()
		{
			return false;
		}

		private void OnRewardedAdCompleted(bool isSuccess)
		{
		}

		private void OnRewardedStatusChanged()
		{
		}

		private void OnCooldownStatusChanged(bool isCooldown)
		{
		}

		private void CheckAvailableStatus()
		{
		}

		private bool GetAvailableStatus()
		{
			return false;
		}
	}
}
