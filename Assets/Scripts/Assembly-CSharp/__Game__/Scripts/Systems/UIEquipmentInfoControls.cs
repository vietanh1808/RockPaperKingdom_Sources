using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentInfoControls : MonoBehaviour
	{
		[SerializeField]
		private UIEquipmentInfoPopup _uiEquipmentInfoPopup;

		[SerializeField]
		private UIMultiPriceView _multiPriceView;

		[Header("Buttons")]
		[SerializeField]
		private UIButtonClick _equipButton;

		[SerializeField]
		private UIButtonClick _unequipButton;

		[SerializeField]
		private UIButtonClick _levelUpButton;

		[SerializeField]
		private UIButtonClick _maxLevelButton;

		[SerializeField]
		private UIButtonClick _refundButton;

		[Header("Audio")]
		[SerializeField]
		private SoundData _equipSound;

		[SerializeField]
		private SoundData _levelUpSound;

		private EquipmentSystem _equipmentSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		public void Inject(EquipmentSystem equipmentSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
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

		private void LevelChangedHandler(EquipmentItem equipmentItem)
		{
		}

		private void RefreshEquipControls()
		{
		}

		private void RefreshLevelUpControls()
		{
		}

		private void RefreshLevelUpCanUpgrade()
		{
		}

		private void RefreshRefundControls()
		{
		}

		private void EquipButtonClicked()
		{
		}

		private void UnequipButtonClicked()
		{
		}

		private void LevelUpButtonClicked()
		{
		}

		private void MaxLevelButtonClicked()
		{
		}

		private void RefundButtonClicked()
		{
		}
	}
}
