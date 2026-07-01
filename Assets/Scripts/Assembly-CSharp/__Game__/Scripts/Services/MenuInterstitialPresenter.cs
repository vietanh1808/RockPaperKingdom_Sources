using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.Offers;
using __Game__.Scripts.Systems.Offers.UI;

namespace __Game__.Scripts.Services
{
	public class MenuInterstitialPresenter
	{
		private const string PLACEMENT_NAME = "menu_interstitial";

		private readonly AdsConfig _adsConfig;

		private readonly IAdsService _adsService;

		private readonly InventorySystem _inventorySystem;

		private readonly PlayerInstallTracker _playerInstallTracker;

		private readonly InterstitialAdTracker _interstitialAdTracker;

		private readonly StageSystem _stageSystem;

		private readonly EventQueueSystem _eventQueueSystem;

		private readonly OfferSystem _offerSystem;

		private readonly OfferPopupRegistry _offerPopupRegistry;

		private readonly UIInterstitialChoicePopup _interstitialChoicePopup;

		public MenuInterstitialPresenter(AdsConfig adsConfig, IAdsService adsService, InventorySystem inventorySystem, PlayerInstallTracker playerInstallTracker, InterstitialAdTracker interstitialAdTracker, StageSystem stageSystem, EventQueueSystem eventQueueSystem, OfferSystem offerSystem, OfferPopupRegistry offerPopupRegistry, UIInterstitialChoicePopup interstitialChoicePopup)
		{
		}

		public void Initialize()
		{
		}

		private bool IsGatingPassed()
		{
			return false;
		}

		private bool HasNoAds()
		{
			return false;
		}
	}
}
