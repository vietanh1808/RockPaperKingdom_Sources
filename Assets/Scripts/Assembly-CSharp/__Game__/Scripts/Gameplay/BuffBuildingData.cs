using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_Buff_", menuName = "TapHub/Buildings/Building Data/Buff Building")]
	public class BuffBuildingData : BaseBuildingData
	{
		[SerializeField]
		private UpgradeBuildingTargetType _targetType;

		[SerializeField]
		private BaseBuildingData _specificBuildingData;

		[SerializeField]
		private SoundData _applySfx;

		[SerializeField]
		private AssetModuleHolder<BaseBuildingUpgradeModule> _upgradeModuleHolder;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public UpgradeBuildingTargetType TargetType => default(UpgradeBuildingTargetType);

		public SoundData ApplySfx => null;

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

		public void ApplyToBuilding(BuildingRuntime buildingRuntime)
		{
		}

		public bool CanTargetBuilding(BaseBuilding building)
		{
			return false;
		}

		private bool WouldHaveEffect(BuildingRuntime buildingRuntime)
		{
			return false;
		}
	}
}
