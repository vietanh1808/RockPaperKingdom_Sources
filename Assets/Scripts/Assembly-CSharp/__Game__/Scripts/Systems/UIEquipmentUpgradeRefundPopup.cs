using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentUpgradeRefundPopup : UIBasePopup
	{
		[SerializeField]
		private UIButtonClick _levelDownButton;

		[Header("Info")]
		[SerializeField]
		private Image _rarityIcon;

		[SerializeField]
		private TMP_Text _rarityValue;

		[SerializeField]
		private TMP_Text _titleValue;

		[Header("Current Element")]
		[SerializeField]
		private Image _frameBackground;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private Image _typeBackground;

		[SerializeField]
		private Image _typeIcon;

		[SerializeField]
		private TMP_Text _levelValue;

		[Header("Rewards")]
		[SerializeField]
		private UIRewardsView _uiRewardsView;

		private EquipmentUpgradeRefundSystem _equipmentUpgradeRefundSystem;

		private RarityConfig _rarityConfig;

		private EquipmentItem _equipmentItem;

		[Inject]
		public void Inject(EquipmentUpgradeRefundSystem equipmentUpgradeRefundSystem, RarityConfig rarityConfig)
		{
		}

		public void Open(EquipmentItem item)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void SetupRefunds()
		{
		}

		private void LevelDownButtonClicked()
		{
		}
	}
}
