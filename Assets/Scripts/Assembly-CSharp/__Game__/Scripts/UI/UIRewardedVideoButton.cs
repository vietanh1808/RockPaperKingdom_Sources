using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.UI
{
	public class UIRewardedVideoButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private string _placementName;

		[SerializeField]
		private SoundData _rewardedSfx;

		private IAdsService _adsService;

		private bool _isShown;

		public event Action<bool> OnRewardedVideoCompleted
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

		[Inject]
		private void Inject(IAdsService adsService)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void HandleButtonClicked()
		{
		}

		private void HandleRewardedAdCompleted(bool isSuccess)
		{
		}

		private void HandleRewardedStatusChanged()
		{
		}

		private void UpdateButtonAvailability()
		{
		}
	}
}
