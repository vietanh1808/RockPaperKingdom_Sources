using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentSlot : MonoBehaviour
	{
		[SerializeField]
		private EquipmentTypeData _equipmentTypeData;

		[SerializeField]
		private Image _equipmentTypeImage;

		[Header("Equipped")]
		[SerializeField]
		private GameObject _equippedContainer;

		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _frame;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private Image _typeFrame;

		[SerializeField]
		private Image _typeImage;

		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private GameObject _alertMark;

		private RarityConfig _rarityConfig;

		private UIMenuSceneNavigation _menuSceneNavigation;

		public EquipmentItem EquipmentItem { get; private set; }

		public EquipmentType EquipmentType => default(EquipmentType);

		[Inject]
		public void Inject(RarityConfig rarityConfig, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		private void Start()
		{
		}

		public void ShowElement(EquipmentItem item)
		{
		}

		public void HideElement(EquipmentItem item)
		{
		}

		private void SetupView(EquipmentItem item)
		{
		}

		private void Subscribe(EquipmentItem item)
		{
		}

		private void Unsubscribe(EquipmentItem item)
		{
		}

		private void RefreshLevel(EquipmentItem item)
		{
		}

		private void Refresh(bool value)
		{
		}

		private void ButtonClickHandler()
		{
		}
	}
}
