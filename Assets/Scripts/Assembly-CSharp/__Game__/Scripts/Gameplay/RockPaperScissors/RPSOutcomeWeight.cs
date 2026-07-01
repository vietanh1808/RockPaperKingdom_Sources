using System;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	[Serializable]
	public class RPSOutcomeWeight
	{
		[SerializeField]
		private RPSOutcomeType _outcomeType;

		[SerializeField]
		private WeightPercentItem _weight;

		public RPSOutcomeType OutcomeType => default(RPSOutcomeType);

		public WeightPercentItem Weight => null;
	}
}
