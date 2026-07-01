using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay.AIStageGeneration.SimulationBalancing;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[CreateAssetMenu(fileName = "AIStageGenerationData_", menuName = "TapHub/AI/AI Stage Generation Data")]
	public class AIStageGenerationData : ScriptableObject
	{
		[SerializeField]
		private AIProviderConfig _aiProviderConfig;

		[SerializeField]
		private SlotGridSpawnPatternsSettings _spawnPatternsSettings;

		[SerializeField]
		private AIUnitConfig _unitConfig;

		[SerializeField]
		private int _totalWaves;

		[Min(1f)]
		[SerializeField]
		private int _firstWavePower;

		[Min(1f)]
		[SerializeField]
		private int _lastWavePower;

		[TextArea(5, 10)]
		[SerializeField]
		private string _stageDescription;

		[SerializeField]
		private string _outputFolder;

		[SerializeField]
		private string _prefabName;

		[SerializeField]
		private GameObject _generatedPrefab;

		[SerializeField]
		private GameplayDebugStageSettings _debugStageSettings;

		[SerializeField]
		private AIGeneratedOutputData _generatedOutputData;

		[SerializeField]
		private AIPowerModificationData _powerModificationData;

		[SerializeField]
		private AIPromptModificationData _promptModificationData;

		[SerializeField]
		private AISimulationBalancingData _simulationBalancingData;

		[SerializeField]
		private AlgorithmicBalancingData _algorithmicBalancingData;

		public AIUnitConfig UnitConfig => null;

		private static IEnumerable<int> GetWaveOptions()
		{
			return null;
		}
	}
}
