using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPriceView : MonoBehaviour
	{
		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private TMP_Text _amountValue;

		private InventoryItem _inventoryItem;

		private int _itemAmount;

		public void Construct(PriceData price, InventorySystem inventorySystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Unsubscribe()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshAmount(InventoryItem inventoryItem)
		{
		}
	}
}
