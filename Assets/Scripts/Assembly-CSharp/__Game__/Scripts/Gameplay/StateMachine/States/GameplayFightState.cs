using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class GameplayFightState : BaseGameplayState
	{
		private readonly UnitCountTracker _enemyUnitCountTracker;

		private readonly WaveSystem _waveSystem;

		public GameplayFightState(UnitCountTrackerFactory unitCountTrackerFactory, WaveSystem waveSystem)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnUnitCountChanged(int enemyCount)
		{
		}
	}
}
