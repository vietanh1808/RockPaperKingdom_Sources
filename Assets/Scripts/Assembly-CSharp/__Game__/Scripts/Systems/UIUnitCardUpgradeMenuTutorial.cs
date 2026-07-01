using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardUpgradeMenuTutorial : UIBaseMenuTutorial
	{
		[CompilerGenerated]
		private sealed class _003CSelectUnitCardStepDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIUnitCardUpgradeMenuTutorial _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSelectUnitCardStepDelayed_003Ed__22(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("Step 1 - Navigate to Hero Page")]
		[SerializeField]
		private RectTransform _targetPage;

		[SerializeField]
		private RectTransform _targetNavigationButtonContainer;

		[SerializeField]
		private UIHeroSlotView _uiHeroSlotView;

		[Header("Step 2 - Click Cards Tab")]
		[SerializeField]
		private Toggle _cardsTab;

		[Header("Step 3 - Select Unit Card")]
		[SerializeField]
		private UIGroupedUnitCardInventoryView _uiGroupedUnitCardInventoryView;

		[SerializeField]
		private RectTransform _deployedCardsContainer;

		[SerializeField]
		private ScrollRect _scrollRect;

		[Header("Step 4 - Click Upgrade Button")]
		[SerializeField]
		private UIUnitCardControlPopup _uiUnitCardControlPopup;

		[SerializeField]
		private RectTransform _collectibleUpgradeButtonContainer;

		[SerializeField]
		private UIButtonClick _collectibleUpgradeButtonClick;

		private UnitCardUpgradeAlertSystem _unitCardUpgradeAlertSystem;

		private UnitCardSystem _unitCardSystem;

		private InventorySystem _inventorySystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		private Coroutine _selectUnitCardCoroutine;

		[Inject]
		private void Inject(UnitCardUpgradeAlertSystem unitCardUpgradeAlertSystem, UnitCardSystem unitCardSystem, InventorySystem inventorySystem, GameAnalyticsEvents gameAnalyticsEvents)
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

		private void OnCardsTabValueChanged(bool isOn)
		{
		}

		private void CardsTabStep()
		{
		}

		private void SelectUnitCardStep()
		{
		}

		[IteratorStateMachine(typeof(_003CSelectUnitCardStepDelayed_003Ed__22))]
		private IEnumerator SelectUnitCardStepDelayed()
		{
			return null;
		}

		private UIUnitCardInventoryElement FindUpgradeableCardElement()
		{
			return null;
		}

		private void ScrollToElement(RectTransform targetElement)
		{
		}

		private void CollectiblePopupStep()
		{
		}

		private void ClearAndCompleteStep()
		{
		}

		private void OnPopupClosedCompleteTutorial()
		{
		}

		private void ValidateRequiredResources()
		{
		}

		private UnitCardItem GetUnitCardWithMinimumRequiredResource()
		{
			return null;
		}
	}
}
