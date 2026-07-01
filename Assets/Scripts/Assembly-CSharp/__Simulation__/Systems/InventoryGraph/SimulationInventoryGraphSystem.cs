using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.InventoryGraph
{
	public class SimulationInventoryGraphSystem : BaseSimulationGraphSystem
	{
		private InventorySimulationMode _selectedMode;

		private InventoryItemSimulationBundle _selectedInventoryItem;

		public InventorySimulationMode SelectedMode
		{
			set
			{
			}
		}

		public InventoryItemSimulationBundle SelectedInventoryItemBundle
		{
			set
			{
			}
		}

		public override void Initialize()
		{
		}
	}
}
