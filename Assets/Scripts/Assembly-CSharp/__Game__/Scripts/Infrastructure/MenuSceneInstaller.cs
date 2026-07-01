using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.Offers.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class MenuSceneInstaller : MonoInstaller
	{
		[SerializeField]
		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[SerializeField]
		private MenuTutorialController _menuTutorialController;

		[SerializeField]
		private UIFeatureUnlockTargetRegistry _featureUnlockTargetRegistry;

		[SerializeField]
		private OfferPopupRegistry _offerPopupRegistry;

		[SerializeField]
		private UIInterstitialChoicePopup _interstitialChoicePopup;

		[Header("Data")]
		[SerializeField]
		private PurchaseAlertCollection _purchaseAlertCollection;

		public override void InstallBindings()
		{
		}
	}
}
