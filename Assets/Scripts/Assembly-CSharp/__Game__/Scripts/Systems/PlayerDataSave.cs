using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PlayerDataSave
	{
		public int PlayerLevel;

		public int PlayerExperience;

		public int PlayerUpgradeIndex;

		public DateTime LastEnergyRecoveryTime;

		public int EnergyAmount;

		public Dictionary<string, int> ChestClaimCounter;

		public Dictionary<string, DateTime> CooldownRecoveryTime;

		public List<string> CompletedMetaQuestGuids;

		public bool IsGameplayCoinsReceivedOnce;

		public int ArenaRating;

		public int ArenaHighestRating;

		public List<StageChestState> ArenaChestStates;

		public int ArenaFightCount;

		public DateTime LastArenaTicketRecoverTime;

		public int ArenaTicketAmount;

		public List<string> SeenEnemyHintGuids;

		public DateTime InstallDate;

		public string InstallVersion;

		public Dictionary<string, int> PurchaseCounts;

		public int InterstitialWinCount;

		public bool IsInterstitialChoiceShown;

		public int InterstitialDisplayCount;
	}
}
