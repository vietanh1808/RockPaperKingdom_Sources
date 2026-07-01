using __Game__.Scripts.Systems;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class StageCompletionSimulationModule : ISimulationModule
	{
		private readonly SimulationConfig _simulationConfig;

		private readonly StageSystem _stageSystem;

		private readonly EnergySystem _energySystem;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		private float _completionPercent;

		private float _completionTimePlay;

		private bool _isVictory;

		public StageCompletionSimulationModule(SimulationConfig simulationConfig, StageSystem stageSystem, EnergySystem energySystem, SimulationRewardSystem simulationRewardSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void CalculateResult()
		{
		}

		private void CalculateDuration(SimulationSnapshot simulationSnapshot)
		{
		}

		private float CalculateStageDuration()
		{
			return 0f;
		}

		private void CollectReward()
		{
		}

		private void NotifyStageSystem()
		{
		}

		private void SetupSnapshot(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
