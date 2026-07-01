using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIQuickPatrolButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private Sprite _activeSprite;

		[SerializeField]
		private Sprite _inactiveSprite;

		[SerializeField]
		private TMP_Text _priceText;

		[Header("Energy Cost")]
		[SerializeField]
		private Image _energyIcon;

		[SerializeField]
		private TMP_Text _energyCostText;

		[Header("Rewarded Video")]
		[SerializeField]
		private GameObject _rewardedVideoMark;

		[Header("Cooldown")]
		[SerializeField]
		private GameObject _cooldownContainer;

		[SerializeField]
		private TMP_Text _cooldownText;

		[Header("Available Count")]
		[SerializeField]
		private GameObject _availableCountContainer;

		[SerializeField]
		private TMP_Text _availableCountText;

		private QuickPatrolSystem _quickPatrolSystem;

		private bool _isSubscribed;

		[Inject]
		private void Inject(QuickPatrolSystem quickPatrolSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeListeners()
		{
		}

		private void UnsubscribeListeners()
		{
		}

		private void QuickPatrolButtonHandler()
		{
		}

		private void OnPurchaseCompleted(bool isSuccess)
		{
		}

		private void OnCooldownTimeChanged(TimeSpan time)
		{
		}

		private void RefreshUI()
		{
		}

		private void RefreshEnergyCost()
		{
		}

		private void RefreshRewardedVideoMark()
		{
		}

		private void RefreshCooldownDisplay()
		{
		}

		private void RefreshAvailableCount()
		{
		}

		private void RefreshState()
		{
		}

		private string GetPriceText()
		{
			return null;
		}
	}
}
