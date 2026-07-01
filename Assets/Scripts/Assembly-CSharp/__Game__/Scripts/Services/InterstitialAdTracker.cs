namespace __Game__.Scripts.Services
{
	public class InterstitialAdTracker
	{
		private readonly AdsConfig _adsConfig;

		public int WinCount { get; private set; }

		public bool IsInterstitialChoiceShown { get; private set; }

		public int InterstitialDisplayCount { get; private set; }

		public InterstitialAdTracker(AdsConfig adsConfig)
		{
		}

		public void LoadData(int winCount, bool isInterstitialChoiceShown, int interstitialDisplayCount)
		{
		}

		public void MarkInterstitialChoiceShown()
		{
		}

		public void IncrementInterstitialDisplayCount()
		{
		}

		public bool IncrementAndCheckShouldShow()
		{
			return false;
		}
	}
}
