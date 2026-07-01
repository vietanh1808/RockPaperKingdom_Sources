namespace __Game__.Scripts.Gameplay.Arena.Units
{
	public class ArenaUnitStateMachine : BaseUnitStateMachine, ICastleAttackStateMachine
	{
		public IUnitState BuildMoveState { get; private set; }

		public IUnitState BuildAttackState { get; private set; }

		public IUnitState CastleMoveState { get; private set; }

		public IUnitState CastleAttackState { get; private set; }

		public ArenaUnitStateMachine(BaseUnit unit, BuildingTargetRepository opponentBuildingTargetRepository, Castle opponentCastle)
			: base(null)
		{
		}
	}
}
