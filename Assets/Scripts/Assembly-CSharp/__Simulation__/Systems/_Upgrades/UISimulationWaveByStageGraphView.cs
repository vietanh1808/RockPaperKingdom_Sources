using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationWaveByStageGraphView : BaseUISimulationGraphView
	{
		private UpgradesSimulationWaveByStageGraphSystem _upgradesSimulationWaveByStageGraphSystem;

		[Inject]
		private void Inject(UpgradesSimulationWaveByStageGraphSystem upgradesSimulationWaveByStageGraphSystem)
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
