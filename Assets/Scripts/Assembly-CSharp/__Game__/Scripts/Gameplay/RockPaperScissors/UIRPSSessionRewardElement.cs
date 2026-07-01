using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSSessionRewardElement : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _targetContainer;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private TMP_Text _amountText;

		[SerializeField]
		private UIButtonClick _buttonClick;

		[Header("Active State")]
		[SerializeField]
		private Sprite _activeIconSprite;

		[SerializeField]
		private Color _activeBackgroundColor;

		[SerializeField]
		private Color _activeTextColor;

		[Header("Inactive State")]
		[SerializeField]
		private Sprite _inactiveIconSprite;

		[SerializeField]
		private Color _inactiveBackgroundColor;

		[SerializeField]
		private Color _inactiveTextColor;

		private InventoryItemData _itemData;

		private UIItemMessage _uiItemMessage;

		private int _sessionAmount;

		private int _displayedAmount;

		private Tween _scaleTween;

		private Tween _countTween;

		public string ItemGuid => null;

		public RectTransform TargetContainer => null;

		public void Setup(InventoryItemData itemData, UIItemMessage uiItemMessage)
		{
		}

		public void AddAmount(int amount)
		{
		}

		public void ResetSession()
		{
		}

		public void ResetAmount()
		{
		}

		private void ApplyActiveState()
		{
		}

		private void ApplyInactiveState()
		{
		}

		private void OnDisable()
		{
		}

		private void AnimateIncrement()
		{
		}

		private void KillTweens()
		{
		}

		private void ShowMessage()
		{
		}
	}
}
