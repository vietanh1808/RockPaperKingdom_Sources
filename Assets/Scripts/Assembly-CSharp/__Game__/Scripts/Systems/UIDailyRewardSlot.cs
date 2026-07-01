using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIDailyRewardSlot : MonoBehaviour
	{
		[Range(0f, 6f)]
		[SerializeField]
		private int _slotIndex;

		[SerializeField]
		private TMP_Text _dayValue;

		[SerializeField]
		private Transform _rewardContainer;

		[SerializeField]
		private RectTransform _sourceContainer;

		[Header("Rewarded Day")]
		[SerializeField]
		private GameObject _backgroundRewardedDay;

		[SerializeField]
		private GameObject _markRewardedDay;

		[Header("Current Day")]
		[SerializeField]
		private GameObject _markCurrentDay;

		[Header("Ready Day")]
		[SerializeField]
		private GameObject _backgroundReadyDay;

		[Header("Background")]
		[SerializeField]
		private bool _hideBackground;

		private DailyRewardsSystem _dailyRewardsSystem;

		private UIRewardFloating _uiRewardFloating;

		private UIRewardsFactory _uiRewardsFactory;

		private readonly List<GameObject> _rewardElements;

		[Inject]
		public void Inject(DailyRewardsSystem dailyRewardsSystem, UIRewardFloating uiRewardFloating, UIRewardsFactory uiRewardsFactory)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupViewByWeek()
		{
		}

		private void HideRewardBackground(GameObject element)
		{
		}

		private void DestroyRewardElements()
		{
		}

		private void SetupViewByCooldown(bool isCooldown)
		{
		}
	}
}
