using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_PowerUp_", menuName = "TapHub/Buildings/Building Data/Power Up Building")]
	public class PowerUpBuildingData : BaseBuildingData
	{
		[SerializeField]
		private PowerUpBuilding _prefab;

		[SerializeField]
		private UpgradeBuildingTargetType _targetType;

		[SerializeField]
		private BaseBuildingData _specificBuildingData;

		[SerializeField]
		private PowerUpCellsProviderType _cellsProviderType;

		[SerializeField]
		private AssetModuleHolder<BaseBuildingUpgradeModule> _upgradeModuleHolder;

		private static readonly Dictionary<UnitStatType, float> EmptyStats;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public PowerUpBuilding TypedPrefab => null;

		public UpgradeBuildingTargetType TargetType => default(UpgradeBuildingTargetType);

		public PowerUpCellsProviderType CellsProviderType => default(PowerUpCellsProviderType);

		public AssetModuleHolder<BaseBuildingUpgradeModule> UpgradeModuleHolder => null;

		private void OnEnable()
		{
		}

		public string[] GetDescription()
		{
			return null;
		}

		public string[] GetUpgradeDescription(BuildingRuntime buildingRuntime)
		{
			return null;
		}

		public override bool CanAffectBuilding(BaseBuilding building)
		{
			return false;
		}

		public bool CanTargetBuilding(BaseBuilding building)
		{
			return false;
		}

		public bool CanAffectBuildingType(BaseBuildingData buildingData)
		{
			return false;
		}
	}
}
