using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIInventoryAmountElement : MonoBehaviour
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private RectTransform _targetContainer;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _amountValue;

		private InventorySystem _inventorySystem;

		private InventoryItem _inventoryItem;

		private int _previousAmount;

		public RectTransform TargetContainer => null;

		public string ItemGuid => null;

		[Inject]
		private void Inject(InventorySystem inventorySystem)
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

		private void SetupView()
		{
		}

		private void RefreshView(InventoryItem inventoryItem)
		{
		}
	}
}
