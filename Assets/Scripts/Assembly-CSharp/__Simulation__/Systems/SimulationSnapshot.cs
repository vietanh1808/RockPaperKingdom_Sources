using System;
using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	[Serializable]
	public class SimulationSnapshot
	{
		public int Day { get; set; }

		public int SessionIndex { get; set; }

		public TimeSpan SessionDuration { get; set; }

		public int Attempt { get; set; }

		public int StageIndex { get; set; }

		public bool IsVictory { get; set; }

		public TimeSpan Duration { get; set; }

		public int PlayerLevel { get; set; }

		public int Energy { get; set; }

		public int TotalPower { get; set; }

		public int UnitsUpgradePower { get; set; }

		public int PlayerUnlockedUpgradeIndex { get; set; }

		public int PlayerPurchasedUpgradeIndex { get; set; }

		public Dictionary<string, float> HeroHpMultipliersBySource { get; set; }

		public Dictionary<string, float> HeroDmgMultipliersBySource { get; set; }

		public Dictionary<string, InventoryItemSnapshot> InventoryItems { get; set; }

		public List<FeatureItem> UnlockedFeatures { get; set; }

		public List<EquipmentItemSnapshot> EquippedItems { get; set; }

		public List<HeroItem> HeroItems { get; set; }

		public List<UnitCardItem> UnitCardItems { get; set; }

		public List<TalentItemSnapshot> Talents { get; set; }

		public Dictionary<PlayerStatType, float> PlayerStats { get; set; }

		public SimulationSnapshot GetCopy()
		{
			return null;
		}
	}
}
