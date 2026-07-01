using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_ResourceBuff_", menuName = "TapHub/Buildings/Building Data/Resource Buff Building")]
	public class ResourceBuffBuildingData : BaseBuildingData
	{
		[SerializeField]
		private InventoryItemData _consumeInventoryItem;

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

		public InventoryItemData ConsumeInventoryItem => null;

		private void OnEnable()
		{
		}

		public string[] GetScaledDescription(int resourceAmount)
		{
			return null;
		}

		private string GetScaledModuleDescription(BaseBuildingUpgradeModule module, int amount)
		{
			return null;
		}

		private string FormatScaledPercent(string statName, float baseMultiplier, int amount)
		{
			return null;
		}

		private string FormatScaledValue(string statName, float baseValue, int amount)
		{
			return null;
		}

		private static string FormatFloat(float value)
		{
			return null;
		}

		public void ApplyToBuilding(BuildingRuntime buildingRuntime, GameplayInventorySystem inventorySystem)
		{
		}

		public bool CanTargetBuilding(BaseBuilding building, GameplayInventorySystem inventorySystem)
		{
			return false;
		}

		public bool HasRequiredResource(GameplayInventorySystem inventorySystem)
		{
			return false;
		}

		private bool WouldHaveEffect(BuildingRuntime buildingRuntime)
		{
			return false;
		}
	}
}
