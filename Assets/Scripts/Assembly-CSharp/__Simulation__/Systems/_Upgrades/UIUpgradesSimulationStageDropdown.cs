using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UIUpgradesSimulationStageDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _modeDropdown;

		private UpgradesSimulationSystem _upgradesSimulationSystem;

		private UpgradesSimulationWaveByStageGraphSystem _upgradesSimulationWaveByStageGraphSystem;

		private UIWaveSimulationGraphView _uiWaveSimulationGraphView;

		[Inject]
		private void Inject(UpgradesSimulationSystem upgradesSimulationSystem, UpgradesSimulationWaveByStageGraphSystem upgradesSimulationWaveByStageGraphSystem, UIWaveSimulationGraphView uiWaveSimulationGraphView)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSimulationFinished()
		{
		}

		private void PopulateDropdown()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDropdownModeChanged(int index)
		{
		}
	}
}
