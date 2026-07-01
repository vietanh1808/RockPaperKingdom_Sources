using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class AIStageGenerationContext
	{
		public GameObject GeneratedPrefab { get; private set; }

		public AIUnitConfig UnitConfig { get; private set; }

		public AIProviderConfig AIProviderConfig { get; private set; }

		public SlotGridSpawnPatternsSettings SpawnPatternsSettings { get; private set; }

		public int FirstWavePower { get; private set; }

		public int LastWavePower { get; private set; }

		public int TotalWaves { get; private set; }

		public string OutputFolder { get; private set; }

		public string PrefabName { get; private set; }

		public string StageDescription { get; private set; }

		public bool IsGenerating { get; private set; }

		public GameplayDebugStageSettings DebugStageSettings { get; private set; }
	}
}
