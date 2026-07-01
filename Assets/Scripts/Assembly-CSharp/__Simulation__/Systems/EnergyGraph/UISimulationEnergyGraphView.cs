using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.EnergyGraph
{
	public class UISimulationEnergyGraphView : BaseUISimulationGraphView
	{
		private SimulationEnergyGraphSystem _simulationGraphSystem;

		[Inject]
		private void Inject(SimulationEnergyGraphSystem simulationGraphSystem)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
