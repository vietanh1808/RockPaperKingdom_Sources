namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class RPSGameResult
	{
		public RPSResultType ResultType { get; }

		public bool IsWin => false;

		public bool IsDraw => false;

		public RPSChoice PlayerChoice { get; }

		public RPSChoice OpponentChoice { get; }

		public RPSOutcomeData Outcome { get; }

		public RPSGameResult(RPSResultType resultType, RPSChoice playerChoice, RPSChoice opponentChoice, RPSOutcomeData outcome = null)
		{
		}
	}
}
