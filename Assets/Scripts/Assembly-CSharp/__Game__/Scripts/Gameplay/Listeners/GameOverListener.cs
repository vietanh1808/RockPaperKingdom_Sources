using __Game__.Scripts.Gameplay.Revive;
using __Game__.Scripts.Gameplay.StateMachine;

namespace __Game__.Scripts.Gameplay.Listeners
{
	public class GameOverListener
	{
		private readonly GameplayStateMachine _stateMachine;

		private readonly Castle _castle;

		private readonly ReviveSystem _reviveSystem;

		private readonly GameplayDebugSettings _gameplayDebugSettings;

		public GameOverListener(GameplayStateMachine stateMachine, Castle castle, ReviveSystem reviveSystem, GameplayDebugSettings gameplayDebugSettings)
		{
		}

		public void Initialize()
		{
		}

		private void OnCastleDied()
		{
		}
	}
}
