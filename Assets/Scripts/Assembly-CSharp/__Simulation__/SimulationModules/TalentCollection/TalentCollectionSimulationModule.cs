using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules.TalentCollection
{
	public class TalentCollectionSimulationModule : ISimulationModule
	{
		private readonly TalentCollectionSystem _talentCollectionSystem;

		private readonly InventorySystem _inventorySystem;

		public TalentCollectionSimulationModule(TalentCollectionSystem talentCollectionSystem, InventorySystem inventorySystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private bool CanDrawTalent()
		{
			return false;
		}

		private void AddTalentsToSnapshot(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
