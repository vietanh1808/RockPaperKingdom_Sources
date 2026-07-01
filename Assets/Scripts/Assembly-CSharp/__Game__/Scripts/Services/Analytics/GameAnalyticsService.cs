using System;
using System.Runtime.CompilerServices;
using GameAnalyticsSDK;

namespace __Game__.Scripts.Services.Analytics
{
	public class GameAnalyticsService : IGameAnalyticsATTListener
	{
		public event Action OnInitialized
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

		public GameAnalyticsService(ApplicationLifecycleService applicationLifecycleService)
		{
		}

		private void OnGameAnalyticsInitialize(object sender, bool b)
		{
		}

		private void Initialize()
		{
		}

		private void OnInitializedCallback(object sender, bool e)
		{
		}

		public void GameAnalyticsATTListenerNotDetermined()
		{
		}

		public void GameAnalyticsATTListenerRestricted()
		{
		}

		public void GameAnalyticsATTListenerDenied()
		{
		}

		public void GameAnalyticsATTListenerAuthorized()
		{
		}
	}
}
