using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Systems
{
	public class FeatureUnlockSystem
	{
		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly DailyRewardsSystem _dailyRewardsSystem;

		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		private readonly DailyStreakQuestSystem _dailyStreakQuestSystem;

		private readonly HeroSystem _heroSystem;

		private readonly ArenaSystem _arenaSystem;

		private readonly MenuTutorialSystem _menuTutorialSystem;

		private readonly DebuggerSystem _debuggerSystem;

		private readonly Dictionary<string, IFeatureUnlockSystem> _featureUnlockSystems;

		private readonly List<FeatureItem> _pendingUnlockFeatures;

		public List<string> UnlockedFeatureGuids;

		public Dictionary<string, FeatureItem> FeatureItems { get; }

		public event Action OnInitialized
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

		public event Action<FeatureItem> OnPendingUnlockFeatureAdded
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

		public FeatureUnlockSystem(FeatureUnlockConfig featureUnlockConfig, DailyRewardsSystem dailyRewardsSystem, PatrolRewardsSystem patrolRewardsSystem, DailyStreakQuestSystem dailyStreakQuestSystem, HeroSystem heroSystem, ArenaSystem arenaSystem, MenuTutorialSystem menuTutorialSystem, DebuggerSystem debuggerSystem)
		{
		}

		public void Initialize()
		{
		}

		public void UnlockFeature(FeatureItem featureItem)
		{
		}

		public void AddPendingUnlockFeature(FeatureItem featureItem)
		{
		}

		public FeatureItem GetFeatureItem(string guid)
		{
			return null;
		}

		public List<FeatureItem> GetPendingUnlockFeatures()
		{
			return null;
		}

		private void InitFeatureLists()
		{
		}

		private void InitFeatureUnlockSystems()
		{
		}

		private void InitFeatureUnlockSystem(IFeatureUnlockSystem featureSystem, FeatureItemData featureItemData)
		{
		}

		private void TryUnlockFeatureSystem(FeatureItem featureItem)
		{
		}

		private void AddPendingUnlockTutorial(FeatureItem featureItem)
		{
		}

		private bool GetUnlockedStatus(FeatureItemData featureItemData)
		{
			return false;
		}
	}
}
