using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class RestoreState : BaseGameplayState
	{
		private readonly RestoreGameplayProgressSystem _restoreGameplayProgressSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly CameraStateController _cameraStateController;

		public RestoreState(RestoreGameplayProgressSystem restoreGameplayProgressSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, CameraStateController cameraStateController)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnContinueHandler()
		{
		}

		private void OnQuitHandler()
		{
		}
	}
}
