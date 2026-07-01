using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_TargetAbility_Multiply", menuName = "TapHub/Stats/Modifiers/Target Ability Multiply Stat")]
	public class TargetAbilityMultiplyStatModifier : BaseModifier
	{
		[SerializeField]
		private AbilityData _abilityData;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _percentageRise;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
