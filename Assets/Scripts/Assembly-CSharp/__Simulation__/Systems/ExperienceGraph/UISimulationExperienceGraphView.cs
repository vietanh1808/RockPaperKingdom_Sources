using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.ExperienceGraph
{
	public class UISimulationExperienceGraphView : BaseUISimulationGraphView
	{
		private SimulationExperienceGraphSystem _experienceGraphSystem;

		[Inject]
		private void Inject(SimulationExperienceGraphSystem experienceGraphSystem)
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
