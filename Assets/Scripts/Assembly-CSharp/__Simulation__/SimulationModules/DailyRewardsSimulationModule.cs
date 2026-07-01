using __Game__.Scripts.Systems;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class DailyRewardsSimulationModule : ISimulationModule
	{
		private readonly DailyRewardsSystem _dailyRewardsSystem;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private int _previousDay;

		private bool IsAvailable => false;

		public DailyRewardsSimulationModule(DailyRewardsSystem dailyRewardsSystem, SimulationRewardSystem simulationRewardSystem, FeatureUnlockConfig featureUnlockConfig, SimulationModuleAvailableSystem simulationModuleAvailableSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void ClaimRewardByDay(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
