using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddStatAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _value;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
