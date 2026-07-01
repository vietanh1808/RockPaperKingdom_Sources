using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class CardSellSystem
	{
		private readonly BuildingPlacementHand _buildingPlacementHand;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayConfig _gameplayConfig;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		public event Action OnLastCardSelling
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public CardSellSystem(BuildingPlacementHand buildingPlacementHand, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, WaveSystem waveSystem)
		{
		}

		public void SellActiveCard()
		{
		}

		public void SellCard(BuildingUpgradeRuntime upgrade)
		{
		}
	}
}
