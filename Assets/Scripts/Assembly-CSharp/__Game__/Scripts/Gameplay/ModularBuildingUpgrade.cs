using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_ModularBuilding", menuName = "TapHub/Gameplay Upgrades/Buildings/Modular Building Upgrade")]
	public class ModularBuildingUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private BuildingUpgradeCellsProviderType _cellsProviderType;

		[SerializeField]
		private UpgradeBuildingTargetType _targetType;

		[SerializeField]
		private BaseBuildingData _specificBuildingData;

		[SerializeField]
		private AssetModuleHolder<BaseBuildingUpgradeModule> _upgradeModuleHolder;

		private void OnEnable()
		{
		}

		public override bool CanBeUsed(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
			return false;
		}

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		private List<BaseBuilding> GetSingleBuildingToUpgrade(List<BaseBuilding> targetBuildings)
		{
			return null;
		}

		private List<BaseBuilding> GetTargetBuildings(BuildingRepository buildingRepository)
		{
			return null;
		}

		private bool CanTargetBuilding(BaseBuilding building)
		{
			return false;
		}

		private bool WouldHaveEffect(BuildingRuntime buildingRuntime)
		{
			return false;
		}

		private void ApplyModules(BuildingRuntime buildingRuntime)
		{
		}

		public override string[] GetDescription()
		{
			return null;
		}
	}
}
