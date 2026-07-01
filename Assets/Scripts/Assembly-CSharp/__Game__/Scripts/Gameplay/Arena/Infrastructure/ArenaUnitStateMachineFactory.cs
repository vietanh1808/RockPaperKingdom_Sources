using __Game__.Scripts.Gameplay.Arena.Enemy;

namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public class ArenaUnitStateMachineFactory : UnitStateMachineFactory
	{
		private readonly Castle _playerCastle;

		private readonly BuildingTargetRepository _playerBuildingTargetRepository;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly int _playerLayer;

		private readonly int _enemyLayer;

		public ArenaUnitStateMachineFactory(BuildingTargetRepository playerBuildingTargetRepository, Castle playerCastle, ArenaEnemyController arenaEnemyController)
			: base(null, null)
		{
		}

		public override BaseUnitStateMachine GetUnitStateMachine(BaseUnit unit, UnitType unitType)
		{
			return null;
		}

		private UnitType GetSideFromLayer(int layer)
		{
			return default(UnitType);
		}
	}
}
