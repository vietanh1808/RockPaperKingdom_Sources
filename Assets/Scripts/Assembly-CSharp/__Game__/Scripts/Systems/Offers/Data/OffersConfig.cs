using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.Offers.Data
{
	[CreateAssetMenu(fileName = "OffersConfig", menuName = "TapHub/Offers/Offers Config")]
	public class OffersConfig : ScriptableObject
	{
		[SerializeField]
		private string _folderPath;

		[SerializeField]
		private List<OfferData> _items;

		public List<OfferData> Items => null;
	}
}
