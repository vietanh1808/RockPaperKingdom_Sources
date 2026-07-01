using System;
using UnityEngine;

namespace __Game__.Scripts.Systems.Bundles
{
	[Serializable]
	public class RarityItemWeightData
	{
		[SerializeField]
		private RarityType _rarityType;

		[SerializeField]
		private float _weight;

		[SerializeField]
		private float _weightPercent;

		public RarityType RarityType => default(RarityType);

		public float Weight => 0f;

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
