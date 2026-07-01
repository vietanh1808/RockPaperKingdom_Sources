using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class Reward : IInventoryItemHolder
	{
		[SerializeField]
		private RewardType _rewardType;

		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private RarityType _equipmentRarity;

		[SerializeField]
		private int _amount;

		public InventoryItemData InventoryItemData => null;

		public RarityType EquipmentRarity => default(RarityType);

		public int Amount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action OnAmountChanged
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

		public Reward(InventoryItemData inventoryItemData, int amount = 1)
		{
		}

		public Reward(InventoryItemData inventoryItemData, int amount, RewardType rewardType, RarityType equipmentRarity)
		{
		}

		public Reward(RewardData rewardData)
		{
		}

		public InventoryItem GetInventoryItem()
		{
			return null;
		}

		public Reward Clone()
		{
			return null;
		}
	}
}
