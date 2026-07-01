using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Services
{
	public class UISettingsButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		private UISettingsPopup _uiSettingsPopup;

		[Inject]
		public void Inject(UIProjectHolder uiProjectHolder)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OpenSettings()
		{
		}
	}
}
