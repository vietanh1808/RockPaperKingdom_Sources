using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.MysteryCardShop
{
	public class MysteryCardShopSystem
	{
		private const int CARDS_COUNT = 5;

		private const int MAX_REWARDED_ITEMS = 4;

		private readonly GameplayConfig _config;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly MysteryCardShopConfig _shopConfig;

		private readonly MysteryCardShopRuntimeData _runtimeData;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly List<AddBuildingUpgrade> _generatedCards;

		private readonly HashSet<int> _purchasedIndices;

		private List<BaseGameplayUpgrade> _preferredPool;

		private List<BaseGameplayUpgrade> _preferredLockedPool;

		public int CardsCount => 0;

		public IReadOnlyList<AddBuildingUpgrade> GeneratedCards => null;

		public IReadOnlyCollection<int> PurchasedIndices => null;

		public InventoryItemData CurrencyItemData => null;

		public bool HasGeneratedCards => false;

		public bool CanPurchaseAny => false;

		public bool IsFirstTimeShop => false;

		public event Action<int> OnCardPurchased
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

		public event Action<int> OnRvCardPurchased
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

		public MysteryCardShopSystem(GameplayConfig config, GameplayInventorySystem gameplayInventorySystem, GameplayUpgradesSystem gameplayUpgradesSystem, MysteryCardShopConfig shopConfig, MysteryCardShopRuntimeData runtimeData, UnitCardSystem unitCardSystem)
		{
		}

		public void GenerateCardsIfNeeded()
		{
		}

		public AddBuildingUpgrade GenerateCardAtIndex(int index)
		{
			return null;
		}

		public AddBuildingUpgrade GenerateRvCardAtIndex(int index)
		{
			return null;
		}

		public void ResetCards()
		{
		}

		public bool CanPurchase(int index)
		{
			return false;
		}

		public bool IsPurchased(int index)
		{
			return false;
		}

		public void Purchase(int index)
		{
		}

		public void PurchaseRvCard(int index)
		{
		}

		public int GetCurrencyBalance()
		{
			return 0;
		}

		public InventoryItem GetCurrencyItem()
		{
			return null;
		}

		public bool IsUpgradeOutsideAvailablePool(AddBuildingUpgrade upgrade)
		{
			return false;
		}

		private void ClampCurrency()
		{
		}

		private void InitializeCardSlots()
		{
		}

		private AddBuildingUpgrade ResolveUpgradeForIndex()
		{
			return null;
		}

		private AddBuildingUpgrade ResolvePredefinedUpgrade()
		{
			return null;
		}

		private AddBuildingUpgrade PickFromPreferredLockedPool()
		{
			return null;
		}

		private AddBuildingUpgrade PickFromPreferredPool()
		{
			return null;
		}

		private List<BaseGameplayUpgrade> BuildPreferredLockedPool()
		{
			return null;
		}
	}
}
