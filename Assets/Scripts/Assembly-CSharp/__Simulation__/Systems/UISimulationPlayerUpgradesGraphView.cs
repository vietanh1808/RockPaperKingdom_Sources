using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems
{
	public class UISimulationPlayerUpgradesGraphView : BaseUISimulationGraphView
	{
		private SimulationPlayerUpgradesGraphSystem _playerUpgradesGraphSystem;

		[Inject]
		private void Inject(SimulationPlayerUpgradesGraphSystem playerUpgradesGraphSystem)
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
