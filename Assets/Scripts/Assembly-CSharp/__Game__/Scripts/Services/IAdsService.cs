using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services
{
	public interface IAdsService
	{
		event Action OnRewardedStatusChanged;

		event Action BeforeRewardedAdStarted;

		event Action OnRewardedAdFinished;

		void Initialize();

		bool IsRewardedAdsReady();

		void ShowRewardedAds(string placementName, Action<bool> onVideoRewarded);

		void ShowRewardedAds(string placementName, List<Reward> rewards, Action<bool> onVideoRewarded);

		bool IsInterstitialReady();

		void ShowInterstitial(string placementName, Action onClosed);
	}
}
