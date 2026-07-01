using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	[CreateAssetMenu(fileName = "Config_RockPaperScissors", menuName = "TapHub/Gameplay/Rock Paper Scissors Config")]
	public class RockPaperScissorsConfig : ScriptableObject
	{
		[SerializeField]
		private float _winWeight;

		[SerializeField]
		private float _drawWeight;

		[SerializeField]
		private float _loseWeight;

		[SerializeField]
		private List<RPSOutcomeData> _outcomeRewards;

		[SerializeField]
		private List<RPSOutcomeWeight> _outcomeWeights;

		[SerializeField]
		private int _maxGameplayCardsPerSession;

		[SerializeField]
		private List<MysteryCardGuarantee> _mysteryCardGuarantees;

		public IReadOnlyList<RPSOutcomeData> OutcomeRewards => null;

		public int MaxGameplayCardsPerSession => 0;

		public IReadOnlyList<MysteryCardGuarantee> MysteryCardGuarantees => null;

		public RPSResultType ResolveResultType()
		{
			return default(RPSResultType);
		}

		public RPSOutcomeType ResolveRandomOutcomeType()
		{
			return default(RPSOutcomeType);
		}

		public RPSOutcomeData GetOutcomeByType(RPSOutcomeType outcomeType)
		{
			return null;
		}

		private float CalculateTotalOutcomeWeight()
		{
			return 0f;
		}
	}
}
