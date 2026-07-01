using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.Systems.DailyStreakQuest
{
	public class DailyStreakQuestSystem : IFeatureUnlockSystem
	{
		private const string COOLDOWN_GUID = "DailyStreakQuestCooldown";

		private readonly DailyStreakQuestConfig _config;

		private readonly MetaQuestProcessorFactory _processorFactory;

		private readonly RewardSystem _rewardSystem;

		private readonly CooldownSystem _cooldownSystem;

		private readonly Dictionary<string, BaseMetaQuestProcessor> _activeProcessors;

		private DateTime _eventStartDate;

		private List<string> _completedQuestGuids;

		private List<int> _claimedMilestoneIndices;

		private int _totalPoints;

		private int _lastActivatedDayCount;

		private Dictionary<string, int> _questCounters;

		public CooldownListener Cooldown { get; }

		public DateTime EventStartDate => default(DateTime);

		public int DayCount => 0;

		public int TotalPoints => 0;

		public IReadOnlyList<string> CompletedQuestGuids => null;

		public IReadOnlyList<int> ClaimedMilestoneIndices => null;

		public IReadOnlyDictionary<string, int> QuestCounters => null;

		public bool IsUnlocked { get; private set; }

		public bool IsEventActive => false;

		public int CurrentDayIndex => 0;

		public int PointsPerQuest => 0;

		public IReadOnlyList<PointsMilestoneData> MilestoneRewards => null;

		public event Action OnEventStateChanged
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

		public event Action OnQuestCompleted
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

		public event Action OnPointsChanged
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

		public event Action OnMilestoneClaimed
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

		public DailyStreakQuestSystem(DailyStreakQuestConfig config, MetaQuestProcessorFactory processorFactory, RewardSystem rewardSystem, CooldownSystem cooldownSystem)
		{
		}

		public void Initialize()
		{
		}

		public void UnlockFeature(bool isFirstUnlock)
		{
		}

		public void LoadData(DailyStreakQuestSave save)
		{
		}

		public int GetCounter(string guid)
		{
			return 0;
		}

		public void IncrementCounter(string guid, int amount = 1)
		{
		}

		public int GetUnlockedDayCount()
		{
			return 0;
		}

		public bool IsDayUnlocked(int dayIndex)
		{
			return false;
		}

		public bool HasAnyClaimable()
		{
			return false;
		}

		public bool HasDayClaimableQuest(int dayIndex)
		{
			return false;
		}

		public List<BaseMetaQuestData> GetQuestsForDay(int dayIndex)
		{
			return null;
		}

		public BaseMetaQuestProcessor GetProcessor(BaseMetaQuestData questData)
		{
			return null;
		}

		public bool IsQuestCompleted(BaseMetaQuestData questData)
		{
			return false;
		}

		public bool IsQuestReadyToClaim(BaseMetaQuestData questData)
		{
			return false;
		}

		public void ClaimQuest(BaseMetaQuestData questData)
		{
		}

		public bool IsMilestoneClaimable(int milestoneIndex)
		{
			return false;
		}

		public bool IsMilestoneClaimed(int milestoneIndex)
		{
			return false;
		}

		public void ClaimMilestone(int milestoneIndex)
		{
		}

		public TimeSpan GetTimeUntilNextDay()
		{
			return default(TimeSpan);
		}

		public TimeSpan GetTimeUntilEventEnd()
		{
			return default(TimeSpan);
		}

		public void ActivateNewlyUnlockedProcessors()
		{
		}

		private void StartEvent()
		{
		}

		private void OnCooldownStatusChanged(bool isActive)
		{
		}

		private void ActivateAllUnlockedProcessors()
		{
		}

		private void ActivateProcessor(BaseMetaQuestData questData)
		{
		}

		private void DeactivateProcessor(string guid)
		{
		}

		private void DeactivateAllProcessors()
		{
		}

		private int GetElapsedDays()
		{
			return 0;
		}
	}
}
