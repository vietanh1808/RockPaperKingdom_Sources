using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class ChestAvailableUnitCardProvider
	{
		private readonly Dictionary<int, List<UnitCardItem>> _allUnitCardesByStage;

		private readonly Dictionary<RarityType, List<UnitCardItem>> _unlockedUnitCardesByRarity;

		private readonly Dictionary<RarityType, List<UnitCardItem>> _prioritizedUnitCardesByRarity;

		private readonly Dictionary<RarityType, List<UnitCardItem>> _chestTenthItemsByRarity;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly StageSystem _stageSystem;

		private readonly HeroSystem _heroSystem;

		public ChestAvailableUnitCardProvider(UnitCardSystem unitCardSystem, StageSystem stageSystem, HeroSystem heroSystem)
		{
		}

		public void Initialize()
		{
		}

		public UnitCardItem GetHardcodedUnitCard(UnitCardItemData hardcodedItemData)
		{
			return null;
		}

		public UnitCardItem GetPrioritizedUnitCardByRarity(RarityType rarityType)
		{
			return null;
		}

		public UnitCardItem GetPrioritizedUnitCardByRarityProbability(List<RarityProbabilityItem> rarityProbabilityItems)
		{
			return null;
		}

		public bool HasGuaranteedNewItemByRarity(RarityType rarityType)
		{
			return false;
		}

		public UnitCardItem GetPrioritizedTenthItem(List<UnitCardItemData> prioritizedTenthItems)
		{
			return null;
		}

		public UnitCardItem GetGuaranteedUnitCardByRarity(RarityType rarityType)
		{
			return null;
		}

		public UnitCardItem GetRandomRewardByRarity(RarityType rarityType)
		{
			return null;
		}

		private void SetupCollectiblesByStage()
		{
		}

		private void UpdatePrioritizedCollections()
		{
		}

		private void UpdateUnlockedCollections()
		{
		}

		private void OnUnitCardItemUnlocked(UnitCardItem unitCardItem)
		{
		}

		private void OnHeroItemUnlocked(HeroItem heroItem)
		{
		}

		private void UpdateChestTenthItems()
		{
		}

		private bool IsEligibleTenthItem(UnitCardItem unitCardItem)
		{
			return false;
		}

		private void RemoveFromPool(Dictionary<RarityType, List<UnitCardItem>> pool, UnitCardItem unitCardItem)
		{
		}

		private void AddToUnlockedUnitCardesByRarity(RarityType rarityType, UnitCardItem unitCardItem)
		{
		}

		private void AddToPrioritizedUnitCardsByRarity(RarityType rarityType, UnitCardItem unitCardItem)
		{
		}

		private UnitCardItem GetUnlockedUnitCardByRarity(RarityType rarityType)
		{
			return null;
		}

		private UnitCardItem GetRandomUnitCard()
		{
			return null;
		}
	}
}
