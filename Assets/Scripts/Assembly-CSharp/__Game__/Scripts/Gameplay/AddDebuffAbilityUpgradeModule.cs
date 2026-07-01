using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddDebuffAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private BaseDebuffData _debuffData;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
