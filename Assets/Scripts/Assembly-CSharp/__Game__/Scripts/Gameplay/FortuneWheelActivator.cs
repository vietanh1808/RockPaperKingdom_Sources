using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class FortuneWheelActivator : MonoBehaviour
	{
		private BaseUnit _unit;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDiedHandler()
		{
		}
	}
}
