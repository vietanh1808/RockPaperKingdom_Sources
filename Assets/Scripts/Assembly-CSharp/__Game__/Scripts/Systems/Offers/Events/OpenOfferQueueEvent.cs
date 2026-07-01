using System;
using __Game__.Scripts.Systems.Offers.UI;

namespace __Game__.Scripts.Systems.Offers.Events
{
	public class OpenOfferQueueEvent : IQueueEvent
	{
		private readonly UIBaseOfferPopup _popup;

		private readonly Offer _offer;

		private readonly OfferSystem _offerSystem;

		public EventPriority Priority => default(EventPriority);

		public OpenOfferQueueEvent(UIBaseOfferPopup popup, Offer offer, OfferSystem offerSystem)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
