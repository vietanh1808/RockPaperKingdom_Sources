using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Gameplay.UI
{
	public class UIGameplayAlertGlow : MonoBehaviour
	{
		[SerializeField]
		private Image _alertGlow;

		private GameplayDangerousTracker _dangerousTracker;

		[Inject]
		private void Inject(GameplayDangerousTracker dangerousTracker)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDangerousStatusChanged()
		{
		}

		private void UpdateGlowState(bool isActive)
		{
		}
	}
}
