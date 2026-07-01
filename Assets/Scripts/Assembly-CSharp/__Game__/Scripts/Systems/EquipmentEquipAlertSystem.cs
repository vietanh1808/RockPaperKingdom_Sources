using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class EquipmentEquipAlertSystem
	{
		private readonly Dictionary<EquipmentType, List<EquipmentItem>> _equipmentDictionary;

		private readonly EquipmentSystem _equipmentSystem;

		private int _equipCount;

		private bool _alertEquip;

		public bool AlertEquip
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnAlertEquipChanged
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

		public EquipmentEquipAlertSystem(EquipmentSystem equipmentSystem)
		{
		}

		public void Initialize()
		{
		}

		private void AddEquipmentItem(EquipmentItem equipmentItem)
		{
		}

		private void RemoveEquipmentItem(EquipmentItem equipmentItem)
		{
		}

		private void OnEquippedHandler(EquipmentItem equipmentItem)
		{
		}

		private void OnUnequippedHandler(EquipmentItem equipmentItem)
		{
		}

		private void RefreshActiveEquip(bool alertEquip)
		{
		}

		private bool GetAlertEquipStatus(EquipmentItem equipmentItem)
		{
			return false;
		}
	}
}
