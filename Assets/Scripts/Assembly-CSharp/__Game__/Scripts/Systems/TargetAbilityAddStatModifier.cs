using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_TargetAbility_Add", menuName = "TapHub/Stats/Modifiers/Target Ability Add Stat")]
	public class TargetAbilityAddStatModifier : BaseModifier
	{
		[SerializeField]
		private AbilityData _abilityData;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _additionalValue;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
