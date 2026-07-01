using System;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	[Serializable]
	public class WeightPercentItem
	{
		[SerializeField]
		private float _weight;

		[SerializeField]
		private float _percent;

		[HideInInspector]
		[SerializeField]
		private float _cumulativePercent;

		public float Weight => 0f;

		public float Percent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CumulativePercent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string GetReadablePercent()
		{
			return null;
		}
	}
}
