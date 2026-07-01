using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class MultiplyStatUnitUpgradeModule : BaseUnitUpgradeModule
	{
		[SerializeField]
		private UnitStatType _statType;

		[SerializeField]
		private float _multiplier;

		public override void Apply(SharedUnit sharedUnitData)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
