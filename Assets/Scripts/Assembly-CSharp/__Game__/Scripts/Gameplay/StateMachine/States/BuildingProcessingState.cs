using __Game__.Scripts.Common.Utils;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class BuildingProcessingState : BaseGameplayState
	{
		private const float BEFORE_PROCESSING_DELAY = 0.5f;

		private const float AFTER_PROCESSING_DELAY = 0.5f;

		private readonly CameraStateController _cameraStateController;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingUpgradeProcessor _upgradeProcessor;

		private readonly ResourceBuildingProcessor _resourceProcessor;

		private readonly MirrorBuildingProcessor _mirrorProcessor;

		private readonly GameplayDebugSettings _debugSettings;

		private readonly AnimationCompletionAwaiter<UIBuildingStatChangeDisplay> _animationAwaiter;

		public BuildingProcessingState(CameraStateController cameraStateController, BuildingRepository buildingRepository, BuildingUpgradeProcessor upgradeProcessor, ResourceBuildingProcessor resourceProcessor, MirrorBuildingProcessor mirrorProcessor, GameplayDebugSettings debugSettings)
		{
		}

		public override void Enter()
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

		private void WaitForStatAnimationsAndTransition()
		{
		}

		public override void Exit()
		{
		}

		private void TransitionToFight()
		{
		}

		private void OnCameraTransitionComplete()
		{
		}
	}
}
