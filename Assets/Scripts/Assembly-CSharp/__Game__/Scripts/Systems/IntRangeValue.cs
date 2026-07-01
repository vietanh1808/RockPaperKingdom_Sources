using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public struct IntRangeValue
	{
		[SerializeField]
		private int _min;

		[SerializeField]
		private int _max;

		public int Min => 0;

		public int Max => 0;
	}
}
