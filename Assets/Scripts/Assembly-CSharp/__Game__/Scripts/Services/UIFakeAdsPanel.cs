using System;
using TMPro;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Services
{
	public class UIFakeAdsPanel : MonoBehaviour
	{
		private const string REWARDED_TITLE = "Rewarded Ads";

		private const string INTERSTITIAL_TITLE = "Interstitial Ads";

		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private UIButtonClick _rewardButton;

		private Action<bool> _onClosed;

		private bool _isRewarded;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowRewarded(Action<bool> onClosed)
		{
		}

		public void ShowInterstitial(Action onClosed)
		{
		}

		private void HandleReward()
		{
		}

		private void HandleClose()
		{
		}

		private void Close(bool rewarded)
		{
		}
	}
}
