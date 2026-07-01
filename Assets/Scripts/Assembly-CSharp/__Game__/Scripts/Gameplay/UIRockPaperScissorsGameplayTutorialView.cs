using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIRockPaperScissorsGameplayTutorialView : UIBaseGameplayTutorialView
	{
		[CompilerGenerated]
		private sealed class _003CSetupAmountElementSorting_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIRockPaperScissorsGameplayTutorialView _003C_003E4__this;

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
			public _003CSetupAmountElementSorting_003Ed__23(int _003C_003E1__state)
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

		private const string STEP_1_LABEL = "Part 1/2";

		private const string STEP_2_LABEL = "Part 2/2";

		private const float OVERLAY_SHOW_DELAY = 1f;

		[SerializeField]
		private Image _transparentBlocker;

		[SerializeField]
		private GameObject _tutorialOverlay;

		[SerializeField]
		private GameObject _step1Container;

		[SerializeField]
		private GameObject _step2Container;

		[SerializeField]
		private UIButtonClick _continueButton;

		[SerializeField]
		private TMP_Text _stepLabel;

		[SerializeField]
		private GameObject _currencyHint;

		[SerializeField]
		private UIGameplayInventoryAmountElement _currencyAmountElement;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private UITutorialTap _uiTutorialTap;

		private UIRockPaperScissorsButton _rpsButton;

		private Tween _showDelayTween;

		private Color _originalAmountTextColor;

		private Canvas _amountElementCanvas;

		private GraphicRaycaster _amountElementRaycaster;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, UIProjectHolder uiProjectHolder)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ShowCurrencyHint()
		{
		}

		private void HideCurrencyHint()
		{
		}

		[IteratorStateMachine(typeof(_003CSetupAmountElementSorting_003Ed__23))]
		private IEnumerator SetupAmountElementSorting()
		{
			return null;
		}

		private void ClearAmountElementSorting()
		{
		}

		private void OnRpsButtonClicked()
		{
		}

		private void OnOverlayDelayComplete()
		{
		}

		private void OnStep1ContinueClicked()
		{
		}

		private void ShowStep2()
		{
		}

		private void OnStep2ContinueClicked()
		{
		}

		private void SetBlockerAlpha(float alpha)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
