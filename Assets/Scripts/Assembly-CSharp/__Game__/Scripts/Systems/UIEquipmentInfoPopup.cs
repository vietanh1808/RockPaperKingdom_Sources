using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentInfoPopup : MonoBehaviour
	{
		[Header("Buttons")]
		[SerializeField]
		private UIButtonClick _closeButton;

		[Header("Element")]
		[SerializeField]
		private Image _frame;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private Image _typeFrame;

		[SerializeField]
		private Image _typeImage;

		[Header("Info")]
		[SerializeField]
		private Image _rarityIcon;

		[SerializeField]
		private TMP_Text _rarityValue;

		[SerializeField]
		private TMP_Text _itemName;

		[SerializeField]
		private UIStatElement _statElement;

		[SerializeField]
		private TMP_Text _description;

		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private UIEquipmentUpgradesView _equipmentUpgradesView;

		private RarityConfig _rarityConfig;

		private PlayerStatInfoCollection _playerStatInfoCollection;

		public EquipmentItem Item { get; private set; }

		[Inject]
		public void Inject(RarityConfig rarityConfig, PlayerStatInfoCollection playerStatInfoCollection)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open(EquipmentItem item)
		{
		}

		public void ClosePopup()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshLevel(EquipmentItem equipmentItem)
		{
		}
	}
}
