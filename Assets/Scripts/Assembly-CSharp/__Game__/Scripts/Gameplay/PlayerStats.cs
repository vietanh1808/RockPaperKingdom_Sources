using System.Collections.Generic;
using __Game__.Scripts.Common;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class PlayerStats
	{
		private readonly Dictionary<PlayerStatType, float> _baseStats;

		private readonly Dictionary<PlayerStatType, float> _statMultipliers;

		private readonly Dictionary<PlayerStatType, StatValue> _finalStats;

		public void SetBaseStat(PlayerStatType statType, float value)
		{
		}

		public void ChangeBaseStat(PlayerStatType statType, float value)
		{
		}

		public void ChangeStatMultipliers(PlayerStatType statType, float value)
		{
		}

		public StatValue GetFinalStat(PlayerStatType statType, float defaultValue = 0f)
		{
			return null;
		}

		private void RecalculateFinalStat(PlayerStatType statType)
		{
		}
	}
}
