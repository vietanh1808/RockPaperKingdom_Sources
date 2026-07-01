using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "DebuffData_Fire", menuName = "TapHub/Ability/Debuffs/Fire")]
	public class FireDebuffData : BaseDebuffData
	{
		[SerializeField]
		private AbilityObject _fireEffectPrefab;

		public override void InitDebuff(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public override void Apply(IDebuffable debuffable, Ability ability)
		{
		}
	}
}
