using System.Collections.Generic;
using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules
{
	public class EquipmentCheckSimulationModule : ISimulationModule
	{
		private readonly EquipmentSystem _equipmentSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly EquipmentMergeSystem _equipmentMergeSystem;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private bool IsAvailable => false;

		public EquipmentCheckSimulationModule(EquipmentSystem equipmentSystem, FeatureUnlockConfig featureUnlockConfig, EquipmentMergeSystem equipmentMergeSystem, SimulationModuleAvailableSystem simulationModuleAvailableSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void CheckInventoryForMerge()
		{
		}

		private void CheckInventoryForEquip()
		{
		}

		private List<EquipmentItemSnapshot> GetEquipmentItemSnapshots()
		{
			return null;
		}
	}
}
