using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_GameplayDebug", menuName = "TapHub/Configs/Gameplay Debug")]
	public class GameplayDebugConfig : ScriptableObject
	{
		[SerializeField]
		private bool _isDebugMode;

		[Range(1f, 20f)]
		[SerializeField]
		private float _debugTimeScale;

		[Header("Stage Override")]
		[SerializeField]
		private bool _overrideStage;

		[SerializeField]
		private GameplayDebugStageSettings _stageSettings;

		[Header("Simulation Settings")]
		[SerializeField]
		private bool _useSimulationSettings;

		[SerializeField]
		private GameplaySimulationSettings _gameplaySimulationSettings;

		[Header("Random Seed")]
		[SerializeField]
		private bool _useOverrideSeed;

		[SerializeField]
		private int _seed;

		private bool ShowStageOverride => false;

		private bool ShowSimulationSettings => false;

		private bool ShowOverrideSeed => false;

		public GameplayDebugSettings GetGameplayDebugSettings()
		{
			return null;
		}
	}
}
