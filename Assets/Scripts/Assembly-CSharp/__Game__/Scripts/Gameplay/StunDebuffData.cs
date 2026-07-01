using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "DebuffData_Stun", menuName = "TapHub/Ability/Debuffs/Stun")]
	public class StunDebuffData : BaseDebuffData
	{
		[SerializeField]
		private AbilityObject _stunEffectPrefab;

		public override void InitDebuff(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public override void Apply(IDebuffable debuffable, Ability ability)
		{
		}
	}
}
