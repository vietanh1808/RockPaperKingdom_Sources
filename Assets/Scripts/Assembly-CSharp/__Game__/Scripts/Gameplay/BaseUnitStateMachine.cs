namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseUnitStateMachine
	{
		private readonly BaseUnit _unit;

		public IUnitState CurrentState { get; private set; }

		public IUnitState TargetFollowState { get; private set; }

		public IUnitState TargetAttackState { get; private set; }

		public IUnitState StunState { get; private set; }

		public IUnitState SpawningWaitState { get; private set; }

		public IUnitState NoTargetState { get; protected set; }

		public IUnitState InitialState { get; protected set; }

		protected BaseUnitStateMachine(BaseUnit unit)
		{
		}

		private void InitializeCommonStates()
		{
		}

		public void SetState(IUnitState newState)
		{
		}

		public void Update()
		{
		}
	}
}
