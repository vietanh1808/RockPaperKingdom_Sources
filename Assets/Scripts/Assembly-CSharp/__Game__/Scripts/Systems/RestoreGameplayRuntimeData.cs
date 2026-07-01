using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class RestoreGameplayRuntimeData
	{
		public StageModeType CurrentModeType { get; private set; }

		public int CurrentStageIndex { get; private set; }

		public float RuntimeTimePlay { get; private set; }

		public int WaveIndex { get; private set; }

		public int GameplayLevelIndex { get; private set; }

		public int GameplayCurrentExperience { get; private set; }

		public List<string> AppliedUpgrades { get; private set; }

		public List<string> PendingBuildingGuids { get; private set; }

		public List<BuildingSaveData> PlacedBuildings { get; private set; }

		public List<ExpandedSlotSaveData> ExpandedSlots { get; private set; }

		public Dictionary<string, int> InventoryItems { get; private set; }

		public float CastleCurrentHP { get; private set; }

		public List<SharedStatSaveData> UnitStatModifications { get; private set; }

		public List<SharedStatSaveData> AbilityStatModifications { get; private set; }

		public List<DamageStatsSaveData> DamageStats { get; private set; }

		public bool CanRestoreProgress { get; private set; }

		public void SetupData(StageModeType modeType, int stageIndex, float runtimeTimePlay, int waveIndex, int level, int currentExperience, List<string> upgrades, List<string> pendingBuildingGuids, List<BuildingSaveData> placedBuildings, List<ExpandedSlotSaveData> expandedSlots, Dictionary<string, int> inventoryItems, float castleCurrentHP, List<SharedStatSaveData> unitStatModifications, List<SharedStatSaveData> abilityStatModifications, List<DamageStatsSaveData> damageStats)
		{
		}

		public void ClearData()
		{
		}

		public void ValidateRestoreAvailability()
		{
		}
	}
}
