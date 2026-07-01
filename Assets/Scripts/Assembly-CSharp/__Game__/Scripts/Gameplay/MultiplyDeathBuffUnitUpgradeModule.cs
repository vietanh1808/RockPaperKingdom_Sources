using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class MultiplyDeathBuffUnitUpgradeModule : BaseUnitUpgradeModule
	{
		[SerializeField]
		private UnitStatType _statType;

		[SerializeField]
		private float _percent;

		public override void Apply(SharedUnit sharedUnitData)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
