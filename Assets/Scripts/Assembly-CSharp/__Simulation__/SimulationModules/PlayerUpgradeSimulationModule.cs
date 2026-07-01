using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules
{
	public class PlayerUpgradeSimulationModule : ISimulationModule
	{
		private readonly PlayerUpgradesSystem _playerUpgradesSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly SimulationModuleAvailableSystem _simulationModuleAvailableSystem;

		private bool IsAvailable => false;

		public PlayerUpgradeSimulationModule(PlayerUpgradesSystem playerUpgradesSystem, FeatureUnlockConfig featureUnlockConfig, SimulationModuleAvailableSystem simulationModuleAvailableSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void UpdatePlayerUpgrades(SimulationSnapshot simulationSnapshot)
		{
		}

		private void UpdatePlayerUpgradeInfo(SimulationSnapshot simulationSnapshot)
		{
		}

		private void SpendByUpgrade(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
