using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.PlayerStatsGraph
{
	public class UISimulationPlayerStatsGraphView : BaseUISimulationGraphView
	{
		private SimulationPlayerStatsGraphSystem _playerStatsGraphSystem;

		[Inject]
		private void Inject(SimulationPlayerStatsGraphSystem playerStatsGraphSystem)
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
