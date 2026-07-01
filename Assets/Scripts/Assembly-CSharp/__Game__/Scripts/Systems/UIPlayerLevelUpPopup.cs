using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerLevelUpPopup : UIBasePopup
	{
		[Header("References")]
		[SerializeField]
		private Image _background;

		[SerializeField]
		private RectTransform _frame;

		[SerializeField]
		private UILevelUpProgressView _progressView;

		[SerializeField]
		private UIRewardsView _rewardsView;

		[SerializeField]
		private CanvasGroup _rewardsTitleCanvasGroup;

		[SerializeField]
		private GameObject _confetti;

		[Header("1. Appear")]
		[SerializeField]
		private SoundData _appearSound;

		[SerializeField]
		private float _appearBackgroundDuration;

		[SerializeField]
		private float _appearFrameDuration;

		[Header("2. Frame Resize")]
		[SerializeField]
		private float _frameCompactHeight;

		[SerializeField]
		private float _frameExpandedHeight;

		[SerializeField]
		private float _frameResizeDuration;

		[SerializeField]
		private SoundData _expandSound;

		[Header("3. Rewards")]
		[SerializeField]
		private float _rewardsTitleFadeDuration;

		[SerializeField]
		private float _closeDelay;

		[Header("4. Disappear")]
		[SerializeField]
		private float _disappearFrameDuration;

		[SerializeField]
		private float _disappearBackgroundDuration;

		private PlayerLevelSystem _playerLevelSystem;

		private RewardSystem _rewardSystem;

		private UIRewardFloating _uiRewardFloating;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private List<Reward> _rewards;

		private Sequence _animationSequence;

		private Tween _closeDelayTween;

		[Inject]
		private void Inject(PlayerLevelSystem playerLevelSystem, RewardSystem rewardSystem, UIRewardFloating uiRewardFloating, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void ClosePopup()
		{
		}

		private void OnLevelChanged()
		{
		}

		private void ResetView()
		{
		}

		private void PlayAppearAnimation()
		{
		}

		private void PlayDisappearAnimation()
		{
		}

		private void PlayLevelUpSequence()
		{
		}

		private void OnProgressLevelChanged()
		{
		}

		private void OnProgressComplete()
		{
		}

		private void ShowRewards()
		{
		}

		private void OnRewardsAnimationComplete()
		{
		}

		private void DestroyRewardElements()
		{
		}
	}
}
