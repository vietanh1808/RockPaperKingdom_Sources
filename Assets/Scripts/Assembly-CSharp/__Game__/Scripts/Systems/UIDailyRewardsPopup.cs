using System;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIDailyRewardsPopup : UIBasePopup
	{
		[Header("Buttons")]
		[SerializeField]
		private GameObject _buttonsContainer;

		[SerializeField]
		private UIButtonClick _claimButton;

		[SerializeField]
		private GameObject _doubleRewardButtonObject;

		[SerializeField]
		private UIRewardedVideoButton _doubleRewardButton;

		[Header("Cooldown")]
		[SerializeField]
		private GameObject _cooldownContainer;

		[SerializeField]
		private TMP_Text _cooldownText;

		[Header("First Week Special Day")]
		[SerializeField]
		private GameObject _firstWeekSpecialDay;

		[SerializeField]
		private GameObject _regularDay7Slot;

		private DailyRewardsSystem _dailyRewardsSystem;

		private UIRewardOverlay _uiRewardOverlay;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		[Inject]
		public void Inject(DailyRewardsSystem dailyRewardsSystem, UIRewardOverlay uiRewardOverlay, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void ShowCooldown(bool isCooldownActive)
		{
		}

		private void UpdateCooldownText(TimeSpan time)
		{
		}

		private void ClaimButtonClicked()
		{
		}

		private void DoubleRewardButtonClicked(bool isSuccess)
		{
		}
	}
}
