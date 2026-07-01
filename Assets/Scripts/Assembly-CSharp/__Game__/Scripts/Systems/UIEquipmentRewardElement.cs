using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentRewardElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _frameBackground;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private Image _typeBackground;

		[SerializeField]
		private Image _typeIcon;

		[SerializeField]
		private TMP_Text _amountText;

		private RarityConfig _rarityConfig;

		private UIProjectHolder _uiProjectHolder;

		private EquipmentItem _equipmentItem;

		[Inject]
		private void Inject(RarityConfig rarityConfig, UIProjectHolder uiProjectHolder)
		{
		}

		private void Start()
		{
		}

		public void Construct(EquipmentItem equipmentItem, int amount)
		{
		}

		private void OnButtonClick()
		{
		}
	}
}
