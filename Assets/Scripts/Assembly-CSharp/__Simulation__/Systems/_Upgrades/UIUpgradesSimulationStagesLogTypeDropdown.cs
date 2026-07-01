using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UIUpgradesSimulationStagesLogTypeDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _modeDropdown;

		private UpgradesSimulationStageByStrategyGraphSystem _upgradesSimulationStageByStrategyGraphSystem;

		[Inject]
		private void Inject(UpgradesSimulationStageByStrategyGraphSystem upgradesSimulationStageByStrategyGraphSystem)
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
