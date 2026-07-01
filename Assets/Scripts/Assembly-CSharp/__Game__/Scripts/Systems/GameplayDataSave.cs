using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class GameplayDataSave
	{
		public StageModeType CurrentModeType;

		public int CurrentStageIndex;

		public float RuntimeTimePlay;

		public int WaveIndex;

		public int GameplayLevelIndex;

		public int GameplayCurrentExperience;

		public int ManaPoints;

		public List<string> AppliedUpgrades;

		public List<string> PendingBuildingGuids;

		public List<BuildingSaveData> PlacedBuildings;

		public List<ExpandedSlotSaveData> ExpandedSlots;

		public Dictionary<string, int> InventoryItems;

		public float CastleCurrentHP;

		public List<SharedStatSaveData> UnitStatModifications;

		public List<SharedStatSaveData> AbilityStatModifications;

		public List<DamageStatsSaveData> DamageStats;

		public List<string> CompletedTutorials;

		public bool ManaBoxHasBeenOpened;
	}
}
