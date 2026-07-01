using __Game__.Scripts.Systems;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class PatrolRewardsSimulationModule : ISimulationModule
	{
		private readonly PatrolRewardsSystem _patrolRewardsSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private int _previousDay;

		private bool IsAvailable => false;

		public PatrolRewardsSimulationModule(PatrolRewardsSystem patrolRewardsSystem, FeatureUnlockConfig featureUnlockConfig, SimulationRewardSystem simulationRewardSystem, SimulationModuleAvailableSystem simulationModuleAvailableSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void ClaimRewards()
		{
		}
	}
}
