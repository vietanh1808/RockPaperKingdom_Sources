using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class RewardData
	{
		[SerializeField]
		private RewardType _rewardType;

		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private RarityType _equipmentRarity;

		[SerializeField]
		private int _amount;

		public RewardType RewardType => default(RewardType);

		public InventoryItemData InventoryItemData => null;

		public int Amount => 0;

		public RarityType EquipmentRarity => default(RarityType);

		public RewardData(InventoryItemData inventoryItemData, int amount)
		{
		}

		public RewardData(RewardData other)
		{
		}

		public InventoryItem GetInventoryItem()
		{
			return null;
		}

		private bool ShowEquipment()
		{
			return false;
		}

		private void ValidateRewardType()
		{
		}
	}
}
