using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LionStudios.Suite.Analytics;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services
{
	public class LionAdsService : IAdsService
	{
		private const string MISSION_TYPE = "main";

		private readonly GameAnalyticsEvents _gameAnalyticsEvents;

		private readonly StageSystem _stageSystem;

		private readonly GameStateMachine _gameStateMachine;

		private Action<bool> _onVideoRewarded;

		public event Action OnRewardedStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action BeforeRewardedAdStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnRewardedAdFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public LionAdsService(GameAnalyticsEvents gameAnalyticsEvents, StageSystem stageSystem, GameStateMachine gameStateMachine)
		{
		}

		public void Initialize()
		{
		}

		public bool IsRewardedAdsReady()
		{
			return false;
		}

		public bool IsInterstitialReady()
		{
			return false;
		}

		public void ShowInterstitial(string placementName, Action onClosed)
		{
		}

		public void ShowRewardedAds(string placementName, Action<bool> onVideoRewarded)
		{
		}

		public void ShowRewardedAds(string placementName, List<__Game__.Scripts.Systems.Reward> rewards, Action<bool> onVideoRewarded)
		{
		}

		private void HandleRewardedStatusChanged(bool isReady)
		{
		}

		private void HandleRewarded()
		{
		}

		private void HandleClosed()
		{
		}

		private LionStudios.Suite.Analytics.Reward BuildSdkReward(List<__Game__.Scripts.Systems.Reward> rewards)
		{
			return null;
		}

		private Dictionary<string, object> BuildAdditionalData()
		{
			return null;
		}
	}
}
