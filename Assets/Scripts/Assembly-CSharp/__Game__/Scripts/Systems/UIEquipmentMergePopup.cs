using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentMergePopup : MonoBehaviour
	{
		private const string DEFAULT_DESCRIPTION = "Select equipment to merge!";

		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private UIButtonClick _mergeButton;

		[SerializeField]
		private TMP_Text _description;

		[SerializeField]
		private GameObject _messageContainer;

		[SerializeField]
		private TMP_Text _messageValue;

		[SerializeField]
		private UIEquipmentElement _resultElement;

		[SerializeField]
		private List<UIMergeProcessSlot> _selectedElements;

		private EquipmentMergeSystem _equipmentMergeSystem;

		private EquipmentMergePresenter _equipmentMergePresenter;

		private RarityConfig _rarityConfig;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private UIEquipmentInfoPopup _uiEquipmentInfoPopup;

		[Inject]
		public void Inject(EquipmentMergeSystem equipmentMergeSystem, EquipmentMergePresenter equipmentMergePresenter, RarityConfig rarityConfig, UIProjectHolder uiProjectHolder, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnItemSelected(EquipmentItem equipmentItem)
		{
		}

		private void OnItemDeselected(EquipmentItem equipmentItem)
		{
		}

		private void StartMerge()
		{
		}

		private void ReadyForMerge()
		{
		}

		private void OnItemsCleared()
		{
		}

		private void DeselectMerge()
		{
		}

		private void RefreshAllSlots()
		{
		}

		private void ShowSlotByIndex(int itemIndex)
		{
		}

		private void ShowResultSlot()
		{
		}

		private void ShowMessage()
		{
		}

		private void HideMessage()
		{
		}

		private void ShowMergeButton()
		{
		}

		private void HideMergeButton()
		{
		}

		private void ClearDescription()
		{
		}

		private string GetItemDescription()
		{
			return null;
		}

		private void MergeButtonClicked()
		{
		}

		private void OnResultButtonClicked(EquipmentItem equipmentItem)
		{
		}

		private void CloseButtonClicked()
		{
		}
	}
}
