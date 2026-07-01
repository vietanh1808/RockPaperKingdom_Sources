using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIHomePanel : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _playButton;

		[Header("Energy")]
		[SerializeField]
		private TMP_Text _sessionPrice;

		[SerializeField]
		private Image _energyIcon;

		private GameStateMachine _gameStateMachine;

		private EnergySystem _energySystem;

		private StageSystem _stageSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		public void Inject(GameStateMachine gameStateMachine, EnergySystem energySystem, StageSystem stageSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSelectedIndexChanged()
		{
		}

		private void OnEnergyChanged(int amount)
		{
		}

		private void RefreshPlayButtonAvailable()
		{
		}

		private void PlayButtonClicked()
		{
		}
	}
}
