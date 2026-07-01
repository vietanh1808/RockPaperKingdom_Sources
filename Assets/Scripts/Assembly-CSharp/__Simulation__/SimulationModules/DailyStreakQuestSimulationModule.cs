using System.Collections.Generic;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class DailyStreakQuestSimulationModule : ISimulationModule
	{
		private readonly DailyStreakQuestConfig _config;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private readonly HashSet<string> _claimedQuestGuids;

		private readonly HashSet<int> _claimedMilestoneIndices;

		private bool _isStarted;

		private int _eventStartDay;

		private int _lastClaimedEventDayIndex;

		private int _totalPoints;

		private bool IsAvailable => false;

		public DailyStreakQuestSimulationModule(DailyStreakQuestConfig config, SimulationRewardSystem simulationRewardSystem, FeatureUnlockConfig featureUnlockConfig, SimulationModuleAvailableSystem simulationModuleAvailableSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void ClaimQuestsForDay(int dayIndex)
		{
		}

		private void TryClaimMilestones()
		{
		}
	}
}
