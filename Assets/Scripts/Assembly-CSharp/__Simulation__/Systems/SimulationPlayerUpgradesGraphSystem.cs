using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Systems;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems
{
	public class SimulationPlayerUpgradesGraphSystem
	{
		private GameSimulationSystem _gameSimulationSystem;

		private UISimulationGraphElement _uiSimulationGraphElement;

		private UISimulationGraphView _uiSimulationGraphView;

		private PlayerUpgradesConfig _playerUpgradesConfig;

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
		public void Inject(GameSimulationSystem gameSimulationSystem, UISimulationGraphElement simulationGraphElement, UISimulationGraphView uiSimulationGraphView, PlayerUpgradesConfig playerUpgradesConfig)
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

		private void AddUnlockedUpgrades(List<SimulationCurveData> curveList)
		{
		}

		private void AddPurchasedUpgrades(List<SimulationCurveData> curveList)
		{
		}

		private int GetMaxValue()
		{
			return 0;
		}
	}
}
