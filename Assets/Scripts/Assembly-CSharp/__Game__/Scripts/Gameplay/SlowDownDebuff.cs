using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class SlowDownDebuff : BaseDebuff
	{
		private readonly BaseUnit _targetUnit;

		private readonly Ability _ability;

		private readonly AbilityObject _debuffEffectPrefab;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private AbilityObject _debuffEffect;

		private float _debuffPower;

		public SlowDownDebuff(BaseUnit targetUnit, float duration, Ability ability, AbilityObject debuffEffectPrefab, AbilityObjectPoolContainer abilityObjectPoolContainer)
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
