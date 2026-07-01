using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSEndFlowController : MonoBehaviour
	{
		[Header("Containers to Hide")]
		[SerializeField]
		private RectTransform _choiceButtonsContainer;

		[SerializeField]
		private RectTransform _handsContainer;

		[SerializeField]
		private RectTransform _remainsContainer;

		[Header("Session Rewards")]
		[SerializeField]
		private RectTransform _sessionRewardsContainer;

		[SerializeField]
		private Vector2 _rewardsCenterPosition;

		[Header("End Flow Buttons")]
		[SerializeField]
		private UIButtonClick _continueButton;

		[SerializeField]
		private UIRewardedVideoButton _doubleRewardButton;

		[Header("Confetti")]
		[SerializeField]
		private GameObject _confetti;

		[Header("Audio")]
		[SerializeField]
		private SoundData _rewardResultSound;

		[Header("Settings")]
		[SerializeField]
		private float _endFlowDelay;

		[SerializeField]
		private float _animationDuration;

		private RockPaperScissorsSystem _rpsSystem;

		private GridExpandSystem _gridExpandSystem;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private UIRockPaperScissorsPanel _panel;

		private UIRPSSessionRewardsController _sessionRewardsController;

		private UIButtonClick _closeButton;

		private Tween _delayTween;

		private Tween _hideChoicesTween;

		private Tween _hideHandsTween;

		private Tween _hideRemainsTween;

		private Tween _moveRewardsTween;

		private Vector2 _sessionRewardsOriginalPosition;

		private bool _hasGameplayCardReward;

		private bool _hasMapExpandReward;

		[Inject]
		public void Inject(RockPaperScissorsSystem rpsSystem, GridExpandSystem gridExpandSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void Initialize(UIRockPaperScissorsPanel panel, UIButtonClick closeButton, UIRPSSessionRewardsController sessionRewardsController)
		{
		}

		public void Cleanup()
		{
		}

		public void MarkRewardWon(RPSOutcomeType outcomeType)
		{
		}

		public void StartEndFlow()
		{
		}

		public void Reset()
		{
		}

		public void KillAllTweens()
		{
		}

		private void HideContainers()
		{
		}

		private void AnimateRewardsToCenter()
		{
		}

		private bool HasAnyReward()
		{
			return false;
		}

		private void ShowEndFlowButtons()
		{
		}

		private void ResetPositions()
		{
		}

		private void HandleContinueClicked()
		{
		}

		private void HandleDoubleRewardCompleted(bool isSuccess)
		{
		}
	}
}
