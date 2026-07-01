using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "DebuffData_ExtraDamage", menuName = "TapHub/Ability/Debuffs/Extra Damage")]
	public class ExtraDamageDebuffData : BaseDebuffData
	{
		[SerializeField]
		private AbilityObject _extraDamageEffectPrefab;

		public override void InitDebuff(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public override void Apply(IDebuffable debuffable, Ability ability)
		{
		}
	}
}
