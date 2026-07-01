using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Systems;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems.PlayerStatsGraph
{
	public class SimulationPlayerStatsGraphSystem
	{
		private const float MULTIPLIER_TO_PERCENT = 100f;

		private GameSimulationSystem _gameSimulationSystem;

		private UISimulationGraphView _uiSimulationGraphView;

		private UISimulationGraphElement _uiSimulationGraphElement;

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
		private void Inject(GameSimulationSystem gameSimulationSystem, UISimulationGraphView uiSimulationGraphView, UISimulationGraphElement simulationGraphElement)
		{
		}

		public void Initialize()
		{
		}

		public void BuildTotalPowerGraphData()
		{
		}

		public void BuildPlayerStatGraphData(PlayerStatType selectedPlayerStatType)
		{
		}

		public void BuildHpMultiplierGraphData()
		{
		}

		public void BuildDmgMultiplierGraphData()
		{
		}

		private SimulationCurveGraphData GetGraphData(List<float> values, string title)
		{
			return null;
		}

		private SimulationCurveGraphData GetMultiplierGraphData(Func<SimulationSnapshot, Dictionary<string, float>> getMultipliersBySource)
		{
			return null;
		}

		private List<float> GetPlayerStatValues(PlayerStatType selectedPlayerStatType)
		{
			return null;
		}

		private List<float> GetTotalPowerValues()
		{
			return null;
		}

		private List<string> GetSourceNames(Func<SimulationSnapshot, Dictionary<string, float>> getMultipliersBySource)
		{
			return null;
		}

		private List<SimulationCurveData> GetMultiplierCurveList(Func<SimulationSnapshot, Dictionary<string, float>> getMultipliersBySource, List<string> sourceNames)
		{
			return null;
		}

		private SimulationCurveData GetTotalMultiplierCurve(Func<SimulationSnapshot, Dictionary<string, float>> getMultipliersBySource)
		{
			return null;
		}

		private float GetMaxValue(List<float> values)
		{
			return 0f;
		}

		private float GetMaxValue(List<SimulationCurveData> curveList)
		{
			return 0f;
		}

		private List<SimulationCurveData> GetCurveList(List<float> values, string title)
		{
			return null;
		}
	}
}
