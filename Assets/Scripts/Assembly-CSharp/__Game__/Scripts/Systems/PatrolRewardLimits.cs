using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PatrolRewardLimits
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private int _minRewardLimit;

		[SerializeField]
		private int _maxRewardLimit;

		public InventoryItemData InventoryItemData => null;

		public void ClampAmount(Reward reward)
		{
		}
	}
}
