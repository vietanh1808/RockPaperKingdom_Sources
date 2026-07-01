using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class CollectibleLevelUpPrice
	{
		[SerializeField]
		private List<PriceData> _price;

		[SerializeField]
		private int _materialAmounts;

		public List<PriceData> Price => null;

		public int MaterialAmount => 0;

		public CollectibleLevelUpPrice(List<PriceData> price, int materialAmounts)
		{
		}
	}
}
