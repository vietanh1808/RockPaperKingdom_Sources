using System.Collections.Generic;

namespace __BattleSimulation__.Scripts
{
	public class BattleSimulationSystem
	{
		private const string PREFS_KEY = "BattleSimulationData";

		private readonly BattleSimulationConfig _battleSimulationConfig;

		private bool _isLoading;

		public Dictionary<UnitBattleSimulationData, int> AttackerUnitsAmount { get; }

		public Dictionary<UnitBattleSimulationData, int> DefenderUnitsAmount { get; }

		public Dictionary<UnitBattleSimulationData, UnitBattleSimulationStats> UnitStats { get; }

		public float TimeScale { get; private set; }

		public BattleSimulationSystem(BattleSimulationConfig battleSimulationConfig)
		{
		}

		public void Initialize()
		{
		}

		public void SetTimeScale(float value)
		{
		}

		public void SaveAllData()
		{
		}

		private void SetupStorageData()
		{
		}

		private void SetupConfigData()
		{
		}

		private UnitBattleSimulationStats CreateDefaultStats(UnitBattleSimulationData unitSimulationData)
		{
			return null;
		}

		private bool InitializeMissingStatsFromData(UnitBattleSimulationStats stats, UnitBattleSimulationData unitSimulationData)
		{
			return false;
		}

		private void InitializeStatsFromData(UnitBattleSimulationStats stats, UnitBattleSimulationData unitSimulationData)
		{
		}
	}
}
