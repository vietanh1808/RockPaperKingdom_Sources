using __Game__.Scripts.Gameplay.Arena.Enemy;
using __Game__.Scripts.Gameplay.Arena.UI;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaUpgradeSelectionState : BaseArenaState
	{
		private readonly ArenaUpgradesPresenter _arenaUpgradesPresenter;

		private readonly UIArenaSceneNavigation _uiArenaSceneNavigation;

		private readonly CameraStateController _cameraStateController;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly ArenaEnemyController _arenaEnemyController;

		private readonly ArenaWaveSystem _arenaWaveSystem;

		private readonly BuildingUnitSpawner _buildingUnitSpawner;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly BuildingRepository _buildingRepository;

		private readonly AbilitySpawnedUnitsTracker _abilitySpawnedUnitsTracker;

		public ArenaUpgradeSelectionState(ArenaUpgradesPresenter arenaUpgradesPresenter, UIArenaSceneNavigation uiArenaSceneNavigation, CameraStateController cameraStateController, GameplayUpgradesSystem gameplayUpgradesSystem, ArenaEnemyController arenaEnemyController, ArenaWaveSystem arenaWaveSystem, BuildingUnitSpawner buildingUnitSpawner, BuildingTargetRepository buildingTargetRepository, BuildingRepository buildingRepository, AbilitySpawnedUnitsTracker abilitySpawnedUnitsTracker)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnPlayerUpgradeApplied(BaseGameplayUpgrade upgrade, UpgradeSource source)
		{
		}

		private void OnAllUpgradesSelected()
		{
		}

		private void RespawnAllUnits()
		{
		}
	}
}
