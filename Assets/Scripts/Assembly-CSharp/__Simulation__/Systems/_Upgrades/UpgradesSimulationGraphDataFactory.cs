using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems._Upgrades
{
	public class UpgradesSimulationGraphDataFactory
	{
		private readonly UpgradesSimulationSystem _upgradesSimulationSystem;

		public UpgradesSimulationGraphDataFactory(UpgradesSimulationSystem upgradesSimulationSystem)
		{
		}

		public SimulationCurveGraphData GetGraphData(int stageIndex, PowerLogType powerLogType, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		public SimulationCurveGraphData GetGraphData(GameplaySimulationSettings strategy, PowerLogType powerLogType, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		private SimulationCurveGraphData BuildGraphData(float maxValue, List<SimulationCurveData> curveList, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		private List<SimulationCurveData> GetCurveListByStage(int stageIndex, PowerLogType powerLogType)
		{
			return null;
		}

		private List<SimulationCurveData> GetCurveListByStrategy(GameplaySimulationSettings strategy, PowerLogType powerLogType)
		{
			return null;
		}

		private SimulationCurveData BuildCurve(string title, Color color, StageLog stageLog, PowerLogType powerLogType)
		{
			return null;
		}

		private SimulationCurveData CreateAverageCurve(List<SimulationCurveData> strategyCurves)
		{
			return null;
		}

		private float GetMaxValue(int stageIndex, PowerLogType powerLogType)
		{
			return 0f;
		}

		private float GetMaxValueByStrategy(GameplaySimulationSettings strategy, PowerLogType powerLogType)
		{
			return 0f;
		}

		private float GetMaxFromWaveLogs(StageLog stageLog, PowerLogType powerLogType, float currentMax)
		{
			return 0f;
		}

		private SimulationCurveData CreateEnemyPowerCurve(int stageIndex)
		{
			return null;
		}

		private bool HasStageData(int stageIndex)
		{
			return false;
		}

		private List<int> CalculateEnemyPowerPerWave(int stageIndex)
		{
			return null;
		}
	}
}
