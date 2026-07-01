using __Game__.Scripts.Gameplay.Arena.Enemy;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaPostFightState : BaseArenaState
	{
		private const float TRANSITION_DELAY = 1f;

		private readonly UnitCountTracker _playerUnitCountTracker;

		private readonly UnitCountTracker _enemyUnitCountTracker;

		private readonly Castle _playerCastle;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly ArenaWaveSystem _arenaWaveSystem;

		private readonly BuildingRepository _buildingRepository;

		private readonly ArenaStakeTokenDropSystem _stakeTokenDropSystem;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private bool _resolved;

		public ArenaPostFightState(UnitCountTrackerFactory unitCountTrackerFactory, Castle castle, ArenaEnemyController arenaEnemyController, ArenaWaveSystem arenaWaveSystem, BuildingRepository buildingRepository, ArenaStakeTokenDropSystem stakeTokenDropSystem, AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnPlayerCastleDied()
		{
		}

		private void OnEnemyCastleDied()
		{
		}

		private void OnUnitCountChanged(int _)
		{
		}

		private void CheckAllUnitsDead()
		{
		}

		private void TransitionToCollectCoins(ArenaCollectCoinsResult result)
		{
		}
	}
}
