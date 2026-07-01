namespace __Game__.Scripts.Gameplay
{
	public class AbilityStateMachine
	{
		private BaseAbilityState _currentState;

		public InactiveAbilityState InactiveState { get; }

		public ActiveAbilityState ActiveState { get; }

		public CooldownAbilityState CooldownState { get; }

		public CastPendingAbilityState CastPendingAbilityState { get; }

		public CastAbilityState CastState { get; }

		public WaitForRoundAbilityState WaitForRoundState { get; }

		public AbilityStateMachine(Ability ability)
		{
		}

		public void SetState(BaseAbilityState newState)
		{
		}

		public void Tick()
		{
		}
	}
}
