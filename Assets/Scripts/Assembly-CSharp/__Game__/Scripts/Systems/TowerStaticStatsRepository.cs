using System.Collections.Generic;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	public class TowerStaticStatsRepository
	{
		private Dictionary<TowerData, TowerStaticStats> BaseTowerStats { get; }

		private Dictionary<TowerData, TowerStaticStats> TargetTowerStats { get; }

		private Dictionary<TowerData, TowerStaticStats> TargetTowerMultipliers { get; }

		private Dictionary<UnitStatType, float> TotalTowerStats { get; }

		private Dictionary<UnitStatType, float> TotalTowerStatsMultiplier { get; }

		public void Reset()
		{
		}

		public void ResetModifiers()
		{
		}

		public void SetupBaseValue(TowerData towerData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTargetStat(TowerData towerData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTargetMultiplier(TowerData towerData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTotalStat(UnitStatType statType, float value)
		{
		}

		public void IncreaseTotalMultiplier(UnitStatType statType, float value)
		{
		}

		public Dictionary<UnitStatType, float> GetBaseStats(TowerData towerData)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetModifiedStats(TowerData towerData)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetModifiedMultipliers(TowerData towerData)
		{
			return null;
		}

		private static void IncreaseStat(Dictionary<TowerData, TowerStaticStats> targetDictionary, TowerData towerData, UnitStatType statType, float value)
		{
		}

		private static Dictionary<UnitStatType, float> GetCombinedStats(Dictionary<UnitStatType, float> baseStats, TowerStaticStats targetTowerStaticStats)
		{
			return null;
		}
	}
}
