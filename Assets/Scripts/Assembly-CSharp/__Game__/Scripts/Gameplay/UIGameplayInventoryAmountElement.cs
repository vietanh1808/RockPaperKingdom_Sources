using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplayInventoryAmountElement : MonoBehaviour
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private RectTransform _targetContainer;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _amountValue;

		private GameplayInventorySystem _gameplayInventorySystem;

		private InventoryItem _inventoryItem;

		private int _previousAmount;

		public RectTransform TargetContainer => null;

		public TMP_Text AmountText => null;

		[Inject]
		private void Inject(GameplayInventorySystem gameplayInventorySystem)
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
