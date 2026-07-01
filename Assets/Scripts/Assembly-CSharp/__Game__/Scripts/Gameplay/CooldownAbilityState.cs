namespace __Game__.Scripts.Gameplay
{
	public class CooldownAbilityState : BaseAbilityState
	{
		private float _preparingCastTime;

		public CooldownAbilityState(AbilityStateMachine stateMachine, Ability ability)
			: base(null, null)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		public override void Tick()
		{
		}

		private void OnCooldownFinished()
		{
		}
	}
}
