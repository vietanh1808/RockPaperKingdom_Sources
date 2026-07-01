using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIInventoryCollectionView : MonoBehaviour
	{
		[SerializeField]
		private InventoryCollection _inventoryCollection;

		[SerializeField]
		private RectTransform _rootLayout;

		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIInventoryItemElement _inventoryElementPrefab;

		private readonly Dictionary<InventoryItem, UIInventoryItemElement> _inventoryElements;

		private InventorySystem _inventorySystem;

		private UIItemMessage _uiItemMessage;

		[Inject]
		public void Inject(InventorySystem inventorySystem, UIItemMessage uiItemMessage)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CreateAllElements()
		{
		}

		private void DestroyAllElements()
		{
		}

		private void CreateElement(InventoryItemData itemData)
		{
		}

		private void DestroyElement(KeyValuePair<InventoryItem, UIInventoryItemElement> keyValuePair)
		{
		}

		private void VisibilityCheck(InventoryItem inventoryItem)
		{
		}

		private void CheckAllElements()
		{
		}
	}
}
