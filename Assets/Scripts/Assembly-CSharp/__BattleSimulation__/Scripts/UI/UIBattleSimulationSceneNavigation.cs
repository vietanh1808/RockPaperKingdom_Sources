using UnityEngine;
using Zenject;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationSceneNavigation : MonoBehaviour
	{
		[SerializeField]
		private UIBattleSimulationMainPanel _uiBattleSimulationMainPanel;

		[SerializeField]
		private UIBattleSimulationSettingsPanel _uiBattleSimulationSettingsPanel;

		[SerializeField]
		private UIBattleSimulationUnitAmountPanel _uiBattleSimulationUnitAmountPanel;

		[SerializeField]
		private UIBattleSimulationUnitSelectPanel _uiBattleSimulationUnitSelectPanel;

		[SerializeField]
		private UIBattleSimulationUnitStatsPanel _uiBattleSimulationUnitStatsPanel;

		private BattleSimulationSystem _battleSimulationSystem;

		[Inject]
		private void Inject(BattleSimulationSystem battleSimulationSystem)
		{
		}

		public void OpenSettingsPanel()
		{
		}

		public void CloseSettingsPanel()
		{
		}

		public void OpenAttackerUnitsPanel()
		{
		}

		public void OpenDefenderUnitsPanel()
		{
		}

		public void CloseUnitAmountPanel()
		{
		}

		public void OpenUnitSelectPanel()
		{
		}

		public void CloseUnitSelectPanel()
		{
		}

		public void OpenUnitStatsPanel(string title, UnitBattleSimulationStats unitBattleSimulationStats, UnitBattleSimulationData unitBattleSimulationData)
		{
		}

		public void CloseUnitStatsPanel(bool unused)
		{
		}

		public void CloseAllPanels()
		{
		}
	}
}
