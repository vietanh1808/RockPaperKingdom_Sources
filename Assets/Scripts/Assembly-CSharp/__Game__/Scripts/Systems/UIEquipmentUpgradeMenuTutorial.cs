using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentUpgradeMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _equipmentPage;

		[SerializeField]
		private RectTransform _equipmentNavigationButtonContainer;

		[SerializeField]
		private UIButtonClick _equipmentNavigationButtonClick;

		[Header("Step 2")]
		[SerializeField]
		private UIEquipmentSlotView _uiEquipmentSlotView;

		[SerializeField]
		private List<UIEquipmentSlot> _uiEquipmentSlots;

		[Header("Step 3")]
		[SerializeField]
		private RectTransform _equipmentUpgradeButtonContainer;

		[SerializeField]
		private UIButtonClick _equipmentUpgradeButtonClick;

		[Header("Step 4")]
		[SerializeField]
		private RectTransform _closeButtonContainer;

		[SerializeField]
		private UIButtonClick _closeButtonClick;

		private RectTransform _equipmentSlotContainer;

		private UIButtonClick _equipmentSlotButtonClick;

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

		private void EquipmentSlotStep()
		{
		}

		private void EquipmentInfoControlsStep()
		{
		}

		private void CloseButtonStep()
		{
		}

		private void ClearAndCompleteStep()
		{
		}
	}
}
