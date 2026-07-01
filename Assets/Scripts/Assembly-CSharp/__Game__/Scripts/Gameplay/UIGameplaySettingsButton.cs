using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplaySettingsButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _settingsButton;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		[Inject]
		public void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSettingsButtonClicked()
		{
		}
	}
}
