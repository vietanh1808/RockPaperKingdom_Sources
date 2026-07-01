using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class MultiplyStatAbilityUpgradeModule : BaseAbilityUpgradeModule
	{
		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _percent;

		public override void Apply(SharedAbility sharedAbility)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
