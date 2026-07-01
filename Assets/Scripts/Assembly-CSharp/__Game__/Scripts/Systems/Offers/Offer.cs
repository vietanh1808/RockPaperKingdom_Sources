using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Systems.Offers
{
	public class Offer
	{
		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		public OfferData Data { get; }

		public OfferState State { get; }

		public bool IsActive { get; private set; }

		public bool IsPurchased => false;

		public event Action<Offer> OnShown
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

		public event Action<Offer> OnStatusChanged
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

		public Offer(OfferData data, OfferState state, PurchaseCountsTracker purchaseCountsTracker)
		{
		}

		public void MarkShown()
		{
		}

		public void UpdateStatus(bool isActive)
		{
		}
	}
}
