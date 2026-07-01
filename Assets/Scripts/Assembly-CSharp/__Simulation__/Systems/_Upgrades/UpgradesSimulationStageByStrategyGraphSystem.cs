using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	public class UpgradesSimulationStageByStrategyGraphSystem : BaseUpgradesSimulationGraphSystem
	{
		private readonly UpgradesSimulationConfig _upgradesSimulationConfig;

		private readonly UpgradesSimulationSystem _upgradesSimulationSystem;

		private int _strategyIndex;

		private PowerLogType _powerLogType;

		private GameplaySimulationSettings Strategy => null;

		public int StrategyIndex
		{
			set
			{
			}
		}

		public PowerLogType PowerLogType
		{
			set
			{
			}
		}

		public UpgradesSimulationStageByStrategyGraphSystem(UpgradesSimulationConfig upgradesSimulationConfig, UpgradesSimulationSystem upgradesSimulationSystem)
		{
		}

		private void Initialize()
		{
		}
	}
}
