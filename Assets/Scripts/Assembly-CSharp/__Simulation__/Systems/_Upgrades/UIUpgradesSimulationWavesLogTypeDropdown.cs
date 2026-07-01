using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UIUpgradesSimulationWavesLogTypeDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _modeDropdown;

		private UpgradesSimulationWaveByStageGraphSystem _upgradesSimulationWaveByStageGraphSystem;

		[Inject]
		private void Inject(UpgradesSimulationWaveByStageGraphSystem upgradesSimulationWaveByStageGraphSystem)
		{
		}

		private void Start()
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
