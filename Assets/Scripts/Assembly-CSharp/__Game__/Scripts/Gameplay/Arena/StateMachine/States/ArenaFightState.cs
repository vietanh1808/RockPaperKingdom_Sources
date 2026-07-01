using __Game__.Scripts.Gameplay.Arena.Enemy;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaFightState : BaseArenaState
	{
		private readonly UnitRepository _playerUnitRepository;

		private readonly UnitRepository _enemyUnitRepository;

		private readonly BuildingRepository _buildingRepository;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly UnitCountTracker _playerUnitCountTracker;

		private readonly UnitCountTracker _enemyUnitCountTracker;

		private readonly AssassinJumpIterator _assassinJumpIterator;

		private readonly ArenaStakeTokenDropSystem _stakeTokenDropSystem;

		public ArenaFightState(UnitRepositoryFactory unitRepositoryFactory, BuildingRepository buildingRepository, BuildingTargetRepository buildingTargetRepository, ArenaEnemyController arenaEnemyController, UnitCountTrackerFactory unitCountTrackerFactory, AssassinJumpIterator assassinJumpIterator, ArenaStakeTokenDropSystem stakeTokenDropSystem)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnUnitCountChanged(int unitsLeft)
		{
		}

		private void ActivateAllUnits()
		{
		}
	}
}
