using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class FightPreparationState : BaseGameplayState
	{
		private const float PREPARATION_DURATION = 1.5f;

		private readonly WaveSystem _waveSystem;

		private readonly WavesConfig _wavesConfig;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		public FightPreparationState(WaveSystem waveSystem, WavesConfig wavesConfig, UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void ShowWaveAnnouncement()
		{
		}
	}
}
