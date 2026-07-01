using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PlayerPowerSystem
	{
		private const int BASE_POWER = 1000;

		private const float UNIT_CARD_POWER_WEIGHT = 1f / 3f;

		private const float POWER_PER_HP = 10f;

		private readonly StaticStatSystem _staticStatSystem;

		private readonly PlayerStaticStatsRepository _playerStats;

		private readonly UnitStaticStatsRepository _unitStats;

		private readonly PlayerStatConfig _playerStatConfig;

		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		public int CurrentPower { get; private set; }

		public event Action<int, int> OnPowerChanged
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

		public PlayerPowerSystem(StaticStatSystem staticStatSystem, PlayerStaticStatsRepository playerStats, UnitStaticStatsRepository unitStats, PlayerStatConfig playerStatConfig, HeroSystem heroSystem, UnitCardSystem unitCardSystem)
		{
		}

		public void Initialize()
		{
		}

		private void Recalculate()
		{
		}

		private int CalculatePower()
		{
			return 0;
		}

		private float CalculatePlayerStatsBonus()
		{
			return 0f;
		}

		private float CalculateUnitStatsMultiplier()
		{
			return 0f;
		}

		private float CalculateUnitCardMultiplier()
		{
			return 0f;
		}
	}
}
