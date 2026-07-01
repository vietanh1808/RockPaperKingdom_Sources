using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _equipmentNavigationButtonContainer;

		[Header("Step 2")]
		[SerializeField]
		private UIEquipmentInventoryView _uiEquipmentInventoryView;

		[SerializeField]
		private RectTransform _elementParentContainer;

		[Header("Step 3")]
		[SerializeField]
		private RectTransform _equipButtonContainer;

		[SerializeField]
		private UIButtonClick _equipButtonClick;

		private RectTransform _elementContainer;

		private UIButtonClick _elementButton;

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

		private void EquipmentElementStep()
		{
		}

		private void EquipButtonStep()
		{
		}

		private void ClearAndCompleteStep()
		{
		}
	}
}
