using System.Collections.Generic;
using __Game__.Scripts.Gameplay.EnemyHint;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.Systems
{
	public class PlayerDataSaveLoadHandler : BaseSaveLoadHandler
	{
		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly EnergySystem _energySystem;

		private readonly ChestSystem _chestSystem;

		private readonly CooldownSystem _cooldownSystem;

		private readonly PlayerUpgradesSystem _playerUpgradesSystem;

		private readonly MetaQuestSystem _metaQuestSystem;

		private readonly PlayerGameplayProgressService _playerGameplayProgressService;

		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaChestSystem _arenaChestSystem;

		private readonly ArenaTicketSystem _arenaTicketSystem;

		private readonly EnemyHintRuntimeData _enemyHintRuntimeData;

		private readonly PlayerInstallTracker _playerInstallTracker;

		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		private readonly InterstitialAdTracker _interstitialAdTracker;

		public PlayerDataSaveLoadHandler(PlayerLevelSystem playerLevelSystem, EnergySystem energySystem, ChestSystem chestSystem, CooldownSystem cooldownSystem, PlayerUpgradesSystem playerUpgradesSystem, MetaQuestSystem metaQuestSystem, PlayerGameplayProgressService playerGameplayProgressService, ArenaSystem arenaSystem, ArenaChestSystem arenaChestSystem, ArenaTicketSystem arenaTicketSystem, EnemyHintRuntimeData enemyHintRuntimeData, PlayerInstallTracker playerInstallTracker, PurchaseCountsTracker purchaseCountsTracker, InterstitialAdTracker interstitialAdTracker)
		{
		}

		public override void Load()
		{
		}

		public override void Save()
		{
		}

		public override string GetDataPath()
		{
			return null;
		}

		private void LoadPlayerLevelData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadEnergyData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadChestData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadCooldownData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadPlayerUpgradesData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadMetaQuestData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadGameplayProgressData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadArenaData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadArenaChestData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadArenaTicketData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadEnemyHintData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadInstallTrackerData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadPurchaseCountsData(PlayerDataSave playerDataSave)
		{
		}

		private void LoadInterstitialAdData(PlayerDataSave playerDataSave)
		{
		}

		private Dictionary<string, int> ParseChestDictionary()
		{
			return null;
		}
	}
}
