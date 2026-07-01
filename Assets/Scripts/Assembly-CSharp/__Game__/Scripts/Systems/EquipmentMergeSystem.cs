using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class EquipmentMergeSystem
	{
		private readonly EquipmentSystem _equipmentSystem;

		private readonly RarityConfig _rarityConfig;

		private readonly Dictionary<string, List<EquipmentItem>> _allItemsPerRarityGuid;

		private bool _isMergeAvailable;

		public Dictionary<string, List<EquipmentItem>> MergeableItemsPerRarityGuid { get; }

		public bool IsMergeAvailable
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnMergeStatusChanged
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

		public event Action<EquipmentItem> OnMergeableItemAdded
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

		public event Action<EquipmentItem> OnMergeableItemRemoved
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

		public EquipmentMergeSystem(EquipmentSystem equipmentSystem, RarityConfig rarityConfig)
		{
		}

		public void Initialize()
		{
		}

		public void Merge(List<EquipmentItem> mergeItems)
		{
		}

		public EquipmentItem GetResultItem(EquipmentItem mergeableItem)
		{
			return null;
		}

		private void OnEquipmentAdded(EquipmentItem equipmentItem)
		{
		}

		private void OnEquipmentRemoved(EquipmentItem equipmentItem)
		{
		}

		private void TryRegisterMergeable(string key, EquipmentItem equipmentItem, List<EquipmentItem> equipmentItemList)
		{
		}

		private void TryUnregisterMergeable(string key, EquipmentItem equipmentItem, List<EquipmentItem> equipmentItemList)
		{
		}

		private void AddMergeableItem(string key, EquipmentItem equipmentItem)
		{
		}

		private void RemoveMergeableItem(string key, EquipmentItem equipmentItem)
		{
		}

		private void RefreshActiveMergesStatus()
		{
		}

		private static string GetItemKey(EquipmentItem item)
		{
			return null;
		}
	}
}
