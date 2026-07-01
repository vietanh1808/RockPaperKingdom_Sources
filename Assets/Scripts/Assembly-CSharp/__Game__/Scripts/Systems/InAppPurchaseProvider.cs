using System;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class InAppPurchaseProvider : BasePurchaseProvider
	{
		private readonly InAppPurchaseService _inAppPurchaseService;

		private readonly PurchaseButtonConfig _purchaseButtonConfig;

		private bool _isInAppInitialized;

		private bool _isCooldown;

		private bool _isAvailable;

		private Action<bool> _onPurchaseCompleted;

		public InAppPurchaseProvider(PurchaseSystem purchaseSystem, InAppPurchaseService inAppPurchaseService, PurchaseButtonConfig purchaseButtonConfig)
			: base(null)
		{
		}

		public override void Initialize(PurchaseData purchaseData)
		{
		}

		public override void Purchase(Action<bool> onPurchaseCompleted)
		{
		}

		public override Sprite GetButtonBackground()
		{
			return null;
		}

		public override string GetButtonMessageText()
		{
			return null;
		}

		public override string GetPriceText()
		{
			return null;
		}

		public override bool IsAvailable()
		{
			return false;
		}

		private void OnPurchaseCompleted(bool isSuccess)
		{
		}

		private void OnIAPServiceStatusChanged()
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
