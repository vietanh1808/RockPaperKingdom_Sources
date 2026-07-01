using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddHitEffectAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private AbilityObject _hitEffectObjectPrefab;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
