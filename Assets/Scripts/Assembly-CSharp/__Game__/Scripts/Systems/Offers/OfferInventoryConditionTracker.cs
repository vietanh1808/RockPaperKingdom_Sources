using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Systems.Offers
{
	public class OfferInventoryConditionTracker : IDisposable
	{
		private readonly OfferSystem _offerSystem;

		private readonly OffersConfig _offersConfig;

		private readonly InventorySystem _inventorySystem;

		private readonly Dictionary<InventoryItem, List<Offer>> _trackedOffers;

		public OfferInventoryConditionTracker(OfferSystem offerSystem, OffersConfig offersConfig, InventorySystem inventorySystem)
		{
		}

		public void Dispose()
		{
		}

		public void Initialize()
		{
		}

		private void HandleItemAmountChanged(InventoryItem item)
		{
		}
	}
}
