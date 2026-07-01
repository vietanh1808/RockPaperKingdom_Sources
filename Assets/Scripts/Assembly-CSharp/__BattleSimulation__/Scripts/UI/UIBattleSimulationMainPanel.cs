using UnityEngine;
using Zenject;
using __BattleSimulation__.Scripts.Controllers;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationMainPanel : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _settingsButtonClick;

		[SerializeField]
		private UIButtonClick _playButtonClick;

		[SerializeField]
		private UIButtonClick _stopButtonClick;

		[SerializeField]
		private UIBattleSimulationHpTracker _hpTracker;

		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		private BattleSimulationController _simulationController;

		[Inject]
		private void Inject(UIBattleSimulationSceneNavigation uiBattleSimulationSceneNavigation, BattleSimulationController simulationController)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSettingsButtonHandler()
		{
		}

		private void OnPlayButtonHandler()
		{
		}

		private void OnStopButtonHandler()
		{
		}

		private void UpdateButtonStates()
		{
		}
	}
}
