using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPatrolRewardsMenuTutorial : UIBaseMenuTutorial
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
		private RectTransform _patrolRewardsButtonContainer;

		[SerializeField]
		private UIButtonClick _patrolRewardsButtonClick;

		[Header("Step 2")]
		[SerializeField]
		private UIPatrolRewardsPopup _patrolRewardsPopup;

		[SerializeField]
		private RectTransform _claimRewardsButtonContainer;

		[SerializeField]
		private UIButtonClick _claimRewardsButtonClick;

		[Header("Step 3")]
		[SerializeField]
		private Image _overlayBackground;

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

		private void PatrolButtonStep()
		{
		}

		private void ClaimRewardsStep()
		{
		}

		private void CompleteTutorialStep()
		{
		}
	}
}
