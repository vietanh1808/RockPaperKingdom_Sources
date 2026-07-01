using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class VictoryState : BaseGameplayState
	{
		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly GameplayRewardSystem _gameplayRewardSystem;

		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly Castle _castle;

		public VictoryState(StageSystem stageSystem, WaveSystem waveSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, GameplayRewardSystem gameplayRewardSystem, TalentCollectionSystem talentCollectionSystem, Castle castle)
		{
		}

		public override void Enter()
		{
		}

		private void ShowConfetti()
		{
		}

		private void SetupPauseAndShowVictory()
		{
		}

		private void SetupPause()
		{
		}

		private void StageFinished()
		{
		}
	}
}
