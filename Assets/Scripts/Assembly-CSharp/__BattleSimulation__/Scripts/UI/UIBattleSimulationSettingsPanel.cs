using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationSettingsPanel : MonoBehaviour
	{
		[SerializeField]
		private UISliderElement _combatSpeedSlider;

		[SerializeField]
		private UIButtonClick _attackerUnitsButtonClick;

		[SerializeField]
		private UIButtonClick _defenderUnitsButtonClick;

		[SerializeField]
		private UIButtonClick _unitStatsButtonClick;

		[SerializeField]
		private UIButtonClick _closeButtonClick;

		private BattleSimulationSystem _battleSimulationSystem;

		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		[Inject]
		private void Inject(BattleSimulationSystem battleSimulationSystem, UIBattleSimulationSceneNavigation uiBattleSimulationSceneNavigation)
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

		private void OnCombatSpeedChanged(float value)
		{
		}

		private void OnAttackerUnitsButtonHandler()
		{
		}

		private void OnDefenderUnitsButtonHandler()
		{
		}

		private void OnUnitStatsButtonHandler()
		{
		}

		private void OnCloseButtonHandler()
		{
		}
	}
}
