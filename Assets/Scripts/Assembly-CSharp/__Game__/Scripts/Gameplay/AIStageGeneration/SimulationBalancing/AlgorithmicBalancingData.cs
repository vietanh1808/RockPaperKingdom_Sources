using System;
using System.Collections.Generic;
using UnityEngine;
using __Simulation__.Systems._Upgrades;

namespace __Game__.Scripts.Gameplay.AIStageGeneration.SimulationBalancing
{
	[Serializable]
	public class AlgorithmicBalancingData
	{
		[SerializeField]
		private UpgradesSimulationConfig _simulationConfig;

		[Range(1f, 10f)]
		[SerializeField]
		private int _maxIterations;

		[Range(0f, 100f)]
		[SerializeField]
		private float _minHpPercent;

		[Range(0f, 100f)]
		[SerializeField]
		private float _maxHpPercent;

		[Range(0f, 100f)]
		[SerializeField]
		private float _targetHpPercent;

		private string _generationStatus;

		private int _currentIteration;

		private WaveBalancingStatus[,] _balancingGrid;

		[HideInInspector]
		[SerializeField]
		private List<WaveBalancingStatus> _serializedGrid;

		[HideInInspector]
		[SerializeField]
		private int _gridWaveCount;

		[HideInInspector]
		[SerializeField]
		private int _gridColumnCount;

		[SerializeField]
		private List<string> _iterationLogs;

		[SerializeField]
		private List<string> _iterationChanges;

		[TextArea(5, 10)]
		[SerializeField]
		private string _lastBalancingJson;
	}
}
