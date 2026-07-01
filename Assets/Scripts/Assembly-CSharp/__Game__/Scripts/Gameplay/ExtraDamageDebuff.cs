using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ExtraDamageDebuff : BaseDebuff
	{
		private readonly BaseUnit _targetUnit;

		private readonly Ability _ability;

		private readonly AbilityObject _extraDamageEffectPrefab;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private AbilityObject _extraDamageEffect;

		private float _extraDamageMultiplier;

		public ExtraDamageDebuff(BaseUnit targetUnit, float duration, Ability ability, AbilityObject extraDamageEffectPrefab, AbilityObjectPoolContainer abilityObjectPoolContainer)
			: base(null, 0f)
		{
		}

		public override void Tick()
		{
		}

		public override void Apply()
		{
		}

		public override void Remove()
		{
		}

		private Vector3 GetEffectPosition()
		{
			return default(Vector3);
		}
	}
}
