namespace __Game__.Scripts.Services.Analytics
{
	public class GameAnalyticsEvents
	{
		public void TrackProgressionStart(int stage, int attempt)
		{
		}

		public void TrackProgressionComplete(int stage, int attempt, int castleHealthPercent)
		{
		}

		public void TrackProgressionFail(int stage, int attempt)
		{
		}

		public void TrackWaveProgressionStart(int stage, int wave)
		{
		}

		public void TrackWaveProgressionComplete(int stage, int wave, int healthPercent)
		{
		}

		public void TrackWaveProgressionFail(int stage, int wave, int healthPercent)
		{
		}

		public void TrackHeroUpgrade(string heroName, int level)
		{
		}

		public void TrackUnitCardUpgrade(string cardName, int level)
		{
		}

		public void TrackRewardedAdDisplay(string placementName)
		{
		}

		public void TrackMetaQuestCompleted(int questIndex, string questGuid)
		{
		}

		public void TrackTutorialStep(string tutorialName, int stepIndex, string stepAction)
		{
		}

		public void TrackCardSelected(int stage, int wave, string cardName)
		{
		}

		public void TrackArenaCardSelected(int tierIndex, int wave, string cardName)
		{
		}

		public void TrackArenaProgressionStart(int attempt, int tierIndex)
		{
		}

		public void TrackArenaProgressionComplete(int attempt, int tierIndex, int rating)
		{
		}

		public void TrackArenaProgressionFail(int attempt, int tierIndex, int rating)
		{
		}

		public void TrackAppReviewSubmitted(int stars)
		{
		}
	}
}
