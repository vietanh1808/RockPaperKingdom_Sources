namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseAbilityState
	{
		protected Ability Ability { get; }

		protected AbilityStateMachine StateMachine { get; }

		protected BaseAbilityState(AbilityStateMachine stateMachine, Ability ability)
		{
		}

		public virtual void Enter()
		{
		}

		public virtual void Tick()
		{
		}

		public virtual void Exit()
		{
		}
	}
}
