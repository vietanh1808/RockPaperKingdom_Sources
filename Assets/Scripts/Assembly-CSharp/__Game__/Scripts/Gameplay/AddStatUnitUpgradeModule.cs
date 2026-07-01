using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddStatUnitUpgradeModule : BaseUnitUpgradeModule
	{
		[SerializeField]
		private UnitStatType _statType;

		[SerializeField]
		private float _value;

		public override void Apply(SharedUnit sharedUnitData)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
