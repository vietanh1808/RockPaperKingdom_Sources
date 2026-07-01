namespace __Game__.Scripts.Gameplay.StateMachine
{
	public abstract class BaseGameplayState
	{
		protected GameplayStateMachine StateMachine { get; private set; }

		public void Initialize(GameplayStateMachine gameplayStateMachine)
		{
		}

		public abstract void Enter();

		public virtual void Exit()
		{
		}
	}
}
