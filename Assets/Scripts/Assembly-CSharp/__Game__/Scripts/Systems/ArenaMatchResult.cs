using __Game__.Scripts.Gameplay.Arena;

namespace __Game__.Scripts.Systems
{
	public struct ArenaMatchResult
	{
		public ArenaMatchOutcome Outcome;

		public int RatingDelta;

		public int TotalRating;

		public int Attempt;

		public int TierIndex;
	}
}
