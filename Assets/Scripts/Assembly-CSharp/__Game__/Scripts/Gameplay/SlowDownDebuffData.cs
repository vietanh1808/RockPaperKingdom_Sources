using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "DebuffData_SlowDown", menuName = "TapHub/Ability/Debuffs/SlowDown")]
	public class SlowDownDebuffData : BaseDebuffData
	{
		[SerializeField]
		private AbilityObject _debuffEffectPrefab;

		public override void InitDebuff(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public override void Apply(IDebuffable debuffable, Ability ability)
		{
		}
	}
}
