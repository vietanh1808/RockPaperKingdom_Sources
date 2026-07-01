namespace __Game__.Scripts.Gameplay.Arena.StateMachine
{
	public abstract class BaseArenaState
	{
		protected ArenaStateMachine StateMachine { get; private set; }

		public void Initialize(ArenaStateMachine arenaStateMachine)
		{
		}

		public abstract void Enter();

		public virtual void Exit()
		{
		}
	}
}
