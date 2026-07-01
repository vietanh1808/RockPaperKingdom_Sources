using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class FireDebuff : BaseDebuff
	{
		private readonly AbilityObject _fireEffectPrefab;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private readonly Ability _ability;

		private readonly StatValue _finalAbilityDamageStat;

		private readonly StatValue _debuffDamagePercentStat;

		private readonly StatValue _tickIntervalStat;

		private readonly float _baseDamageValue;

		private AbilityObject _fireEffect;

		private float _tickCooldown;

		public FireDebuff(float duration, BaseUnit targetUnit, Ability ability, AbilityObject fireEffectPrefab, AbilityObjectPoolContainer abilityObjectPoolContainer)
			: base(null, 0f)
		{
		}

		public override void Apply()
		{
		}

		public override void Remove()
		{
		}

		public override void Tick()
		{
		}

		private void ApplyDamage()
		{
		}

		private float GetFinalDamagePerTick()
		{
			return 0f;
		}
	}
}
