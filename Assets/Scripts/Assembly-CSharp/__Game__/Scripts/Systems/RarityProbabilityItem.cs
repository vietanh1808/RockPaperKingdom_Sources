using System;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class RarityProbabilityItem
	{
		public RarityType RarityType;

		public WeightPercentItem Probability;
	}
}
