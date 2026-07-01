using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class TowerStats
	{
		private readonly Dictionary<UnitStatType, float> _baseStats;

		private readonly Dictionary<UnitStatType, float> _statMultipliers;

		private readonly Dictionary<UnitStatType, float> _statAdditive;

		private readonly Dictionary<UnitStatType, StatValue> _finalStats;

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

		public void SetBaseStat(UnitStatType statType, float value)
		{
		}

		public void ChangeBaseStat(UnitStatType statType, float value)
		{
		}

		public void ChangeStatMultipliers(UnitStatType statType, float value)
		{
		}

		public void ChangeStatAdditive(UnitStatType statType, float value)
		{
		}

		public float GetBaseStat(UnitStatType statType, float defaultValue = 0f)
		{
			return 0f;
		}

		public StatValue GetFinalStat(UnitStatType statType, float defaultValue = 0f)
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

		private void RecalculateFinalStat(UnitStatType statType)
		{
		}
	}
}
