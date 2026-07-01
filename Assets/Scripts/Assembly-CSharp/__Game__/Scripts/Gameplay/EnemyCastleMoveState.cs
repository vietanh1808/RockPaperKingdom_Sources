namespace __Game__.Scripts.Gameplay
{
	public class EnemyCastleMoveState : IUnitState
	{
		private const float CASTLE_TOUCH_DISTANCE = 0.5f;

		private readonly ICastleAttackStateMachine _stateMachine;

		private readonly Castle _castle;

		private readonly BaseUnit _unit;

		private float _enterTime;

		public EnemyCastleMoveState(ICastleAttackStateMachine stateMachine, Castle castle, BaseUnit unit)
		{
		}

		public void Enter()
		{
		}

		public void Update()
		{
		}

		public void Exit()
		{
		}
	}
}
