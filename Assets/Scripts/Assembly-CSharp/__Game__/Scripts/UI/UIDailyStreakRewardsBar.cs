using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakRewardsBar : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _pointsText;

		[SerializeField]
		private List<UIDailyStreakRewardNode> _rewardNodes;

		[SerializeField]
		private List<Slider> _sliders;

		[SerializeField]
		private float _countDuration;

		[SerializeField]
		private float _punchScale;

		[SerializeField]
		private float _punchDuration;

		private const float SLIDER_OVERFLOW_VALUE = 1.25f;

		private DailyStreakQuestSystem _system;

		private UIRewardsFactory _rewardsFactory;

		private UIRewardFloating _uiRewardFloating;

		private int _displayedPoints;

		private Tween _countTween;

		private Tween _punchTween;

		[Inject]
		private void Inject(UIRewardsFactory rewardsFactory, UIRewardFloating uiRewardFloating)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize(DailyStreakQuestSystem system)
		{
		}

		public void Dispose()
		{
		}

		private void OnPointsChanged()
		{
		}

		private void OnMilestoneClaimed()
		{
		}

		private void AnimatePoints(int targetPoints)
		{
		}

		private void RefreshNodes()
		{
		}

		private static void UpdateSlider(Slider slider, int rangeStart, int rangeEnd, int totalPoints)
		{
		}

		private void OnNodeClaimClicked(int milestoneIndex)
		{
		}

		private void KillTweens()
		{
		}
	}
}
