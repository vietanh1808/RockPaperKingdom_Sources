using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddSourceEffectAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private AbilityObject _sourceEffectObjectPrefab;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
