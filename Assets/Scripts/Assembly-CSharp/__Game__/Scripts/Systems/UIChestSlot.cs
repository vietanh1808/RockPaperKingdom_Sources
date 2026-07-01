using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIChestSlot : MonoBehaviour
	{
		[Header("Buttons")]
		[SerializeField]
		private UIButtonClick _infoButton;

		[SerializeField]
		private UISpendAllKeysButton _spendAllKeysButton;

		[SerializeField]
		private UIPurchaseButton _secondaryPurchaseButton;

		[SerializeField]
		private UIPurchaseButton _adsButton;

		[Header("View")]
		[SerializeField]
		private TMP_Text _titleValue;

		[SerializeField]
		private TMP_Text _timesValue;

		[SerializeField]
		private Image _chestIcon;

		[Header("Config")]
		[SerializeField]
		private ChestData _chestData;

		[SerializeField]
		private Color _rarityTextColor;

		private ChestItem _chestItem;

		private ChestSystem _chestSystem;

		private UnitCardSystem _unitCardSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private InventorySystem _inventorySystem;

		private RarityData _rarityData;

		private InventoryItem _keyItem;

		[Inject]
		public void Inject(ChestSystem chestSystem, UnitCardSystem unitCardSystem, UIMenuSceneNavigation uiMenuSceneNavigation, InventorySystem inventorySystem, RarityConfig rarityConfig)
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

		private void RefreshClaimCounter()
		{
		}

		private void OnUnitCardItemUnlocked(UnitCardItem unitCardItem)
		{
		}

		private void OpenChestInfoPopup()
		{
		}

		private void OnKeyAmountChanged(InventoryItem inventoryItem)
		{
		}

		private void RefreshPurchaseButtons()
		{
		}
	}
}
