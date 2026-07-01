using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class UIGridExpandAlertNotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertIcon;

		private BuildingSlotGrid _buildingSlotGrid;

		private GameplayInventorySystem _inventorySystem;

		private GameplayConfig _gameplayConfig;

		private InventoryItem _currencyItem;

		[Inject]
		public void Inject(BuildingSlotGrid buildingSlotGrid, GameplayInventorySystem inventorySystem, GameplayConfig gameplayConfig)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHasEmptySlotsChanged(bool hasEmptySlots)
		{
		}

		private void OnCurrencyAmountChanged(InventoryItem item)
		{
		}

		private void UpdateAlert()
		{
		}
	}
}
