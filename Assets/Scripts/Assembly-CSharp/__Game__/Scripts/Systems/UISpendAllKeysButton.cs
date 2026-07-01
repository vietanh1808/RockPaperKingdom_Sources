using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpendAllKeysButton : MonoBehaviour
	{
		private const int COST_PER_CHEST = 1;

		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _buttonIcon;

		[SerializeField]
		private TMP_Text _labelText;

		[SerializeField]
		private TMP_Text _priceText;

		private InventorySystem _inventorySystem;

		private ChestKeyPurchaseService _chestKeyPurchaseService;

		private ChestData _chestData;

		private PurchaseData _keyPurchaseData;

		private InventoryItem _keyItem;

		[Inject]
		public void Inject(InventorySystem inventorySystem, ChestKeyPurchaseService chestKeyPurchaseService)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize(ChestData chestData)
		{
		}

		private void SpendAllKeysHandler()
		{
		}

		private void OnKeyAmountChanged(InventoryItem inventoryItem)
		{
		}

		private void RefreshView()
		{
		}
	}
}
