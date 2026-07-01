using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaEnemyStaticStatSystem
	{
		private const float DEFAULT_HP_MULTIPLIER = 1f;

		private const float DEFAULT_DAMAGE_MULTIPLIER = 1f;

		private const float DEFAULT_CASTLE_HP = 100f;

		private const int FIRST_TIER_INTERPOLATION_START = 1000;

		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaConfig _arenaConfig;

		private ArenaTierData _tierOverride;

		private bool _multipliersDisabled;

		private float _hpMultiplier;

		private float _damageMultiplier;

		private float _castleHp;

		private ArenaTierData ActiveTier => null;

		public float HpMultiplier => 0f;

		public float DamageMultiplier => 0f;

		public float CastleHp => 0f;

		public ArenaEnemyStaticStatSystem(ArenaSystem arenaSystem, ArenaConfig arenaConfig)
		{
		}

		public void Initialize()
		{
		}

		public void OverrideTier(ArenaTierData tier)
		{
		}

		public void DisableMultipliers()
		{
		}
	}
}
