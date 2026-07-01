using TMPro;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIItemMessage : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _messageTransform;

		[SerializeField]
		private TMP_Text _titleValue;

		[SerializeField]
		private TMP_Text _descriptionValue;

		private void Update()
		{
		}

		public void ShowMessage(InventoryItemData inventoryItemData, Transform targetTransform)
		{
		}

		private Vector2 GetTargetPosition(Transform targetTransform)
		{
			return default(Vector2);
		}

		private void ClampMessageScreenBounds(Vector2 messagePosition)
		{
		}
	}
}
