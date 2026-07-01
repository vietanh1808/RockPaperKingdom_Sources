using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroSelectMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _targetPage;

		[SerializeField]
		private RectTransform _targetNavigationButtonContainer;

		[Header("Step 2")]
		[SerializeField]
		private UIHeroInventoryView _uiHeroInventoryView;

		[SerializeField]
		private RectTransform _collectibleRootContainer;

		[Header("Step 3")]
		[SerializeField]
		private RectTransform _collectibleSelectButtonContainer;

		[SerializeField]
		private UIButtonClick _collectibleSelectButtonClick;

		[Header("Step 4")]
		[SerializeField]
		private RectTransform _uiHeroSlotButtonContainer;

		[SerializeField]
		private UIButtonClick _uiHeroSlotButtonClick;

		private RectTransform _uiCollectibleItemContainer;

		private UIButtonClick _uiCollectibleItemButtonClick;

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

		private void OpenItemStep()
		{
		}

		private void CollectiblePopupStep()
		{
		}

		private void SelectItemStep()
		{
		}

		private void FinishTutorial()
		{
		}
	}
}
