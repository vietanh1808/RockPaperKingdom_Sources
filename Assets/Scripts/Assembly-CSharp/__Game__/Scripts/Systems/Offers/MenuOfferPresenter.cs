using __Game__.Scripts.Systems.Offers.Data;
using __Game__.Scripts.Systems.Offers.UI;

namespace __Game__.Scripts.Systems.Offers
{
	public class MenuOfferPresenter
	{
		private readonly OfferSystem _offerSystem;

		private readonly OffersConfig _offersConfig;

		private readonly OfferPopupRegistry _offerPopupRegistry;

		private readonly EventQueueSystem _eventQueueSystem;

		private readonly PurchaseSystem _purchaseSystem;

		private readonly OfferInventoryConditionTracker _offerInventoryConditionTracker;

		public MenuOfferPresenter(OfferSystem offerSystem, OffersConfig offersConfig, OfferPopupRegistry offerPopupRegistry, EventQueueSystem eventQueueSystem, PurchaseSystem purchaseSystem, OfferInventoryConditionTracker offerInventoryConditionTracker)
		{
		}

		public void Initialize()
		{
		}

		private void UpdateAllOfferStatuses()
		{
		}
	}
}
