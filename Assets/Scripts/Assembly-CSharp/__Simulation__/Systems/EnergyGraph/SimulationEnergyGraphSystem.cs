using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.EnergyGraph
{
	public class SimulationEnergyGraphSystem
	{
		private GameSimulationSystem _gameSimulationSystem;

		private UISimulationGraphElement _uiSimulationGraphElement;

		private UISimulationGraphView _uiSimulationGraphView;

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
		public void Inject(GameSimulationSystem gameSimulationSystem, UISimulationGraphElement simulationGraphElement, UISimulationGraphView uiSimulationGraphView)
		{
		}

		public void Initialize()
		{
		}

		private SimulationCurveGraphData GetGraphData()
		{
			return null;
		}

		private List<SimulationCurveData> GetCurveList()
		{
			return null;
		}

		private int GetMaxValue()
		{
			return 0;
		}
	}
}
