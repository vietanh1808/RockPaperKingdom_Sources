using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaEndPanel : MonoBehaviour
	{
		[Header("Header")]
		[SerializeField]
		private RectTransform _headerContainer;

		[SerializeField]
		private CanvasGroup _backgroundCanvasGroup;

		[SerializeField]
		private Image _headerIcon;

		[Header("Header Sprites")]
		[SerializeField]
		private Sprite _victorySprite;

		[SerializeField]
		private Sprite _defeatSprite;

		[SerializeField]
		private Sprite _drawSprite;

		[Header("Sounds")]
		[SerializeField]
		private SoundData _victoryAppearSound;

		[SerializeField]
		private SoundData _defeatAppearSound;

		[SerializeField]
		private SoundData _drawAppearSound;

		[SerializeField]
		private SoundData _headerMoveSound;

		[Header("Score")]
		[SerializeField]
		private TMP_Text _scoreTitle;

		[SerializeField]
		private RectTransform _yourRankContainer;

		[SerializeField]
		private TMP_Text _totalRankText;

		[SerializeField]
		private RectTransform _rankScoreContainer;

		[SerializeField]
		private TMP_Text _rankDeltaText;

		[Header("Total Reward")]
		[SerializeField]
		private TMP_Text _rewardTitle;

		[SerializeField]
		private RectTransform _rewardContainer;

		[SerializeField]
		private UIRewardsView _totalRewardsView;

		[Header("Fight Stats")]
		[SerializeField]
		private RectTransform _fightStatsContainer;

		[Header("Buttons")]
		[SerializeField]
		private UIButtonClick _continueButtonClick;

		[SerializeField]
		private RectTransform _doubleRewardContainer;

		[SerializeField]
		private UIRewardedVideoButton _doubleRewardButton;

		private GameplayRewardSystem _gameplayRewardSystem;

		private ISaveLoadDataService _saveLoadDataService;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Action _onContinue;

		private ArenaMatchOutcome _outcome;

		[Inject]
		public void Inject(GameplayRewardSystem gameplayRewardSystem, ISaveLoadDataService saveLoadDataService, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Open(ArenaMatchOutcome outcome, ArenaMatchResult matchResult, Action onContinue)
		{
		}

		private void PrepareScoreTexts(ArenaMatchResult matchResult)
		{
		}

		private Sprite GetHeaderSprite()
		{
			return null;
		}

		private SoundData GetAppearSound()
		{
			return null;
		}

		private void ShowHeaderOpening()
		{
		}

		private void MoveHeaderContainerUp()
		{
		}

		private void PlayResultsSequence()
		{
		}

		private void AppendScoreAndRewards(Sequence sequence)
		{
		}

		private void ShowFightStatsAndButtons()
		{
		}

		private void AppendFightStats(Sequence sequence)
		{
		}

		private void AppendButtons(Sequence sequence)
		{
		}

		private void OnContinueClicked()
		{
		}

		private void OnDoubleRewardClicked(bool isSuccess)
		{
		}
	}
}
