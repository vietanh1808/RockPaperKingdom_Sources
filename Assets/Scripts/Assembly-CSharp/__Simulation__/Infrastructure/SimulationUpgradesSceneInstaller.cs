using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Simulation__.Systems._Upgrades;

namespace __Simulation__.Infrastructure
{
	public class SimulationUpgradesSceneInstaller : MonoInstaller
	{
		[SerializeField]
		private UpgradesSimulationConfig _upgradesSimulationConfig;

		[SerializeField]
		private StagesCollection _stagesCollection;

		[SerializeField]
		private UIWaveSimulationGraphView _uiWaveSimulationGraphView;

		[SerializeField]
		private UIWaveSimulationGraphElement _uiWaveSimulationGraphElement;

		[SerializeField]
		private UISimulationWaveByStageGraphView _uiSimulationWaveByStageGraphView;

		[SerializeField]
		private UISimulationChoicePanel _uiSimulationChoicePanel;

		public override void InstallBindings()
		{
		}
	}
}
