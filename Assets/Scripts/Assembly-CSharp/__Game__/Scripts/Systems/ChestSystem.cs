using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class ChestSystem : DirtySaveLoadProvider
	{
		private readonly ChestAvailableUnitCardProvider _chestAvailableUnitCardProvider;

		private readonly UnitCardSystem _unitCardSystem;

		public Dictionary<string, ChestItem> Items { get; }

		public event Action<ChestData> OnChestOpened
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

		public event Action<ChestRewardItem> OnChestRewardClaimed
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

		public ChestSystem(ChestAvailableUnitCardProvider chestAvailableUnitCardProvider, UnitCardSystem unitCardSystem)
		{
		}

		public bool HasGuaranteedNewItem(ChestData chestData)
		{
			return false;
		}

		public ChestRewardItem OpenChest(ChestData chestData)
		{
			return null;
		}

		public ChestItem GetChestItem(ChestData chestData)
		{
			return null;
		}

		private ChestRewardItem GetChestRewardItem(ChestData chestData)
		{
			return null;
		}

		private ChestRewardItem GetHardcodedItem(int claimedChests, ChestData chestData)
		{
			return null;
		}

		private ChestRewardItem GetGuaranteedItem(ChestData chestData)
		{
			return null;
		}

		private ChestRewardItem GetRandomItemByRarity(ChestData chestData, RarityType rarityType)
		{
			return null;
		}

		private ChestRewardItem GetRandomItem(ChestData chestData)
		{
			return null;
		}

		private int GetAmountForUnitCard(UnitCardItem unitCardItem, ChestData chestData)
		{
			return 0;
		}
	}
}
