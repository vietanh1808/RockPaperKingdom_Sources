using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules.UnitsUpgrade
{
	public class UnitsUpgradeSimulationModule : ISimulationModule
	{
		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly PlayerStatConfig _playerStatConfig;

		public UnitsUpgradeSimulationModule(HeroSystem heroSystem, UnitCardSystem unitCardSystem, PlayerStatConfig playerStatConfig)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void UnlockPendingHeroes()
		{
		}

		private void UpgradeAllHeroes(SimulationSnapshot simulationSnapshot)
		{
		}

		private void UpdateUnitsUpgradePower(SimulationSnapshot simulationSnapshot)
		{
		}

		private void UpgradeAllUnitCards(SimulationSnapshot simulationSnapshot)
		{
		}

		private void AddHeroesToSnapshot(SimulationSnapshot simulationSnapshot)
		{
		}

		private void AddUnitCardsToSnapshot(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
