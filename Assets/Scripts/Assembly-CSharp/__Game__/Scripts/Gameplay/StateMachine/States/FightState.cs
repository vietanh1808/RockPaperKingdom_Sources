using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class FightState : BaseGameplayState
	{
		private const float TRANSITION_DELAY = 0.5f;

		private readonly UnitRepository _playerUnitRepository;

		private readonly UnitRepository _enemyUnitRepository;

		private readonly UnitCountTracker _enemyUnitCountTracker;

		private readonly WaveSystem _waveSystem;

		private readonly BuildingRepository _buildingRepository;

		private readonly AssassinJumpIterator _assassinJumpIterator;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly StageSystem _stageSystem;

		public FightState(UnitRepositoryFactory unitRepositoryFactory, UnitCountTrackerFactory unitCountTrackerFactory, WaveSystem waveSystem, BuildingRepository buildingRepository, AssassinJumpIterator assassinJumpIterator, UIGameplaySceneNavigation uiGameplaySceneNavigation, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void TrackFightStep()
		{
		}

		private void ActivateAllUnits()
		{
		}

		private void OnEnemyCountChanged(int enemyCount)
		{
		}
	}
}
