using __Game__.Scripts.Common.Utils;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaBuildingProcessingState : BaseArenaState
	{
		private const float BEFORE_PROCESSING_DELAY = 0.5f;

		private readonly CameraStateController _cameraStateController;

		private readonly BuildingRepository _buildingRepository;

		private readonly BuildingUpgradeProcessor _upgradeProcessor;

		private readonly ResourceBuildingProcessor _resourceProcessor;

		private readonly MirrorBuildingProcessor _mirrorProcessor;

		private readonly AnimationCompletionAwaiter<UIBuildingStatChangeDisplay> _animationAwaiter;

		public ArenaBuildingProcessingState(CameraStateController cameraStateController, BuildingRepository buildingRepository, BuildingUpgradeProcessor upgradeProcessor, ResourceBuildingProcessor resourceProcessor, MirrorBuildingProcessor mirrorProcessor)
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

		private void TransitionToFight()
		{
		}

		private void OnCameraTransitionComplete()
		{
		}
	}
}
