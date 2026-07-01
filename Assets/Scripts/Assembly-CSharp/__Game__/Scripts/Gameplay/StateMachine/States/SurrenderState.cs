using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class SurrenderState : BaseGameplayState
	{
		private readonly ISaveLoadDataService _saveLoadDataService;

		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly GameStateMachine _gameStateMachine;

		private readonly Castle _castle;

		public SurrenderState(ISaveLoadDataService saveLoadDataService, StageSystem stageSystem, WaveSystem waveSystem, GameStateMachine gameStateMachine, Castle castle)
		{
		}

		public override void Enter()
		{
		}
	}
}
