using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPvpArenaMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _arenaPage;

		[SerializeField]
		private RectTransform _arenaNavigationButtonContainer;

		[SerializeField]
		private UIButtonClick _arenaNavigationButtonClick;

		[Header("Step 2")]
		[SerializeField]
		private RectTransform _fightButtonContainer;

		[SerializeField]
		private UIButtonClick _fightButtonClick;

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

		private void FightButtonStep()
		{
		}

		private void CompleteTutorialStep()
		{
		}
	}
}
