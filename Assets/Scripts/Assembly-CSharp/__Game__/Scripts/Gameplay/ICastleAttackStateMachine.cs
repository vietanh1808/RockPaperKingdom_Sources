namespace __Game__.Scripts.Gameplay
{
	public interface ICastleAttackStateMachine
	{
		IUnitState BuildMoveState { get; }

		IUnitState BuildAttackState { get; }

		IUnitState CastleMoveState { get; }

		IUnitState CastleAttackState { get; }

		IUnitState TargetFollowState { get; }

		IUnitState NoTargetState { get; }

		void SetState(IUnitState newState);
	}
}
