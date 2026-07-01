using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Systems.Offers.UI
{
	public class OfferPopupRegistry : MonoBehaviour
	{
		[SerializeField]
		private List<UIBaseOfferPopup> _popups;

		private readonly Dictionary<OfferData, UIBaseOfferPopup> _popupByOffer;

		private void Awake()
		{
		}

		public bool TryGetPopup(OfferData offerData, out UIBaseOfferPopup popup)
		{
			popup = null;
			return false;
		}
	}
}
