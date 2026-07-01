using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplayEndPopup : MonoBehaviour
	{
		[Header("Header")]
		[SerializeField]
		private RectTransform _headerContainer;

		[SerializeField]
		private CanvasGroup _backgroundCanvasGroup;

		[SerializeField]
		private TMP_Text _stageCompletedText;

		[SerializeField]
		private Image _headerIcon;

		[Header("Header Sprites")]
		[SerializeField]
		private Sprite _victorySprite;

		[SerializeField]
		private Sprite _defeatSprite;

		[Header("Sounds")]
		[SerializeField]
		private SoundData _victoryAppearSound;

		[SerializeField]
		private SoundData _defeatAppearSound;

		[SerializeField]
		private SoundData _headerMoveSound;

		[Header("Summary")]
		[SerializeField]
		private TMP_Text _stageText;

		[SerializeField]
		private TMP_Text _remainingHPText;

		[SerializeField]
		private GameObject _bestResultContainer;

		[Header("Total Reward")]
		[SerializeField]
		private RectTransform _totalRewardContainer;

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

		private GameStateMachine _gameStateMachine;

		private GameplayRewardSystem _gameplayRewardSystem;

		private ISaveLoadDataService _saveLoadDataService;

		private StageSystem _stageSystem;

		private Castle _castle;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private int _selectedStageIndex;

		private bool _isVictory;

		[Inject]
		public void Inject(GameStateMachine gameStateMachine, GameplayRewardSystem gameplayRewardSystem, ISaveLoadDataService saveLoadDataService, StageSystem stageSystem, Castle castle, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Open(int selectedStageIndex, bool isVictory)
		{
		}

		private void UpdateStageCompletedText()
		{
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

		private void PrepareSummaryTexts()
		{
		}

		private void AppendSummaryAndRewards(Sequence sequence)
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

		private void ClaimTotalRewards()
		{
		}

		private void OnContinueButtonClick()
		{
		}

		private void OnDoubleRewardButtonClick(bool isSuccess)
		{
		}
	}
}
