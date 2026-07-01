using System.Collections.Generic;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	public class UnitStaticStatsRepository
	{
		private Dictionary<UnitData, UnitStaticStats> BaseUnitStats { get; }

		private Dictionary<UnitData, UnitStaticStats> TargetUnitStats { get; }

		private Dictionary<UnitData, UnitStaticStats> TargetUnitMultipliers { get; }

		private Dictionary<UnitStatType, float> TotalUnitStats { get; }

		private Dictionary<UnitStatType, float> TotalUnitStatsMultiplier { get; }

		public void Reset()
		{
		}

		public void ResetModifiers()
		{
		}

		public void SetupBaseValue(UnitData unitData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTargetStat(UnitData unitData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTargetMultiplier(UnitData unitData, UnitStatType statType, float value)
		{
		}

		public void IncreaseTotalStat(UnitStatType statType, float value)
		{
		}

		public void IncreaseTotalMultiplier(UnitStatType statType, float value)
		{
		}

		public float GetTotalMultiplier(UnitStatType statType)
		{
			return 0f;
		}

		public Dictionary<UnitStatType, float> GetBaseStats(UnitData unitData)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetModifiedStats(UnitData unitData)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetModifiedMultipliers(UnitData unitData)
		{
			return null;
		}

		private static void IncreaseStat(Dictionary<UnitData, UnitStaticStats> targetDictionary, UnitData unitData, UnitStatType statType, float value)
		{
		}

		private static Dictionary<UnitStatType, float> GetCombinedStats(Dictionary<UnitStatType, float> baseStats, UnitStaticStats targetUnitStaticStats)
		{
			return null;
		}
	}
}
