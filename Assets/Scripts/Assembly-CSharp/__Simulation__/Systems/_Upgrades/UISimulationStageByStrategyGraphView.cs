using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationStageByStrategyGraphView : BaseUISimulationGraphView
	{
		private UpgradesSimulationStageByStrategyGraphSystem _upgradesSimulationStageByStrategyGraphSystem;

		[Inject]
		private void Inject(UpgradesSimulationStageByStrategyGraphSystem upgradesSimulationStageByStrategyGraphSystem)
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
