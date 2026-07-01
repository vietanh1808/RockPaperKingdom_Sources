using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class MultiplyStatAbilityBuildingUpgradeModule : BaseBuildingUpgradeModule
	{
		[SerializeField]
		private AbilityTargetType _targetAbility;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _percent;

		[SerializeField]
		private StatMultiplierSourceType _sourceType;

		public AbilityStatType StatType => default(AbilityStatType);

		public float Percent => 0f;

		public StatMultiplierSourceType SourceType => default(StatMultiplierSourceType);

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
