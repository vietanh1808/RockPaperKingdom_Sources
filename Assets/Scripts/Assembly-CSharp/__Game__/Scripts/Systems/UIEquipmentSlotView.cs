using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentSlotView : MonoBehaviour
	{
		[SerializeField]
		private List<UIEquipmentSlot> _slotElements;

		private readonly Dictionary<EquipmentType, UIEquipmentSlot> _slotElementDictionary;

		private readonly Dictionary<EquipmentItem, UIEquipmentSlot> _slotEquippedDictionary;

		private EquipmentSystem _equipmentSystem;

		public event Action OnEquipmentSlotInitialized
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
		public void Inject(EquipmentSystem equipmentSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupAllElements()
		{
		}

		private void UnequipAllElements()
		{
		}

		private UIEquipmentSlot GetEquipmentSlotElement(EquipmentItem equipmentItem)
		{
			return null;
		}

		private void EquippedElement(EquipmentItem equipmentItem)
		{
		}

		private void UnequippedElement(EquipmentItem equipmentItem)
		{
		}
	}
}
