using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class StageChestSystem
	{
		private readonly StageSystem _stageSystem;

		private readonly StagesCollection _stagesCollection;

		private readonly RewardSystem _rewardSystem;

		private readonly Dictionary<StageModeType, Dictionary<int, List<StageChestItem>>> _chestItemsByMode;

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

		public StageChestSystem(StageSystem stageSystem, StagesCollection stagesCollection, RewardSystem rewardSystem)
		{
		}

		public void LoadData(Dictionary<int, List<StageChestState>> chestStatesPerStage, Dictionary<int, List<StageChestState>> hardChestStatesPerStage)
		{
		}

		public void Initialize()
		{
		}

		public List<Reward> ClaimAllRewards(StageModeType modeType, int stageIndex, RewardDisplayMode displayMode)
		{
			return null;
		}

		public List<StageChestItem> GetChestsByStageIndex(StageModeType modeType, int stageIndex)
		{
			return null;
		}

		public Dictionary<int, List<StageChestState>> GetAllChestStates(StageModeType modeType)
		{
			return null;
		}

		public int GetUnlockedStageCount(StageModeType modeType)
		{
			return 0;
		}

		public bool HasUnclaimedReward(StageModeType modeType)
		{
			return false;
		}

		private void LoadModeData(StageModeType modeType, Dictionary<int, List<StageChestState>> chestStatesPerStage)
		{
		}

		private void OnStageCompleted(float completionRate)
		{
		}

		private List<StageChestItem> GetOrCreateChestItems(StageModeType modeType, int stageIndex)
		{
			return null;
		}

		private void RefreshStatesForStage(StageModeType modeType, List<StageChestItem> chestItems, int stageIndex)
		{
		}

		private void ApplySavedStates(List<StageChestItem> chestItems, List<StageChestState> savedStates)
		{
		}

		private StageChestState GetState(StageChestItem chestItem, int stageIndex, StageMode stageMode)
		{
			return default(StageChestState);
		}

		private void RefreshHasAnyUnclaimedReward()
		{
		}
	}
}
