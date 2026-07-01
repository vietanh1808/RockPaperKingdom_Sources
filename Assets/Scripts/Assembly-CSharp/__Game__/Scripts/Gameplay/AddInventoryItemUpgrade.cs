using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_AddInventoryItem", menuName = "TapHub/Gameplay Upgrades/Inventory/Add Inventory Item Upgrade")]
	public class AddInventoryItemUpgrade : BaseGameplayUpgrade
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private int _amount;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}
	}
}
