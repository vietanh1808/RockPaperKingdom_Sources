namespace __Game__.Scripts.Gameplay
{
	public class PlayerStateMachine : BaseUnitStateMachine
	{
		private readonly BaseUnit _playerUnit;

		public IUnitState IdleState { get; private set; }

		public PlayerStateMachine(BaseUnit playerUnit)
			: base(null)
		{
		}

		private void InitializePlayerStates()
		{
		}
	}
}
