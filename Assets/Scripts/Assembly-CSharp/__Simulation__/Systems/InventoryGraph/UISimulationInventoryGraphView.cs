using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.InventoryGraph
{
	public class UISimulationInventoryGraphView : BaseUISimulationGraphView
	{
		private SimulationInventoryGraphSystem _inventoryGraphSystem;

		[Inject]
		private void Inject(SimulationInventoryGraphSystem inventoryGraphSystem)
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
