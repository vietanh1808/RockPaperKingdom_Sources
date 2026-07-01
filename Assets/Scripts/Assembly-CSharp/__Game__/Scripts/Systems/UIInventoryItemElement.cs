using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIInventoryItemElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[Header("View")]
		[SerializeField]
		private Image _typeImage;

		[SerializeField]
		private TMP_Text _amountValue;

		[SerializeField]
		private Image _background;

		private InventoryItem _inventoryItem;

		private UIItemMessage _uiItemMessage;

		public void Construct(InventoryItem item, UIItemMessage uiItemMessage)
		{
		}

		public void Unsubscribe()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshAmount(InventoryItem item)
		{
		}

		private void ShowMessage()
		{
		}
	}
}
