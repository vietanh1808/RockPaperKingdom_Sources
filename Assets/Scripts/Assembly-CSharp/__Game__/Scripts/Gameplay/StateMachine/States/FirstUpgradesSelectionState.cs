using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class FirstUpgradesSelectionState : BaseGameplayState
	{
		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly StageSystem _stageSystem;

		private readonly CameraStateController _cameraStateController;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		public FirstUpgradesSelectionState(GameplayUpgradesSystem gameplayUpgradesSystem, StageSystem stageSystem, CameraStateController cameraStateController, UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}
	}
}
