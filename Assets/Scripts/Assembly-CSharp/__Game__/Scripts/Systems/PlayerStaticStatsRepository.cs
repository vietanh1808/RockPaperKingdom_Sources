using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PlayerStaticStatsRepository
	{
		private readonly PlayerStatConfig _playerStatConfig;

		private readonly PlayerStatInfoCollection _statInfo;

		private float _totalPower;

		private Dictionary<PlayerStatType, float> Stats { get; }

		private Dictionary<PlayerStatType, float> StatsMultiplier { get; }

		public float TotalPower
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public event Action<float> OnTotalPowerChanged
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

		public PlayerStaticStatsRepository(PlayerStatConfig playerStatConfig, PlayerStatInfoCollection statInfo)
		{
		}

		public float Get(PlayerStatType playerStatType)
		{
			return 0f;
		}

		public void IncreaseValue(PlayerStatType playerStatType, float value)
		{
		}

		public void IncreaseMultiplier(PlayerStatType playerStatType, float value)
		{
		}

		public void ApplyMultipliers()
		{
		}

		public void RecalculateTotalPower()
		{
		}

		public void Reset()
		{
		}
	}
}
