using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentInventoryView : SerializedMonoBehaviour
	{
		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIEquipmentElement _equipmentElementPrefab;

		[SerializeField]
		private UIEquipmentSorter _equipmentSorter;

		[SerializeField]
		private RectTransform _emptyMark;

		private Dictionary<EquipmentItem, UIEquipmentElement> _equipmentElementDictionary;

		private EquipmentSystem _equipmentSystem;

		private RarityConfig _rarityConfig;

		private UIMenuSceneNavigation _menuSceneNavigation;

		public event Action OnEquipmentElementsCreated
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
		public void Inject(EquipmentSystem equipmentSystem, RarityConfig rarityConfig, UIMenuSceneNavigation menuSceneNavigation)
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

		private void EquipmentChanged(EquipmentItem equipmentItem)
		{
		}

		private void CheckEmptyMark()
		{
		}

		private void ElementButtonClicked(EquipmentItem equipmentItem)
		{
		}

		private void SortElements()
		{
		}
	}
}
