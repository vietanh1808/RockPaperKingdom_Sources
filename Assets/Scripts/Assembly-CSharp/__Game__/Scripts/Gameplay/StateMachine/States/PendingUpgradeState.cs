using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class PendingUpgradeState : BaseGameplayState
	{
		private readonly GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly CameraStateController _cameraStateController;

		private readonly BuildingUnitSpawner _buildingUnitSpawner;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly BuildingRepository _buildingRepository;

		private readonly AbilitySpawnedUnitsTracker _abilitySpawnedUnitsTracker;

		public PendingUpgradeState(GameplayUpgradesPresenter gameplayUpgradesPresenter, UIGameplaySceneNavigation uiGameplaySceneNavigation, CameraStateController cameraStateController, BuildingUnitSpawner buildingUnitSpawner, BuildingTargetRepository buildingTargetRepository, BuildingRepository buildingRepository, AbilitySpawnedUnitsTracker abilitySpawnedUnitsTracker)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnUpgradesSpawned()
		{
		}

		private void PrepareForBuildingPhase()
		{
		}

		private void OnUpgradesPanelClosed()
		{
		}
	}
}
