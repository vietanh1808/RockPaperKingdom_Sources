using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIDailyRewardsMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step Home")]
		[SerializeField]
		private RectTransform _homePage;

		[SerializeField]
		private RectTransform _homeNavigationButtonContainer;

		[SerializeField]
		private UIButtonClick _homeNavigationButtonClick;

		[Header("Step 1")]
		[SerializeField]
		private RectTransform _dailyRewardsButtonContainer;

		[SerializeField]
		private UIButtonClick _dailyRewardsButtonClick;

		[Header("Step 2")]
		[SerializeField]
		private UIDailyRewardsPopup _uiDailyRewardsPopup;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		[Inject]
		private void Inject(GameAnalyticsEvents gameAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartTutorial(Action onTutorialFinished)
		{
		}

		private void DailyRewardsButtonStep()
		{
		}

		private void OnDailyRewardsButtonClicked()
		{
		}

		private void OnPopupOpened()
		{
		}
	}
}
