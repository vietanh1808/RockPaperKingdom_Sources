using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIFortuneWheelPopup : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _startButton;

		[SerializeField]
		private UIButtonClick _continueButton;

		[SerializeField]
		private AnimationCurve _animationDelayCurve;

		[SerializeField]
		private UIFortuneWheelResultView _uiFortuneWheelResultView;

		[SerializeField]
		private UINormalFortuneWheelAnimation _uiNormalFortuneWheelAnimation;

		[SerializeField]
		private UIMaxFortuneWheelAnimation _uiMaxFortuneWheelAnimation;

		[SerializeField]
		private List<UIFortuneWheelElement> _uiElements;

		private FortuneWheelSystem _fortuneWheelSystem;

		private UIBaseFortuneWheelAnimation _uiBaseFortuneWheelAnimation;

		public event Action OnRewardReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(FortuneWheelSystem fortuneWheelSystem)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void RefreshAllItems()
		{
		}

		private void RefreshAllElements()
		{
		}

		private void RefreshControls()
		{
		}

		private void OnStartButtonClicked()
		{
		}

		private void OnRotationCompleted()
		{
		}

		public void Continue()
		{
		}
	}
}
