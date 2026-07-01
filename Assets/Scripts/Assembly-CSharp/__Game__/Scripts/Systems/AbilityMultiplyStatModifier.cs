using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Ability_Multiply", menuName = "TapHub/Stats/Modifiers/Ability Multiply Stat")]
	public class AbilityMultiplyStatModifier : BaseModifier
	{
		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _percent;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
