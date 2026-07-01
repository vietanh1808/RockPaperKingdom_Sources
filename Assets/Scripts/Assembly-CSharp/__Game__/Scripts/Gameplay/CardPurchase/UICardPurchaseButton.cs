using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.CardPurchase
{
	public class UICardPurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _purchaseButton;

		[SerializeField]
		private Image _priceIcon;

		[SerializeField]
		private TMP_Text _priceText;

		private CardPurchaseSystem _cardPurchaseSystem;

		private GameplayInventorySystem _gameplayInventorySystem;

		private InventoryItem _inventoryItem;

		[Inject]
		public void Inject(CardPurchaseSystem cardPurchaseSystem, GameplayInventorySystem gameplayInventorySystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPurchaseButtonClick()
		{
		}

		private void OnPriceChanged(int newPrice)
		{
		}

		private void OnAmountChanged(InventoryItem item)
		{
		}

		private void UpdatePriceDisplay()
		{
		}
	}
}
