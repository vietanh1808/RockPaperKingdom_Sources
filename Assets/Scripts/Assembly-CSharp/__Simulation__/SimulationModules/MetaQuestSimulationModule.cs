using __Game__.Scripts.Systems.MetaQuest;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class MetaQuestSimulationModule : ISimulationModule
	{
		private readonly MetaQuestSystem _metaQuestSystem;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		public MetaQuestSimulationModule(MetaQuestSystem metaQuestSystem, SimulationRewardSystem simulationRewardSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private static bool ShouldAutoComplete(BaseMetaQuestProcessor processor)
		{
			return false;
		}
	}
}
