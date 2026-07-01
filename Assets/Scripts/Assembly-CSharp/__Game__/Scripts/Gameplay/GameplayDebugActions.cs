using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayDebugActions : ITickable
	{
		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		[Inject]
		private void Inject(GameplayUpgradesPresenter gameplayUpgradesPresenter)
		{
		}

		public void Tick()
		{
		}
	}
}
