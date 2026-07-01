using System;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class MysteryCardShopSimulator : IDisposable
	{
		private readonly MysteryCardShopSystem _mysteryCardShopSystem;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayConfig _gameplayConfig;

		private readonly GameplayStateMachine _gameplayStateMachine;

		private bool _isProcessing;

		public MysteryCardShopSimulator(MysteryCardShopSystem mysteryCardShopSystem, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, GameplayStateMachine gameplayStateMachine)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnStateEntered(BaseGameplayState state)
		{
		}

		private void OnItemAmountChanged(InventoryItem item)
		{
		}

		private void PurchaseAllAvailableCards()
		{
		}

		private bool HasGameplayCards()
		{
			return false;
		}
	}
}
