namespace __Game__.Scripts.Gameplay
{
	public class EnemyBuildAttackState : IUnitState
	{
		private readonly ICastleAttackStateMachine _stateMachine;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly BaseUnit _unit;

		private BaseBuilding _currentTarget;

		private float _castRange;

		public EnemyBuildAttackState(ICastleAttackStateMachine stateMachine, BuildingTargetRepository buildingTargetRepository, BaseUnit unit)
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
