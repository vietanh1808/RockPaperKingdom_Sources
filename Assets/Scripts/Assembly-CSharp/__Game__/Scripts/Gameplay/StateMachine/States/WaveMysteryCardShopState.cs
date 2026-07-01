using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class WaveMysteryCardShopState : BaseGameplayState
	{
		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayConfig _gameplayConfig;

		private readonly MysteryCardShopSystem _mysteryCardShopSystem;

		private readonly WaveSystem _waveSystem;

		private readonly StageSystem _stageSystem;

		public WaveMysteryCardShopState(UIGameplaySceneNavigation uiGameplaySceneNavigation, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, MysteryCardShopSystem mysteryCardShopSystem, WaveSystem waveSystem, StageSystem stageSystem)
		{
		}

		public override void Enter()
		{
		}

		private void OnShopClosed()
		{
		}

		private bool IsRewardWave()
		{
			return false;
		}
	}
}
