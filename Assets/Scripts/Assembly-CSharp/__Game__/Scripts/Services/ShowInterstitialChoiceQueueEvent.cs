using System;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.Offers;
using __Game__.Scripts.Systems.Offers.Data;
using __Game__.Scripts.Systems.Offers.UI;

namespace __Game__.Scripts.Services
{
	public class ShowInterstitialChoiceQueueEvent : IQueueEvent
	{
		private readonly UIInterstitialChoicePopup _choicePopup;

		private readonly IAdsService _adsService;

		private readonly InterstitialAdTracker _interstitialAdTracker;

		private readonly OfferSystem _offerSystem;

		private readonly OfferPopupRegistry _offerPopupRegistry;

		private readonly OfferData _offerData;

		private readonly string _placementName;

		private Action _onComplete;

		public EventPriority Priority => default(EventPriority);

		public ShowInterstitialChoiceQueueEvent(UIInterstitialChoicePopup choicePopup, IAdsService adsService, InterstitialAdTracker interstitialAdTracker, OfferSystem offerSystem, OfferPopupRegistry offerPopupRegistry, OfferData offerData, string placementName)
		{
		}

		public void Execute(Action onComplete)
		{
		}

		private void HandleChoice(bool wantsOffer)
		{
		}

		private bool TryOpenOffer()
		{
			return false;
		}

		private void HandleOfferClosed(Offer offer)
		{
		}

		private void ShowInterstitial()
		{
		}
	}
}
