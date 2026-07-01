namespace __Game__.Scripts.Gameplay
{
	public class EnemyBuildMoveState : IUnitState
	{
		private readonly ICastleAttackStateMachine _stateMachine;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly BaseUnit _unit;

		private float _castRange;

		private float _enterTime;

		public EnemyBuildMoveState(ICastleAttackStateMachine stateMachine, BuildingTargetRepository buildingTargetRepository, BaseUnit unit)
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
