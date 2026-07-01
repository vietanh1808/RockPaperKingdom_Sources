using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules
{
	public class EquipmentUpgradeSimulationModule : ISimulationModule
	{
		private readonly EquipmentSystem _equipmentSystem;

		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private bool IsFeatureUnlocked => false;

		public EquipmentUpgradeSimulationModule(EquipmentSystem equipmentSystem, FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
