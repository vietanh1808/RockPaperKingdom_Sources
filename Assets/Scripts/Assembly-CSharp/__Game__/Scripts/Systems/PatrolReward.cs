using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PatrolReward
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private float _amountPerHour;

		public PatrolReward(InventoryItemData item, float value)
		{
		}

		public Reward ToReward(float hours)
		{
			return null;
		}
	}
}
