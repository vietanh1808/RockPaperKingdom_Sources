using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems.Offers;
using __Game__.Scripts.Systems.Offers.Data;
using __Game__.Scripts.Systems.Offers.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIShopOfferSlot : UIBaseShopSlot
	{
		[SerializeField]
		private UIButtonClick _button;

		[SerializeField]
		private OfferData _offerData;

		private OfferSystem _offerSystem;

		private OfferPopupRegistry _offerPopupRegistry;

		private Offer _offer;

		[Inject]
		public void Construct(OfferSystem offerSystem, OfferPopupRegistry offerPopupRegistry)
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

		private void SetupVisuals()
		{
		}

		private void HandleClick()
		{
		}
	}
}
