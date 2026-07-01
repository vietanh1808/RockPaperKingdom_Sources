using System;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class PlayerGameplayProgressTracker : IInitializable, IDisposable
	{
		private readonly PlayerGameplayProgressService _progressService;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayConfig _gameplayConfig;

		private InventoryItem _trackedItem;

		public PlayerGameplayProgressTracker(PlayerGameplayProgressService progressService, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnAmountChanged(InventoryItem item)
		{
		}
	}
}
