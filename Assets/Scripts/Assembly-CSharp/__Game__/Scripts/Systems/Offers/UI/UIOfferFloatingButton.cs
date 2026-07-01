using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems.Offers.Data;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems.Offers.UI
{
	public class UIOfferFloatingButton : MonoBehaviour
	{
		private const string FLOATING_BUTTON_PREFIX = "floating_button_";

		private const string LOCATION = "main_menu";

		[SerializeField]
		private OfferData _offerData;

		[SerializeField]
		private UIButtonClick _button;

		private OfferSystem _offerSystem;

		private OfferPopupRegistry _offerPopupRegistry;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Offer _offer;

		private string _formattedUiType;

		[Inject]
		public void Construct(OfferSystem offerSystem, OfferPopupRegistry offerPopupRegistry, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleStatusChanged(Offer offer)
		{
		}

		private void HandleClick()
		{
		}
	}
}
