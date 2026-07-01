using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.MysteryCardShop
{
	public class UIMysteryCardShopButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation)
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
