using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityDamageApplier
	{
		private readonly Ability _ability;

		private readonly StatValue _finalAbilityDamageStat;

		private readonly StatValue _damageCritChanceStat;

		private readonly StatValue _damageCritMultiplierStat;

		private readonly float _baseDamageValue;

		public AbilityDamageApplier(Ability ability)
		{
		}

		public void ApplyDamage(IDamageable targetDamageable)
		{
		}

		private void AddCritBonusDamage(Damage damage, float damageValue)
		{
		}

		private void ApplyDamageReflection(Damage damage, IDamageable target)
		{
		}
	}
}
