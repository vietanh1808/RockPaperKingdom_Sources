using UnityEngine;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "Config_Ads", menuName = "TapHub/Configs/Ads Config")]
	public class AdsConfig : ScriptableObject
	{
		[Header("No Ads")]
		[SerializeField]
		private InventoryItemData _noAdsItemData;

		[Header("Interstitial Gating")]
		[SerializeField]
		private int _interstitialMinDaysSinceInstall;

		[SerializeField]
		private int _interstitialMinStageIndex;

		[Header("Interstitial Frequency")]
		[SerializeField]
		private int _interstitialWinsPerShow;

		[Header("Interstitial Choice")]
		[SerializeField]
		private OfferData _interstitialChoiceOfferData;

		public InventoryItemData NoAdsItemData => null;

		public int InterstitialMinDaysSinceInstall => 0;

		public int InterstitialMinStageIndex => 0;

		public int InterstitialWinsPerShow => 0;

		public OfferData InterstitialChoiceOfferData => null;
	}
}
