using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSRoundResultController : MonoBehaviour
	{
		[Header("Result Display")]
		[SerializeField]
		private RectTransform _resultTextContainer;

		[SerializeField]
		private TMP_Text _resultText;

		[SerializeField]
		private RectTransform _rewardContainer;

		[SerializeField]
		private Image _rewardIcon;

		[SerializeField]
		private TMP_Text _rewardAmountText;

		[SerializeField]
		private RectTransform _failContainer;

		[Header("Controllers")]
		[SerializeField]
		private UIRPSFloatingRewardController _floatingRewardController;

		[Header("Settings")]
		[SerializeField]
		private float _popAnimationDuration;

		[SerializeField]
		private float _resultDisplayDuration;

		[SerializeField]
		private string _winText;

		[SerializeField]
		private string _drawText;

		[SerializeField]
		private string _loseText;

		private RockPaperScissorsSystem _rpsSystem;

		private UIRPSSessionRewardsController _sessionRewardsController;

		private RectTransform _currencyTargetTransform;

		private RPSGameResult _currentResult;

		private RPSOutcomeData _pendingFloatingReward;

		private Action _onReadyForNextRound;

		private Action _onRoundFullyComplete;

		private Tween _resultTextPopTween;

		private Tween _rewardPopTween;

		private Tween _failPopTween;

		private Tween _delayTween;

		public void Initialize(RockPaperScissorsSystem rpsSystem, UIRPSSessionRewardsController sessionRewardsController, RectTransform currencyTargetTransform)
		{
		}

		public void ShowResult(RPSGameResult result, Action onReadyForNextRound, Action onRoundFullyComplete)
		{
		}

		public void CompletePendingImmediately()
		{
		}

		public void KillAllTweens()
		{
		}

		public void Reset()
		{
		}

		private void ShowRewardDisplay()
		{
		}

		private void ShowFailDisplay()
		{
		}

		private void OnResultDisplayFinished()
		{
		}

		private void PlayFloatingRewardAnimation(RPSOutcomeData outcome)
		{
		}

		private void OnFloatingRewardComplete(RPSOutcomeData outcome)
		{
		}

		private void NotifyRoundComplete()
		{
		}

		private string GetResultText()
		{
			return null;
		}

		private bool HasReward()
		{
			return false;
		}

		private Tween PlayPopAnimation(RectTransform container, Tween existingTween)
		{
			return null;
		}

		private RectTransform GetFloatingRewardTarget(RPSOutcomeData outcome)
		{
			return null;
		}

		private bool IsResourceReward(RPSOutcomeType outcomeType)
		{
			return false;
		}

		private float GetRewardEndScale(RPSOutcomeType outcomeType)
		{
			return 0f;
		}

		private void ApplyAndUpdateReward(RPSOutcomeData outcome)
		{
		}
	}
}
