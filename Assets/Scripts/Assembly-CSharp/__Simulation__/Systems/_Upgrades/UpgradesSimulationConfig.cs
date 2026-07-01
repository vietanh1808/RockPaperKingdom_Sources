using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	[CreateAssetMenu(fileName = "Config_UpgradesSimulation", menuName = "Game Simulation/Upgrades Simulation Config")]
	public class UpgradesSimulationConfig : ScriptableObject
	{
		[Range(1f, 20f)]
		[SerializeField]
		private float _debugTimeScale;

		[Header("Stages")]
		[SerializeField]
		private bool _useOverrideStages;

		[SerializeField]
		private List<GameplayDebugStageSettings> _simulateStages;

		[Header("Wave Override")]
		[SerializeField]
		private bool _useMaxWaveOverride;

		[SerializeField]
		private int _maxWaveIndex;

		[Header("Strategy Groups")]
		[SerializeField]
		private List<GameplaySimulationSettingsGroup> _upgradeStrategyGroups;

		[Header("CSV Export")]
		[SerializeField]
		private string _csvExportFolderPath;

		[SerializeField]
		private string _appPath;

		public float DebugTimeScale => 0f;

		public bool UseOverrideStages => false;

		public List<GameplayDebugStageSettings> SimulateStages => null;

		public bool UseMaxWaveOverride => false;

		public int MaxWaveIndex => 0;

		public List<GameplaySimulationSettingsGroup> UpgradeStrategyGroups => null;

		public string CsvExportFolderPath => null;

		public string AppPath => null;
	}
}
