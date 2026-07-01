using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPatrolRewardsPopup : UIBasePopup
	{
		[Header("Claim Button")]
		[SerializeField]
		private UIButtonClick _claimButton;

		[SerializeField]
		private Image _claimButtonImage;

		[SerializeField]
		private Sprite _claimButtonActiveSprite;

		[SerializeField]
		private Sprite _claimButtonInactiveSprite;

		[Header("View")]
		[SerializeField]
		private TMP_Text _passTimeValue;

		[SerializeField]
		private RectTransform _sourceFloating;

		[SerializeField]
		private RectTransform _emptyMark;

		[Header("Rewards Per Hour")]
		[SerializeField]
		private RectTransform _rewardsPerHourContainer;

		[SerializeField]
		private UIRewardPerHourElement _uiRewardPerHourElement;

		[SerializeField]
		private int _maxRewardsPerHour;

		[Header("Rewards Result")]
		[SerializeField]
		private RectTransform _rewardsResultContainer;

		[Header("Quick Patrol")]
		[SerializeField]
		private UIQuickPatrolButton _quickPatrolButton;

		private readonly List<GameObject> _rewardElements;

		private PatrolRewardsSystem _patrolRewardsSystem;

		private PlayerLevelSystem _playerLevelSystem;

		private UIRewardFloating _uiRewardFloating;

		private UIRewardsFactory _uiRewardsFactory;

		private UIRewardOverlay _uiRewardOverlay;

		private int _lastTimePassMinute;

		private bool _closeOnOverlayClaimed;

		[Inject]
		private void Inject(PatrolRewardsSystem patrolRewardsSystem, PlayerLevelSystem playerLevelSystem, UIRewardFloating uiRewardFloating, UIRewardsFactory uiRewardsFactory, UIRewardOverlay uiRewardOverlay)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnTimeChanged()
		{
		}

		private void RefreshTime()
		{
		}

		private void CheckTimePassMinuteShift()
		{
		}

		private void RefreshAllElements()
		{
		}

		private void RefreshRewardsPerHour()
		{
		}

		private void ClearRewardPerHour()
		{
		}

		private void RefreshRewardsResult()
		{
		}

		private void ClearRewardsResult()
		{
		}

		private void RefreshPatrolEmptyMark()
		{
		}

		private void RefreshClaimButton()
		{
		}

		private void ClaimButtonClicked()
		{
		}

		private void OnOverlayClaimed()
		{
		}
	}
}
