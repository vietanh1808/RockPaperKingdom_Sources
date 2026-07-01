using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroSlot : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _slotConfirmButton;

		[SerializeField]
		private UIButtonClick _heroSelectionButton;

		[SerializeField]
		private UIButtonClick _heroOpenButton;

		[Header("State Containers")]
		[SerializeField]
		private GameObject _pendingOverlay;

		[SerializeField]
		private GameObject _selectingOverlay;

		[SerializeField]
		private GameObject _lockedOverlay;

		[SerializeField]
		private GameObject _activatedContainer;

		[SerializeField]
		private Image _frameImage;

		[SerializeField]
		private Image _titleBackgroundImage;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private TMP_Text _titleValue;

		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private UICollectibleAmountElement _uiCollectibleAmount;

		[SerializeField]
		private GameObject _selectMark;

		[SerializeField]
		private GameObject _alertMark;

		[SerializeField]
		private UIHeroUnitCardNewAlert _unitCardNewAlert;

		private HeroSystem _heroSystem;

		private HeroConfig _heroConfig;

		private RarityConfig _rarityConfig;

		private InventoryItem _materialItem;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private int _slotIndex;

		private bool _isSubscribed;

		public HeroItem HeroItem { get; private set; }

		[Inject]
		private void Inject(HeroSystem heroSystem, HeroConfig heroConfig, RarityConfig rarityConfig, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToItem()
		{
		}

		private void UnsubscribeFromItem()
		{
		}

		private void UnsubscribeFromPreviousItem(HeroItem previousItem, InventoryItem previousMaterialItem)
		{
		}

		public void ConfigureSlotByIndex(int slotIndex)
		{
		}

		private void RefreshView()
		{
		}

		private void SetupHero()
		{
		}

		private void SetupSelecting()
		{
		}

		private void SetupPending()
		{
		}

		private void SetupLocked()
		{
		}

		private void RefreshAlertMark(bool value)
		{
		}

		private void RefreshLevel(BaseCollectibleItem<HeroItemData> heroItem)
		{
		}

		private void RefreshAmount(InventoryItem materialItem)
		{
		}

		private void OnCollectibleItemUnlocked(HeroItem heroItem)
		{
		}

		private void OnSelectingSlot()
		{
		}

		private void OnSelectingCanceled()
		{
		}

		private void OnSlotConfirmButtonClicked()
		{
		}

		private void OnHeroSelectionButtonClicked()
		{
		}

		private void OnHeroOpenButtonClicked()
		{
		}

		private void ActivateSelectedHero(HeroItem selectedHero)
		{
		}
	}
}
