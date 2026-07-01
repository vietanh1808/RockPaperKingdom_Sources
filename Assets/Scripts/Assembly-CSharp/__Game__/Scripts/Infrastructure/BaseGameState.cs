namespace __Game__.Scripts.Infrastructure
{
	public abstract class BaseGameState
	{
		protected GameStateMachine GameStateMachine { get; private set; }

		public void Initialize(GameStateMachine gameStateMachine)
		{
		}

		public abstract void Enter();

		public virtual void Exit()
		{
		}
	}
}
