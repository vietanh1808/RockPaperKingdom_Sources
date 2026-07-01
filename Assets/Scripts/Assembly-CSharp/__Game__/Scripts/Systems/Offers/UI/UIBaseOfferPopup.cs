using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems.Offers.Data;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems.Offers.UI
{
	public abstract class UIBaseOfferPopup : UIBasePopup
	{
		[Header("Data")]
		[SerializeField]
		private OfferData _offerData;

		[Header("Buttons")]
		[SerializeField]
		private UIPurchaseButton _purchaseButton;

		[SerializeField]
		private UIButtonClick _alternativeCloseButton;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Offer _offer;

		public OfferData OfferData => null;

		protected UIPurchaseButton PurchaseButton => null;

		[Inject]
		private void Inject(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Setup(Offer offer)
		{
		}

		protected virtual void OnSetup(Offer offer)
		{
		}

		private void HandleStatusChanged(Offer offer)
		{
		}
	}
}
