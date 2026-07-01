using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class EquipmentMergePresenter
	{
		private readonly EquipmentMergeSystem _equipmentMergeSystem;

		public List<EquipmentItem> SelectedMergeItems { get; }

		public EquipmentItem ResultItem { get; private set; }

		public EquipmentItem SelectedItem => null;

		public event Action<EquipmentItem> OnItemSelected
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

		public event Action<EquipmentItem> OnItemDeselected
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

		public event Action OnItemsCleared
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

		public EquipmentMergePresenter(EquipmentMergeSystem equipmentMergeSystem)
		{
		}

		public void SelectItem(EquipmentItem mergeItem)
		{
		}

		public void Clear()
		{
		}

		private bool IsMergeCancel(EquipmentItem mergeItem)
		{
			return false;
		}
	}
}
