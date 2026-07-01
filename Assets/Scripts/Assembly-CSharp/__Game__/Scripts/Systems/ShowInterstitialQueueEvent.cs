using System;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class ShowInterstitialQueueEvent : IQueueEvent
	{
		private readonly IAdsService _adsService;

		private readonly InterstitialAdTracker _interstitialAdTracker;

		private readonly string _placementName;

		public EventPriority Priority => default(EventPriority);

		public ShowInterstitialQueueEvent(IAdsService adsService, InterstitialAdTracker interstitialAdTracker, string placementName)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
