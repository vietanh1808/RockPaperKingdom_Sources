namespace __Game__.Scripts.Gameplay
{
	public class EnemyStateMachine : BaseUnitStateMachine, ICastleAttackStateMachine
	{
		private readonly BaseUnit _enemyUnit;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly Castle _castle;

		public IUnitState BuildMoveState { get; private set; }

		public IUnitState BuildAttackState { get; private set; }

		public IUnitState CastleMoveState { get; private set; }

		public IUnitState CastleAttackState { get; private set; }

		public EnemyStateMachine(BaseUnit enemyUnit, BuildingTargetRepository buildingTargetRepository, Castle castle)
			: base(null)
		{
		}

		private void InitializeStates()
		{
		}
	}
}
