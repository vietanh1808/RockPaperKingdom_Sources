using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerUpgradeElement : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		[SerializeField]
		private UIButtonClick _messageButton;

		[Header("View")]
		[SerializeField]
		private GameObject _inactiveMark;

		[SerializeField]
		private Image _upgradeIcon;

		[SerializeField]
		private Slider _slider;

		[Header("Level")]
		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private Image _levelIcon;

		[SerializeField]
		private Color _levelReadyColor;

		[SerializeField]
		private GameObject _levelContainer;

		[SerializeField]
		private GameObject _lineContainer;

		private Action<int, PlayerUpgradeData, Transform> _onShowMessage;

		private int _elementIndex;

		public PlayerUpgradeData PlayerUpgradeData { get; private set; }

		private bool IsFirstElement => false;

		public void Construct(Action<int, PlayerUpgradeData, Transform> onShowMessage, PlayerUpgradeData playerUpgradeData, int elementIndex, bool isUpgraded, bool isShowLevel)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowLevelReady()
		{
		}

		public void ShowLineRequired(bool status)
		{
		}

		public void ShowUpgradeAlert(bool status)
		{
		}

		public void ShowUpgradeAnimation()
		{
		}

		private void ShowUpgradeComplete()
		{
		}

		private void SetupView(bool isUpgraded, bool isShowLevel)
		{
		}

		private void ShowMessageClicked()
		{
		}
	}
}
