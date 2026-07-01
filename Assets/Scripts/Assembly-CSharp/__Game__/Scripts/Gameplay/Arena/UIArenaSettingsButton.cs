using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Arena.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class UIArenaSettingsButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _settingsButton;

		private UIArenaSceneNavigation _uiArenaSceneNavigation;

		[Inject]
		public void Inject(UIArenaSceneNavigation uiArenaSceneNavigation)
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
