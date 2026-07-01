using __Simulation__.Systems;

namespace __Simulation__.SimulationModules
{
	public interface ISimulationModule
	{
		void Iterate(SimulationSnapshot simulationSnapshot);
	}
}
