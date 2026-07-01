using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddCastOnHitAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private AbilityData _castOnHitAbility;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
