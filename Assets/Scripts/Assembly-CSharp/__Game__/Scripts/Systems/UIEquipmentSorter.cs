using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentSorter : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _sortButton;

		[SerializeField]
		private TMP_Text _sortTypeText;

		private EquipmentSortType _sortType;

		public event Action OnSortTypeChanged
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

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Sort(Dictionary<EquipmentItem, UIEquipmentElement> equipmentElements)
		{
		}

		private void RefreshTypeText()
		{
		}

		private void IncrementSortType()
		{
		}

		private void SortByRarity(List<KeyValuePair<EquipmentItem, UIEquipmentElement>> equipmentElements)
		{
		}

		private void SortByLevel(List<KeyValuePair<EquipmentItem, UIEquipmentElement>> equipmentElements)
		{
		}
	}
}
