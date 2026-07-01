using System;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class GameplayDebugSettings
	{
		public bool IsDebugMode { get; private set; }

		public float DebugTimeScale { get; private set; }

		public bool UseOverrideStage { get; private set; }

		public GameplayDebugStageSettings StageSettings { get; private set; }

		public bool UseSimulationSettings { get; private set; }

		public GameplaySimulationSettings SimulationSettings { get; private set; }

		public bool UseOverrideSeed { get; private set; }

		public int Seed { get; private set; }

		public bool SkipAnimations { get; set; }

		public bool UseMaxWaveOverride { get; private set; }

		public int MaxWaveIndex { get; private set; }

		public GameplayDebugSettings(bool isDebugMode, float debugTimeScale, bool useOverrideStage, GameplayDebugStageSettings stageSettings, bool useSimulationSettings, GameplaySimulationSettings simulationSettings, bool useOverrideSeed, int seed)
		{
		}

		public void OverrideStrategySettings(float debugTimeScale, bool useOverrideStage, GameplayDebugStageSettings stageSettings, GameplaySimulationSettings simulationSettings, bool useMaxWaveOverride, int maxWaveIndex)
		{
		}
	}
}
