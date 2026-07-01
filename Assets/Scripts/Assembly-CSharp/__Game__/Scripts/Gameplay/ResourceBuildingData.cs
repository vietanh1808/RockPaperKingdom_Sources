using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingData_Resource_", menuName = "TapHub/Buildings/Building Data/Resource Building")]
	public class ResourceBuildingData : BaseBuildingData
	{
		[SerializeField]
		private ResourceBuilding _prefab;

		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private int _amount;

		public override BaseBuilding Prefab => null;

		public override BuildingType BuildingType => default(BuildingType);

		public ResourceBuilding TypedPrefab => null;

		public InventoryItemData InventoryItemData => null;

		public int Amount => 0;
	}
}
