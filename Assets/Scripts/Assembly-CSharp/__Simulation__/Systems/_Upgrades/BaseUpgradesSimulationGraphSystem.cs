using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems._Upgrades
{
	public abstract class BaseUpgradesSimulationGraphSystem
	{
		private UIWaveSimulationGraphElement _uiWaveSimulationGraphElement;

		private UIWaveSimulationGraphView _uiWaveSimulationGraphView;

		private UpgradesSimulationGraphDataFactory _upgradesGraphDataFactory;

		public SimulationCurveGraphData CurveGraphData { get; private set; }

		public event Action<SimulationCurveGraphData> OnGraphDataChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(UIWaveSimulationGraphElement uiWaveSimulationGraphElement, UIWaveSimulationGraphView uiWaveSimulationGraphView, UpgradesSimulationGraphDataFactory upgradesGraphDataFactory)
		{
		}

		protected void BuildGraphData(GameplaySimulationSettings strategy, PowerLogType powerLogType)
		{
		}

		protected void BuildGraphData(int stageIndex, PowerLogType powerLogType)
		{
		}
	}
}
