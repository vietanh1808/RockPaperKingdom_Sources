using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class StunDebuff : BaseDebuff
	{
		private readonly BaseUnit _targetUnit;

		private readonly Ability _ability;

		private readonly AbilityObjectPoolContainer _abilityObjectPoolContainer;

		private readonly AbilityObject _stunEffectPrefab;

		private AbilityObject _stunEffect;

		private IUnitState _previousState;

		public StunDebuff(BaseUnit targetUnit, float duration, Ability ability, AbilityObject stunEffectPrefab, AbilityObjectPoolContainer abilityObjectPoolContainer)
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

		public override bool CanBeApplied()
		{
			return false;
		}

		private Vector3 GetEffectPosition()
		{
			return default(Vector3);
		}
	}
}
