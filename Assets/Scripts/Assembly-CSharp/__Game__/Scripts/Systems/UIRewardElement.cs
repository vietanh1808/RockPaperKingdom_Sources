using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private TMP_Text _itemValue;

		[SerializeField]
		private GameObject _doubleBadge;

		private UIItemMessage _uiItemMessage;

		private Reward _reward;

		public InventoryItemData InventoryItemData => null;

		public RectTransform IconRectTransform => null;

		[Inject]
		private void Inject(UIItemMessage uiItemMessage)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Construct(Reward reward)
		{
		}

		public void HideBackground()
		{
		}

		public void DisableMaskable()
		{
		}

		public void ApplyDoubleReward()
		{
		}

		private void Refresh(Reward reward)
		{
		}

		private void ShowMessage()
		{
		}
	}
}
