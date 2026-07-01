using System.Collections.Generic;
using __Game__.Scripts.Common.Utils;
using __Game__.Scripts.Gameplay.BossChest;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class BossChestUpgradeState : BaseGameplayState
	{
		private readonly BossChestManager _bossChestManager;

		private readonly BossChestUpgradeSystem _bossChestUpgradeSystem;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly CameraStateController _cameraStateController;

		private readonly BuildingUnitSpawner _buildingUnitSpawner;

		private readonly BuildingTargetRepository _buildingTargetRepository;

		private readonly BuildingRepository _buildingRepository;

		private readonly AbilitySpawnedUnitsTracker _abilitySpawnedUnitsTracker;

		private readonly AnimationCompletionAwaiter<UIBuildingStatChangeDisplay> _animationAwaiter;

		private List<BaseGameplayUpgrade> _currentUpgrades;

		public BossChestUpgradeState(BossChestManager bossChestManager, BossChestUpgradeSystem bossChestUpgradeSystem, GameplayUpgradesSystem gameplayUpgradesSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, CameraStateController cameraStateController, BuildingUnitSpawner buildingUnitSpawner, BuildingTargetRepository buildingTargetRepository, BuildingRepository buildingRepository, AbilitySpawnedUnitsTracker abilitySpawnedUnitsTracker)
		{
		}

		public override void Enter()
		{
		}

		private void OnChestAnimationComplete()
		{
		}

		public override void Exit()
		{
		}

		private void OnUpgradesSpawned()
		{
		}

		private void OnUpgradeSelected(BaseGameplayUpgrade upgrade)
		{
		}

		private void OnPanelClosed()
		{
		}

		private void TransitionAfterAnimations()
		{
		}
	}
}
