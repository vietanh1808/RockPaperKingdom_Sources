using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Arena;

namespace __Game__.Scripts.Systems
{
	public class ArenaChestSystem
	{
		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaConfig _arenaConfig;

		private readonly RewardSystem _rewardSystem;

		private readonly List<ArenaChestItem> _allChestItems;

		public int HighestRating { get; private set; }

		public bool HasAnyUnclaimedReward { get; private set; }

		public event Action OnChestStateChanged
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

		public ArenaChestSystem(ArenaSystem arenaSystem, ArenaConfig arenaConfig, RewardSystem rewardSystem)
		{
		}

		public void LoadData(int highestRating, List<StageChestState> chestStates)
		{
		}

		public void Initialize()
		{
		}

		private void HandleRatingChanged()
		{
		}

		public List<Reward> ClaimReward(ArenaChestItem chestItem)
		{
			return null;
		}

		public List<ArenaChestItem> GetChestItemsForTier(int tierIndex)
		{
			return null;
		}

		public int GetDisplayTierIndex()
		{
			return 0;
		}

		public ArenaTierData GetDisplayTier()
		{
			return null;
		}

		public int GetNextTierRequiredRating(int tierIndex)
		{
			return 0;
		}

		public List<StageChestState> GetAllChestStates()
		{
			return null;
		}

		public void ResetProgress()
		{
		}

		private void BuildAllChestItems()
		{
		}

		private void ApplySavedStates(List<StageChestState> savedStates)
		{
		}

		private void RefreshChestStates()
		{
		}

		private void RefreshHasAnyUnclaimedReward()
		{
		}
	}
}
