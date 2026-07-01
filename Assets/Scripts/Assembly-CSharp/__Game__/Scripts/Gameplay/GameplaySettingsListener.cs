using System;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class GameplaySettingsListener : IDisposable
	{
		private readonly ApplicationLifecycleService _applicationLifecycleService;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly GameplayStateMachine _gameplayStateMachine;

		private readonly IAdsService _adsService;

		private bool _isAdDisplaying;

		public GameplaySettingsListener(ApplicationLifecycleService applicationLifecycleService, UIGameplaySceneNavigation uiGameplaySceneNavigation, GameplayStateMachine gameplayStateMachine, IAdsService adsService)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnFocusStatusChanged(bool status)
		{
		}

		private void BeforeRewardedAdStarted()
		{
		}

		private void OnRewardedAdFinished()
		{
		}
	}
}
