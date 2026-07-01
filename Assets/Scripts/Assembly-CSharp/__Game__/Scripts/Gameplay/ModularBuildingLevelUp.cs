using Sirenix.OdinInspector;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingLevelUp_", menuName = "TapHub/Buildings/Building Level Up")]
	public class ModularBuildingLevelUp : SerializedScriptableObject
	{
		[SerializeField]
		private string _description;

		[SerializeField]
		private AssetModuleHolder<BaseBuildingUpgradeModule> _upgradeModuleHolder;

		public AssetModuleHolder<BaseBuildingUpgradeModule> UpgradeModuleHolder => null;

		private void OnEnable()
		{
		}

		public void Apply(BuildingRuntime buildingRuntime)
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
	}
}
