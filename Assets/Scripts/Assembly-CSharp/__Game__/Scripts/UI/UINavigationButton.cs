using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UINavigationButton : MonoBehaviour
	{
		[SerializeField]
		private GameObject _pageContainer;

		[Header("View")]
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private GameObject _buttonFocus;

		[SerializeField]
		private GameObject _buttonLock;

		[Header("Button Settings")]
		[SerializeField]
		private RectTransform _buttonContainer;

		[SerializeField]
		private Vector2 _defaultButtonSize;

		[SerializeField]
		private Vector2 _focusButtonSize;

		[Header("Icon Settings")]
		[SerializeField]
		private RectTransform _iconContainer;

		[SerializeField]
		private Vector2 _defaultIconSize;

		[SerializeField]
		private Vector2 _focusIconSize;

		[SerializeField]
		private Vector2 _defaultIconPosition;

		[SerializeField]
		private Vector2 _focusIconPosition;

		private UINavigationController _navigationController;

		public void Initialize(UINavigationController navigationController)
		{
		}

		public void Unsubscribe()
		{
		}

		public void SetUnlocked(bool status)
		{
		}

		public void Focus()
		{
		}
	}
}
