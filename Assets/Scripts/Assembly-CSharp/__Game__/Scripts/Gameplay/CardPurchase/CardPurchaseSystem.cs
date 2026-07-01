using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.CardPurchase
{
	public class CardPurchaseSystem
	{
		private readonly CardPurchaseConfig _config;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private int _currentPrice;

		public int CurrentPrice => 0;

		public InventoryItemData PriceItemData => null;

		public event Action<int> OnPriceChanged
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

		public CardPurchaseSystem(CardPurchaseConfig config, GameplayInventorySystem gameplayInventorySystem, GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		public bool CanPurchase()
		{
			return false;
		}

		public void Purchase()
		{
		}
	}
}
