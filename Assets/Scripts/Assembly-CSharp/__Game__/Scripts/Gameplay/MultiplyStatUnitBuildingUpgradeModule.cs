using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class MultiplyStatUnitBuildingUpgradeModule : BaseBuildingUpgradeModule
	{
		[SerializeField]
		private UnitStatType _statType;

		[SerializeField]
		private float _multiplier;

		[SerializeField]
		private StatMultiplierSourceType _sourceType;

		public UnitStatType StatType => default(UnitStatType);

		public float Multiplier => 0f;

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

		public bool WouldHaveEffect(BuildingRuntime buildingRuntime)
		{
			return false;
		}
	}
}
