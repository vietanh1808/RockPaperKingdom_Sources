using __Game__.Scripts.Systems;
using __Simulation__.Systems;
using __Simulation__.Systems.SimulationReward;

namespace __Simulation__.SimulationModules
{
	public class OpenChestSimulationModule : ISimulationModule
	{
		private readonly OpenChestModuleConfig _openChestModuleConfig;

		private readonly ChestSystem _chestSystem;

		private readonly InventorySystem _inventorySystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly UnitCardConfig _unitCardConfig;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private readonly SimulationRewardSystem _simulationRewardSystem;

		private bool IsAvailable => false;

		public OpenChestSimulationModule(OpenChestModuleConfig openChestModuleConfig, ChestSystem chestSystem, InventorySystem inventorySystem, UnitCardSystem unitCardSystem, UnitCardConfig unitCardConfig, FeatureUnlockConfig featureUnlockConfig, SimulationModuleAvailableSystem simulationModuleAvailableSystem, SimulationRewardSystem simulationRewardSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void ChestCheck(SimulationSnapshot simulationSnapshot, ChestData chestData)
		{
		}

		private void ClaimUnitCardUnlockReward(string guid)
		{
		}

		private void SpendItem(SimulationSnapshot simulationSnapshot, PriceData priceItemAmount)
		{
		}
	}
}
