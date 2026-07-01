using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityStats
	{
		private readonly Dictionary<AbilityStatType, float> _baseStats;

		private readonly Dictionary<AbilityStatType, float> _statMultipliers;

		private readonly Dictionary<AbilityStatType, float> _statAdditive;

		private readonly Dictionary<AbilityStatType, StatValue> _finalStats;

		private readonly Dictionary<AbilityStatType, float> _statCaps;

		public event Action<StatChangeEventArgs> OnStatChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetBaseStat(AbilityStatType statType, float value)
		{
		}

		public void ChangeBaseStat(AbilityStatType statType, float value)
		{
		}

		public void ChangeStatMultipliers(AbilityStatType statType, float value)
		{
		}

		public void ChangeStatAdditive(AbilityStatType statType, float value)
		{
		}

		public void SetStatCap(AbilityStatType statType, float maxValue)
		{
		}

		public float GetBaseStat(AbilityStatType statType)
		{
			return 0f;
		}

		public StatValue GetFinalStat(AbilityStatType statType, float defaultValue = 0f)
		{
			return null;
		}

		public Dictionary<int, float> GetBaseStatsDictionary()
		{
			return null;
		}

		public Dictionary<int, float> GetMultipliersDictionary()
		{
			return null;
		}

		public Dictionary<int, float> GetAdditiveDictionary()
		{
			return null;
		}

		public void RestoreState(Dictionary<int, float> baseStats, Dictionary<int, float> multipliers, Dictionary<int, float> additive)
		{
		}

		private void RecalculateFinalStat(AbilityStatType statType)
		{
		}
	}
}
