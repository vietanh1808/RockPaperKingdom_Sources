using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class MenuState : BaseGameState
	{
		private readonly SceneController _sceneController;

		private readonly ISaveLoadDataService _saveLoadDataService;

		private readonly SoundsConfig _soundsConfig;

		private readonly UITutorialTap _uiTutorialTap;

		public MenuNavigationPage PendingPage { get; set; }

		public MenuState(SceneController sceneController, ISaveLoadDataService saveLoadDataService, SoundsConfig soundsConfig, UIProjectHolder uiProjectHolder)
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
