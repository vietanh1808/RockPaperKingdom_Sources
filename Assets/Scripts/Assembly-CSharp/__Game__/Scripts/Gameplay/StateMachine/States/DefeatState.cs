using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class DefeatState : BaseGameplayState
	{
		private readonly ISaveLoadDataService _saveLoadDataService;

		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly GameplayRewardSystem _gameplayRewardSystem;

		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly Castle _castle;

		public DefeatState(ISaveLoadDataService saveLoadDataService, StageSystem stageSystem, WaveSystem waveSystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, GameplayRewardSystem gameplayRewardSystem, TalentCollectionSystem talentCollectionSystem, Castle castle)
		{
		}

		public override void Enter()
		{
		}

		private void ClaimRewardByResult()
		{
		}
	}
}
