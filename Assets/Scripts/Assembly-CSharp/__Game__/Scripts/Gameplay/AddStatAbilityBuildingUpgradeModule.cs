using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AddStatAbilityBuildingUpgradeModule : BaseBuildingUpgradeModule
	{
		[SerializeField]
		private AbilityTargetType _targetAbility;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _value;

		public AbilityStatType StatType => default(AbilityStatType);

		public float Value => 0f;

		public override void Apply(BuildingRuntime buildingRuntime)
		{
		}

		public override string GetDescription()
		{
			return null;
		}

		public override string GetShortDescription(BuildingRuntime buildingRuntime)
		{
			return null;
		}

		public override string GetLongDescription(BuildingRuntime buildingRuntime)
		{
			return null;
		}

		private static string FormatValue(float value)
		{
			return null;
		}
	}
}
