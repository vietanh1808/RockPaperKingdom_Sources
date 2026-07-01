using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Systems;
using __Simulation__.Systems.InventoryGraph;

namespace __Simulation__.Systems.SimulationCurve
{
	public abstract class BaseSimulationGraphSystem
	{
		protected SimulationConfig SimulationConfig;

		private SimulationGraphDataFactory _graphDataFactory;

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
		public void Inject(SimulationConfig simulationConfig, SimulationGraphDataFactory graphDataFactory, UISimulationGraphElement simulationGraphElement, UISimulationGraphView uiSimulationGraphView)
		{
		}

		public abstract void Initialize();

		protected void BuildGraphData(InventorySimulationMode mode, InventoryItemSimulationBundle itemBundle)
		{
		}

		protected void BuildGraphData(InventorySimulationMode mode, InventoryItemData inventoryItemData)
		{
		}
	}
}
