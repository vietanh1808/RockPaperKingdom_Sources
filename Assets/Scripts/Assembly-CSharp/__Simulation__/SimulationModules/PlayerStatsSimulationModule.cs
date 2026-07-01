using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules
{
	public class PlayerStatsSimulationModule : ISimulationModule
	{
		private readonly PlayerStaticStatsRepository _playerStaticStatsRepository;

		public PlayerStatsSimulationModule(PlayerStaticStatsRepository playerStaticStatsRepository)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
