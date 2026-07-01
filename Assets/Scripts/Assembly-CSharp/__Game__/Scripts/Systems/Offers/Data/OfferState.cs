using System;

namespace __Game__.Scripts.Systems.Offers.Data
{
	[Serializable]
	public class OfferState
	{
		public DateTime LastShownTime;

		public int ShownCount;

		public bool HasBeenEligibleBefore;
	}
}
