using __Game__.Scripts.Gameplay.Arena.Enemy;
using __Game__.Scripts.Gameplay.Coins;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine.States
{
	public class ArenaCollectCoinsState : BaseArenaState
	{
		private readonly GameplayCoinObjectManager _coinObjectManager;

		private readonly ArenaStakeTokenDropSystem _arenaStakeTokenDropSystem;

		private readonly ArenaEnemyController _arenaEnemyController;

		private ArenaCollectCoinsResult _pendingResult;

		public ArenaCollectCoinsState(GameplayCoinObjectManager coinObjectManager, ArenaStakeTokenDropSystem arenaStakeTokenDropSystem, ArenaEnemyController arenaEnemyController)
		{
		}

		public void SetResult(ArenaCollectCoinsResult result)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnAllCoinsCollected()
		{
		}

		private void CompleteCollection()
		{
		}

		private void GiveEnemyShards()
		{
		}
	}
}
