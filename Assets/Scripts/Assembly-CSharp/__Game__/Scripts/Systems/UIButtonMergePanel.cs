using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIButtonMergePanel : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		private UIMenuSceneNavigation _menuSceneNavigation;

		[Inject]
		public void Inject(UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
