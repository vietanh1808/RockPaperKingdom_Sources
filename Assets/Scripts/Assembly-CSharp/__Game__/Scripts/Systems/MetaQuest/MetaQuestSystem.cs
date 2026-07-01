using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class MetaQuestSystem
	{
		private readonly MetaQuestConfig _config;

		private readonly MetaQuestProcessorFactory _processorFactory;

		private readonly RewardSystem _rewardSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly GameAnalyticsEvents _analyticsEvents;

		private List<BaseMetaQuestData> _availableQuests;

		private int _currentQuestIndex;

		private List<string> _completedQuestGuids;

		public BaseMetaQuestProcessor ActiveProcessor { get; private set; }

		public IReadOnlyList<string> CompletedQuestGuids => null;

		public event Action<BaseMetaQuestProcessor> OnActiveProcessorChanged
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

		public MetaQuestSystem(MetaQuestConfig config, MetaQuestProcessorFactory processorFactory, RewardSystem rewardSystem, PlayerLevelSystem playerLevelSystem, GameAnalyticsEvents analyticsEvents)
		{
		}

		public void Initialize()
		{
		}

		private void OnPlayerLevelChanged()
		{
		}

		private void TryActivateFirstQuest()
		{
		}

		public void LoadData(List<string> completedQuestGuids)
		{
		}

		public List<Reward> ClaimCurrentQuest(RewardDisplayMode rewardDisplayMode)
		{
			return null;
		}

		public void ActivateQuest(BaseMetaQuestData questData)
		{
		}
	}
}
