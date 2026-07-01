using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRockPaperScissorsPanel : MonoBehaviour
	{
		[Header("Hands")]
		[SerializeField]
		private UIRPSHand _leftHand;

		[SerializeField]
		private UIRPSHand _rightHand;

		[Header("Choice Buttons")]
		[SerializeField]
		private UIButtonClick _rockButton;

		[SerializeField]
		private UIButtonClick _paperButton;

		[SerializeField]
		private UIButtonClick _scissorsButton;

		[Header("Info Display")]
		[SerializeField]
		private TMP_Text _remainsText;

		[SerializeField]
		private Image _remainsIcon;

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

		[Header("Controls")]
		[SerializeField]
		private UIButtonClick _closeButton;

		[Header("Controllers")]
		[SerializeField]
		private UIRPSEndFlowController _endFlowController;

		[SerializeField]
		private UIRPSSessionRewardsController _sessionRewardsController;

		[SerializeField]
		private UIRPSFloatingRewardController _floatingRewardController;

		[Header("Audio")]
		[SerializeField]
		private SoundData _winSfx;

		[SerializeField]
		private SoundData _drawSfx;

		[SerializeField]
		private SoundData _loseSfx;

		[SerializeField]
		private SoundData _cardRewardSfx;

		[Header("Sprite Overrides")]
		[SerializeField]
		private Sprite _coinRewardIconOverride;

		[Header("Settings")]
		[SerializeField]
		private float _resultRevealDelay;

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

		private GameplayConfig _gameplayConfig;

		private GameplayInventorySystem _gameplayInventorySystem;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private StageSystem _stageSystem;

		private WaveSystem _waveSystem;

		private InventoryItem _entryInventoryItem;

		private RPSGameResult _currentResult;

		private RPSOutcomeData _pendingFloatingReward;

		private readonly List<RPSOutcomeData> _sessionRewardLog;

		private Tween _resultTextPopTween;

		private Tween _rewardPopTween;

		private Tween _failPopTween;

		private Tween _resultRevealDelayTween;

		private Tween _delayTween;

		private bool _isEndFlowActive;

		private bool _isNextRoundPrepared;

		public UIButtonClick PaperButton => null;

		public IReadOnlyList<RPSOutcomeData> SessionRewardLog => null;

		[Inject]
		public void Inject(RockPaperScissorsSystem rpsSystem, GameplayConfig gameplayConfig, GameplayInventorySystem gameplayInventorySystem, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, WaveSystem waveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void PreparePanel()
		{
		}

		private void OnRockClicked()
		{
		}

		private void OnPaperClicked()
		{
		}

		private void OnScissorsClicked()
		{
		}

		private void PlayChoice(RPSChoice choice)
		{
		}

		private void CompletePendingRewardImmediately()
		{
		}

		private void ShowResult()
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

		private void OnCloseButtonClicked()
		{
		}

		private void OnEntryItemAmountChanged(InventoryItem item)
		{
		}

		private void StartEndSessionFlow()
		{
		}

		private void CheckAndStartEndSessionIfNeeded()
		{
		}

		private void PrepareForNextRound()
		{
		}

		private void ApplyAndUpdateReward(RPSOutcomeData outcome)
		{
		}

		private void TrackReward(RPSOutcomeData outcome)
		{
		}

		private void KillAllTweens()
		{
		}

		private void UpdateInfoDisplay()
		{
		}

		private void UpdateRemainsDisplay(int amount)
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

		private void PlayResultSfx(RPSResultType resultType)
		{
		}

		private RectTransform GetFloatingRewardTarget(RPSOutcomeData outcome)
		{
			return null;
		}

		private float GetRewardEndScale(RPSOutcomeType outcomeType)
		{
			return 0f;
		}

		private bool IsResourceReward(RPSOutcomeType outcomeType)
		{
			return false;
		}

		private Sprite GetRewardDisplayIcon(RPSOutcomeData outcome)
		{
			return null;
		}

		private void TrackDuelStep()
		{
		}

		private void SetChoiceButtonsInteractable(bool interactable)
		{
		}
	}
}
