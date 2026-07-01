using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class TalentCollectionSystem : DirtySaveLoadProvider
	{
		private readonly TalentCollectionConfig _talentCollectionConfig;

		private readonly InventorySystem _inventorySystem;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly Dictionary<RarityType, List<TalentRuntime>> _talentsByRarity;

		private readonly List<RarityProbabilityItem> _availableRarities;

		private readonly Dictionary<BaseTalentData, TalentRuntime> _talentsByData;

		public List<TalentRuntime> Talents { get; private set; }

		public int FirstUnlockOrderIndex { get; private set; }

		public int TotalDrawCount { get; private set; }

		public bool HasAvailableTalent { get; private set; }

		public event Action<TalentRuntime> OnTalentDrawCompleted
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

		public TalentCollectionSystem(TalentCollectionConfig talentCollectionConfig, InventorySystem inventorySystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void LoadData(List<TalentRuntime> talents, int firstUnlockOrderIndex, int totalDrawCount)
		{
		}

		public void Draw()
		{
		}

		public PriceData GetCurrentPrice()
		{
			return null;
		}

		public PriceData GetCurrentSecondaryPrice()
		{
			return null;
		}

		public List<PriceData> GetCurrentPrices()
		{
			return null;
		}

		public List<BaseModifier> GetUnlockedModifiers()
		{
			return null;
		}

		public List<Reward> GetUnlockedBonusRewards()
		{
			return null;
		}

		private void InitializeCollections()
		{
		}

		private void SpendResources()
		{
		}

		private void ValidateMaxLevel(TalentRuntime talent)
		{
		}

		private int GetMaxLevelForTalent(TalentRuntime talent)
		{
			return 0;
		}

		private void RecalculateAvailableRarities()
		{
		}

		private TalentRuntime GetTalentToDraw()
		{
			return null;
		}

		private TalentRuntime GetRandomTalent()
		{
			return null;
		}

		private RarityType GetRandomRarity()
		{
			return default(RarityType);
		}
	}
}
