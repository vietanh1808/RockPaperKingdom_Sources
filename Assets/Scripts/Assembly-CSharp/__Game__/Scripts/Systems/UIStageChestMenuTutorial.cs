using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class UIStageChestMenuTutorial : UIBaseMenuTutorial
	{
		[SerializeField]
		private UIStageChestRewardButton _stageChestRewardButton;

		[SerializeField]
		private UIStageInfoPanel _stageInfoPanel;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		[Inject]
		private void Inject(GameAnalyticsEvents gameAnalyticsEvents)
		{
		}

		public override void StartTutorial(Action onTutorialFinished)
		{
		}

		private void OnPanelElementsCreated()
		{
		}

		private void OnChestClicked(StageChestItem chestItem)
		{
		}
	}
}
