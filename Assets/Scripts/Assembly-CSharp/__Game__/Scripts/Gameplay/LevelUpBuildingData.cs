using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_LevelUp_", menuName = "TapHub/Buildings/Building Data/Level Up Building")]
	public class LevelUpBuildingData : BaseBuildingData
	{
		[SerializeField]
		private UpgradeBuildingTargetType _targetType;

		[SerializeField]
		private BaseBuildingData _specificBuildingData;

		[SerializeField]
		private SoundData _applySfx;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public UpgradeBuildingTargetType TargetType => default(UpgradeBuildingTargetType);

		public SoundData ApplySfx => null;

		public void ApplyToBuilding(BuildingRuntime buildingRuntime)
		{
		}

		public bool CanTargetBuilding(BaseBuilding building)
		{
			return false;
		}

		public string[] GetDescription()
		{
			return null;
		}

		public string[] GetUpgradeDescription(BuildingRuntime buildingRuntime)
		{
			return null;
		}
	}
}
