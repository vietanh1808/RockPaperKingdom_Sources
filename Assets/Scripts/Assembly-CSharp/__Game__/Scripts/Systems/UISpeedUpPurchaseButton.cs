using System;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpeedUpPurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private FeatureItemData _featureItemData;

		[SerializeField]
		private UIButtonClick _buttonClick;

		[Header("Active State")]
		[SerializeField]
		private TMP_Text _timerText;

		[SerializeField]
		private TMP_Text _speedUpText;

		private FeatureItem _featureItem;

		private SpeedUpPurchaseSystem _speedUpPurchaseSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		private void Inject(FeatureUnlockSystem featureUnlockSystem, SpeedUpPurchaseSystem speedUpPurchaseSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAvailableStatusChanged()
		{
		}

		private void OnFeatureItemStatusChanged(FeatureItem featureItem)
		{
		}

		private void OnCooldownTimeChanged(TimeSpan cooldownTime)
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
