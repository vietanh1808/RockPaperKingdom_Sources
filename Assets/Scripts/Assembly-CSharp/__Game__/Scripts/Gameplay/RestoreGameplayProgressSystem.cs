using System;
using System.Collections.Generic;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class RestoreGameplayProgressSystem : IDisposable
	{
		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private readonly GameplayLevelSystem _gameplayLevelSystem;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private readonly BuildingPlacementSystem _buildingPlacementSystem;

		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly Castle _castle;

		private readonly GameplayUpgradeCollection _gameplayUpgradeCollection;

		private readonly SharedUnitRepository _sharedUnitRepository;

		private readonly BuildingDamageTracker _buildingDamageTracker;

		private readonly List<string> _appliedUpgrades;

		public RestoreGameplayProgressSystem(StageSystem stageSystem, WaveSystem waveSystem, GameplayLevelSystem gameplayLevelSystem, GameplayUpgradesSystem gameplayUpgradesSystem, RestoreGameplayRuntimeData restoreGameplayRuntimeData, BuildingPlacementSystem buildingPlacementSystem, GameplayInventorySystem gameplayInventorySystem, Castle castle, GameplayUpgradeCollection gameplayUpgradeCollection, SharedUnitRepository sharedUnitRepository, BuildingDamageTracker buildingDamageTracker)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void SaveCurrentProgress()
		{
		}

		public void RestoreProgress()
		{
		}

		private void RestoreAppliedUpgrades()
		{
		}

		private void RestoreExpandedSlots()
		{
		}

		private void RestorePlacedBuildings()
		{
		}

		private void RestorePendingBuildings()
		{
		}

		private void RestoreInventory()
		{
		}

		private void RestoreCastleHealth()
		{
		}

		private void RestoreSharedStats()
		{
		}

		private void RestoreEmptyNeighborBonusTrackers()
		{
		}

		private void RestoreDamageStats()
		{
		}

		private void RestoreWaveAndLevel()
		{
		}

		private void OnUpgradeApplied(BaseGameplayUpgrade upgrade, UpgradeSource source)
		{
		}

		private List<SharedStatSaveData> CollectUnitStatModifications()
		{
			return null;
		}

		private List<SharedStatSaveData> CollectAbilityStatModifications()
		{
			return null;
		}

		private void OnStageFinished(float completionRate)
		{
		}
	}
}
