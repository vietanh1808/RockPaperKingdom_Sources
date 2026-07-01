using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class ChestDataAmount
	{
		[SerializeField]
		private ChestData _data;

		[SerializeField]
		private int _amount;

		public ChestData Data => null;

		public int Amount => 0;

		public ChestDataAmount(ChestData data, int amount)
		{
		}
	}
}
