using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class InventoryItemWeightData
	{
		[SerializeField]
		private InventoryItemData _item;

		[SerializeField]
		private int _weight;

		[SerializeField]
		private float _weightPercent;

		public InventoryItemData Item => null;

		public int Weight => 0;

		public float WeightPercent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
