using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpeedUpGameplaySwitcherActivator : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _switcherButtonClick;

		private GameplayDebugSettings _gameplayDebugSettings;

		private SpeedUpPurchaseSystem _speedUpPurchaseSystem;

		[Inject]
		private void Inject(GameplayDebugSettings gameplayDebugSettings, SpeedUpPurchaseSystem speedUpPurchaseSystem)
		{
		}

		private void Start()
		{
		}
	}
}
