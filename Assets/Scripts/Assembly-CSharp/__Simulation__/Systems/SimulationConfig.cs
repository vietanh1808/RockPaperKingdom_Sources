using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Systems;
using __Simulation__.SimulationModules;
using __Simulation__.Systems.InventoryGraph;

namespace __Simulation__.Systems
{
	[CreateAssetMenu(fileName = "Config_Simulation", menuName = "Game Simulation/Simulation Config")]
	public class SimulationConfig : ScriptableObject
	{
		[SerializeField]
		private TimeData _simulationDuration;

		[Header("Time")]
		[SerializeField]
		private float _realTimeMultiplier;

		[SerializeField]
		private float _waveDuration;

		[SerializeField]
		private float _menuTimeAfterStage;

		[SerializeField]
		private TimeData _delayBetweenSessions;

		[SerializeField]
		private List<DailySessionConfig> _dailySessionConfigs;

		[Header("Stage Completion")]
		[SerializeField]
		private List<StageCompletionPattern> _initialStageCompletionPattern;

		[SerializeField]
		private List<StageCompletionPattern> _loopStageCompletionPattern;

		[Header("Inventory")]
		[SerializeField]
		private List<InventoryItemSimulationBundle> _simulationItemBundles;

		[Header("Experience")]
		[SerializeField]
		private InventoryItemData _experienceItemData;

		[Header("Modules")]
		[SerializeField]
		private List<BaseSimulationModuleHolder> _simulationModuleHolders;

		[Header("CSV Export")]
		[SerializeField]
		private SimulationCsvExportConfig _csvExportConfig;

		public TimeData SimulationDuration => default(TimeData);

		public float RealTimeMultiplier => 0f;

		public float WaveDuration => 0f;

		public float MenuTimeAfterStage => 0f;

		public TimeData DelayBetweenSessions => default(TimeData);

		public List<DailySessionConfig> DailySessionConfigs => null;

		public List<InventoryItemSimulationBundle> SimulationItemBundles => null;

		public InventoryItemData ExperienceItemData => null;

		public List<BaseSimulationModuleHolder> SimulationModuleHolders => null;

		public SimulationCsvExportConfig CsvExportConfig => null;

		public DailySessionConfig GetDailySessionConfig(int dayIndex)
		{
			return null;
		}

		public StageCompletionPattern GetPattern(int levelIndex)
		{
			return null;
		}
	}
}
