namespace __Game__.Scripts.Gameplay
{
	public class UnitStateMachineFactory
	{
		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly Castle _castle;

		public UnitStateMachineFactory(BuildingTargetRepository buildingTargetRepository, Castle castle)
		{
		}

		public virtual BaseUnitStateMachine GetUnitStateMachine(BaseUnit unit, UnitType unitType)
		{
			return null;
		}
	}
}
