using System.Collections.Generic;
using __Game__.Scripts.Gameplay.Arena.UI;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaEndState : BaseArenaState
	{
		private readonly UIArenaSceneNavigation _uiArenaSceneNavigation;

		private readonly GameStateMachine _gameStateMachine;

		private readonly ArenaSystem _arenaSystem;

		private readonly GameplayRewardSystem _gameplayRewardSystem;

		private readonly ISaveLoadDataService _saveLoadDataService;

		public ArenaMatchOutcome Outcome { get; private set; }

		public ArenaEndState(UIArenaSceneNavigation uiArenaSceneNavigation, GameStateMachine gameStateMachine, ArenaSystem arenaSystem, GameplayRewardSystem gameplayRewardSystem, ISaveLoadDataService saveLoadDataService)
		{
		}

		public void SetResult(ArenaMatchOutcome outcome)
		{
		}

		public override void Enter()
		{
		}

		private List<Reward> GetRewardsForOutcome(ArenaTierData tier)
		{
			return null;
		}

		private void OnContinue()
		{
		}
	}
}
