using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakRewardNode : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _pointsLabel;

		[SerializeField]
		private Transform _rewardContainer;

		[SerializeField]
		private UIButtonClick _claimButtonClick;

		[SerializeField]
		private GameObject _claimableState;

		[SerializeField]
		private GameObject _claimedState;

		private UIRewardsFactory _rewardsFactory;

		private UIRewardElement _rewardElement;

		private int _milestoneIndex;

		public event Action<int> OnClaimClicked
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

		public void Initialize(UIRewardsFactory rewardsFactory)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Refresh(int milestoneIndex, PointsMilestoneData milestone, bool isClaimed, bool isClaimable)
		{
		}

		private void BuildReward(PointsMilestoneData milestone)
		{
		}

		public float GetIconSize()
		{
			return 0f;
		}

		private void HandleClaimClicked()
		{
		}
	}
}
