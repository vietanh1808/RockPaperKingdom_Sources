using __Game__.Scripts.Gameplay.Arena.Enemy;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaEnemyProcessingState : BaseArenaState
	{
		private const float BEFORE_PROCESSING_DELAY = 0.5f;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly BuildingRepository _buildingRepository;

		public ArenaEnemyProcessingState(ArenaEnemyController arenaEnemyController, BuildingRepository buildingRepository)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void StartProcessing()
		{
		}

		private void OnUpgradesComplete()
		{
		}

		private void OnResourcesComplete()
		{
		}

		private void OnAllProcessingComplete()
		{
		}
	}
}
