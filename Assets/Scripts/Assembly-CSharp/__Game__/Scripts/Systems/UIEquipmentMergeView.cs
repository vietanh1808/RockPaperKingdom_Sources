using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentMergeView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootLayout;

		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIEquipmentMergeElement _equipmentMergeElementPrefab;

		[SerializeField]
		private UIEquipmentSorter _equipmentSorter;

		private readonly Dictionary<EquipmentItem, UIEquipmentElement> _equipmentElementDictionary;

		private readonly List<UIEquipmentMergeElement> _selectedElements;

		private EquipmentMergeSystem _equipmentMergeSystem;

		private EquipmentMergePresenter _equipmentMergePresenter;

		private RarityConfig _rarityConfig;

		[Inject]
		public void Inject(EquipmentMergeSystem equipmentMergeSystem, EquipmentMergePresenter equipmentMergePresenter, RarityConfig rarityConfig)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CreateAllElements()
		{
		}

		private void RemoveAllElements()
		{
		}

		private void AddElement(EquipmentItem equipmentItem)
		{
		}

		private void RemoveElement(EquipmentItem equipmentItem)
		{
		}

		private void OnItemSelected(EquipmentItem equipmentItem)
		{
		}

		private void OnItemDeselected(EquipmentItem equipmentItem)
		{
		}

		private void ShowMergeCandidates()
		{
		}

		private void ShowAllElements()
		{
		}

		private void DeselectAllElements()
		{
		}

		private void ElementButtonClicked(EquipmentItem equipmentItem)
		{
		}

		private void SortElements()
		{
		}

		private UIEquipmentMergeElement GetEquipmentElement(EquipmentItem equipmentItem)
		{
			return null;
		}
	}
}
