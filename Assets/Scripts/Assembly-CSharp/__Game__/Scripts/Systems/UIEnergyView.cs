using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEnergyView : MonoBehaviour
	{
		[SerializeField]
		private EnergyItemData _energyItemData;

		[SerializeField]
		private RectTransform _targetContainer;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _amountValue;

		[SerializeField]
		private TMP_Text _timeToRecoveryValue;

		[SerializeField]
		private UIButtonClick _purchaseEnergyButton;

		private EnergySystem _energySystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private UIRewardFloating _uiRewardFloating;

		private int _previousAmount;

		[Inject]
		private void Inject(EnergySystem energySystem, UIRewardFloating uiRewardFloating, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshTime()
		{
		}

		private void RefreshAmount(int amount)
		{
		}

		private void OnEnergyAmountChanged(int amount)
		{
		}

		private void OnMaxAmountChanged(int maxAmount)
		{
		}

		private void OnPurchaseEnergyButtonClick()
		{
		}
	}
}
