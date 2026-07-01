using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Revive.UI
{
	public class UIRevivePopup : MonoBehaviour
	{
		private const float TIMER_DURATION = 6f;

		private const string TIMER_TEXT_FORMAT = "Time Left: <color=#AB3838>{0:F1}s</color>";

		[SerializeField]
		private UIRewardedVideoButton _rewardedVideoButton;

		[SerializeField]
		private UIButtonClick _continueButton;

		[SerializeField]
		private Image _timerFillImage;

		[SerializeField]
		private TMP_Text _timerText;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Action _onRevive;

		private Action _onDecline;

		private float _timer;

		private bool _isActive;

		[Inject]
		private void Inject(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Open(Action onRevive, Action onDecline)
		{
		}

		private void HandleRewardedVideoCompleted(bool isSuccess)
		{
		}

		private void HandleContinueClicked()
		{
		}

		private void Decline()
		{
		}
	}
}
