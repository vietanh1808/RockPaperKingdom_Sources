using System.Collections.Generic;
using System.Text;
using LionStudios.Suite.Analytics;
using LionStudios.Suite.Purchasing;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services.Analytics
{
	public class LionAnalyticsEvents
	{
		private const string MISSION_TYPE = "main";

		private const string HARD_MISSION_TYPE = "hard";

		private const string WAVE_MISSION_TYPE = "level";

		private const string WAVE_MISSION_TYPE_HARD = "level_hard";

		private const string FAIL_REASON = "hard_fail";

		public void TrackMonetisationImpression(string uiLocation)
		{
		}

		public void TrackMonetisationImpression(string uiLocation, string uiType)
		{
		}

		public void TrackInterstitialChoiceDisplayed()
		{
		}

		public void TrackInterstitialChoiceWatchAds()
		{
		}

		public void TrackInterstitialChoiceCheckOffer()
		{
		}

		public void TrackMonetisationClick(string uiLocation, string uiType)
		{
		}

		public void TrackMissionStarted(StageModeType mode, int stage, int attempt)
		{
		}

		public void TrackMissionCompleted(StageModeType mode, int stage, int attempt)
		{
		}

		public void TrackMissionFailed(StageModeType mode, int stage, int attempt, float missionProgress)
		{
		}

		public void TrackMissionAbandoned(StageModeType mode, int stage, int attempt, float missionProgress)
		{
		}

		public void TrackMissionStep(StageModeType mode, int stage, int attempt, string stepName)
		{
		}

		public void TrackWaveMissionStarted(StageModeType mode, int stage, int wave, int attempt)
		{
		}

		public void TrackWaveMissionCompleted(StageModeType mode, int stage, int wave, int attempt, float reachedScore, float castleHealth)
		{
		}

		public void TrackWaveMissionFailed(StageModeType mode, int stage, int wave, int attempt, float reachedScore, float castleHealth)
		{
		}

		public void TrackWaveMissionAbandoned(StageModeType mode, int stage, int wave, int attempt, float reachedScore, float castleHealth)
		{
		}

		public void TrackWaveMissionStep(StageModeType mode, int stage, int wave, int attempt, string stepName)
		{
		}

		public void TrackWaveMissionStep(StageModeType mode, int stage, int wave, int attempt, string stepName, Dictionary<string, object> additionalData)
		{
		}

		public void TrackInAppPurchase(IAPInfo iapInfo, IAPGameplayInfo iapGameplayInfo, StageModeType mode, int missionId, int missionAttempt)
		{
		}

		public void TrackEconomy(EconomyEventData eventData)
		{
		}

		public void TrackEconomy<T>(EconomyEventData eventData, List<T> received) where T : IInventoryItemHolder
		{
		}

		private static string GetStageMissionType(StageModeType mode)
		{
			return null;
		}

		private static string GetWaveMissionType(StageModeType mode)
		{
			return null;
		}

		private static string FormatMissionName(StageModeType mode, int stage)
		{
			return null;
		}

		private Dictionary<string, object> BuildGameplayData(float missionProgress)
		{
			return null;
		}

		private Dictionary<string, object> BuildGameplayResultData(float reachedScore, float castleHealth)
		{
			return null;
		}

		public Dictionary<string, object> BuildCardsData(string cardPicked, List<string> cardSuggested)
		{
			return null;
		}

		private Dictionary<string, object> BuildMissionData(string missionType, int missionId, int missionAttempt, string missionName)
		{
			return null;
		}

		private Product ToProduct<T>(List<T> items) where T : IInventoryItemHolder
		{
			return null;
		}

		private void AddToProduct(Product product, InventoryItemData itemData, int amount)
		{
		}

		private void LogEconomy<T>(EconomyEventData eventData, List<T> received) where T : IInventoryItemHolder
		{
		}

		private void AppendItemsLog<T>(StringBuilder sb, string label, List<T> items) where T : IInventoryItemHolder
		{
		}
	}
}
