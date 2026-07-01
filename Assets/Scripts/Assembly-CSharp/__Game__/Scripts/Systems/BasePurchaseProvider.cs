using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class BasePurchaseProvider
	{
		private readonly PurchaseSystem _purchaseSystem;

		public PurchaseData PurchaseData { get; private set; }

		public CooldownListener[] CooldownSlots { get; private set; }

		public int AvailableSlotsCount => 0;

		public bool AllSlotsOnCooldown => false;

		public TimeSpan MinCooldownTime => default(TimeSpan);

		public event Action<bool> OnStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnPriceChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCooldownSlotChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BasePurchaseProvider(PurchaseSystem purchaseSystem)
		{
		}

		public abstract void Purchase(Action<bool> onPurchaseCompleted);

		public abstract bool IsAvailable();

		public abstract string GetButtonMessageText();

		public abstract string GetPriceText();

		public abstract Sprite GetButtonBackground();

		public virtual void Initialize(PurchaseData purchaseData)
		{
		}

		public virtual Sprite GetPriceIcon()
		{
			return null;
		}

		public int GetNextAvailableSlotIndex()
		{
			return 0;
		}

		protected void CompletePurchase()
		{
		}

		protected void InvokeStatusChanged(bool status)
		{
		}

		protected void InvokePriceChanged()
		{
		}

		protected void InvokeCooldownSlotChanged()
		{
		}
	}
}
