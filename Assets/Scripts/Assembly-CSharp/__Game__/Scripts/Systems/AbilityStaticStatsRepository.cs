using System.Collections.Generic;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	public class AbilityStaticStatsRepository
	{
		private Dictionary<AbilityStatType, float> TotalAbilityStats { get; }

		private Dictionary<AbilityStatType, float> TotalAbilityStatsMultiplier { get; }

		private Dictionary<AbilityData, AbilityStaticStats> TargetAbilityStats { get; }

		private Dictionary<AbilityData, AbilityStaticStats> TargetAbilityStatsMultiplier { get; }

		public void Reset()
		{
		}

		public void IncreaseTargetStat(AbilityData abilityData, AbilityStatType statType, float value)
		{
		}

		public void IncreaseTargetMultiplier(AbilityData abilityData, AbilityStatType statType, float value)
		{
		}

		public void IncreaseTotalStat(AbilityStatType statType, float value)
		{
		}

		public void IncreaseTotalMultiplier(AbilityStatType statType, float value)
		{
		}

		public Dictionary<AbilityStatType, float> GetAbilityStats(AbilityData abilityData)
		{
			return null;
		}

		public Dictionary<AbilityStatType, float> GetAbilityMultipliers(AbilityData abilityData)
		{
			return null;
		}

		private static void IncreaseStat(Dictionary<AbilityData, AbilityStaticStats> targetDictionary, AbilityData abilityData, AbilityStatType statType, float value)
		{
		}

		private static Dictionary<AbilityStatType, float> CombineStats(Dictionary<AbilityStatType, float> baseStats, AbilityStaticStats targetAbilityStaticStats)
		{
			return null;
		}
	}
}
