using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class EquipmentLevelUpPrice
	{
		[SerializeField]
		private List<PriceData> _price;

		[SerializeField]
		private int _materialAmounts;

		public List<PriceData> Price => null;

		public int MaterialAmount => 0;
	}
}
