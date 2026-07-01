using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class CurrencyPurchaseProvider : BasePurchaseProvider
	{
		private readonly InventorySystem _inventorySystem;

		private readonly PurchaseButtonConfig _purchaseButtonConfig;

		private InventoryItem _inventoryItem;

		private int _priceAmount;

		private bool _canPurchase;

		private bool _isCooldown;

		private bool _isAvailable;

		public CurrencyPurchaseProvider(PurchaseSystem purchaseSystem, InventorySystem inventorySystem, PurchaseButtonConfig purchaseButtonConfig)
			: base(null)
		{
		}

		public override void Initialize(PurchaseData purchaseData)
		{
		}

		public override void Purchase(Action<bool> onPurchaseCompleted)
		{
		}

		public override bool IsAvailable()
		{
			return false;
		}

		public override string GetButtonMessageText()
		{
			return null;
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

		private void OnAmountChanged(InventoryItem inventoryItem)
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
