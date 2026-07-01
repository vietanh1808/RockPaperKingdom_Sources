using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardOverlay : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private UIRewardsView _uiRewardsView;

		[SerializeField]
		private ScrollRect _scrollRect;

		private Action _onRewardClaimed;

		public event Action OnRewardClaimed
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowRewards(List<Reward> rewards, Action onClaimPressed)
		{
		}

		private void TapToContinue()
		{
		}
	}
}
