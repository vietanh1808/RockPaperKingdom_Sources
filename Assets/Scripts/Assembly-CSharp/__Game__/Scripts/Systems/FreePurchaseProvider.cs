using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class FreePurchaseProvider : BasePurchaseProvider
	{
		private readonly PurchaseButtonConfig _purchaseButtonConfig;

		private bool _isAvailable;

		public FreePurchaseProvider(PurchaseSystem purchaseSystem, PurchaseButtonConfig purchaseButtonConfig)
			: base(null)
		{
		}

		public override void Initialize(PurchaseData purchaseData)
		{
		}

		public override void Purchase(Action<bool> onPurchaseCompleted)
		{
		}

		public override string GetButtonMessageText()
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

		public override bool IsAvailable()
		{
			return false;
		}

		private void OnCooldownStatusChanged(bool isCooldown)
		{
		}
	}
}
