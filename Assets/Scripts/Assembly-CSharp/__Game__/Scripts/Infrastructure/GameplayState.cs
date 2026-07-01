using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class GameplayState : BaseGameState
	{
		private readonly SceneController _sceneController;

		private readonly EnergySystem _energySystem;

		private readonly RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private readonly UITutorialTap _uiTutorialTap;

		public GameplayState(SceneController sceneController, EnergySystem energySystem, RestoreGameplayRuntimeData restoreGameplayRuntimeData, UIProjectHolder uiProjectHolder)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnSceneLoaded()
		{
		}
	}
}
