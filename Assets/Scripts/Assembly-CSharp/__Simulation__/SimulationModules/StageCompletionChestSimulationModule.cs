using Zenject;
using __Game__.Scripts.Systems;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class StageCompletionChestSimulationModule : ISimulationModule
	{
		private StageChestSystem _stageChestSystem;

		private SimulationRewardSystem _simulationRewardSystem;

		[Inject]
		public void Inject(StageChestSystem stageChestSystem, SimulationRewardSystem simulationRewardSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
