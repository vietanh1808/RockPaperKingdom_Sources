using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	[Serializable]
	public class PredefinedRpsPlay
	{
		[SerializeField]
		private RPSResultType _resultType;

		[SerializeField]
		private RPSOutcomeType _outcomeType;

		public RPSResultType ResultType => default(RPSResultType);

		public RPSOutcomeType OutcomeType => default(RPSOutcomeType);
	}
}
