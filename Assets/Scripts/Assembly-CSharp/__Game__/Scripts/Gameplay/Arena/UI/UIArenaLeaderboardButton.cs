using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaLeaderboardButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		private void Inject(UIMenuSceneNavigation uiMenuSceneNavigation)
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
