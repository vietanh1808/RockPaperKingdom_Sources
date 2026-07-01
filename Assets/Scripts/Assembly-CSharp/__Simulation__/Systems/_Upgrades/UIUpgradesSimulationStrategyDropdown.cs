using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UIUpgradesSimulationStrategyDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _modeDropdown;

		private UpgradesSimulationSystem _upgradesSimulationSystem;

		private UpgradesSimulationStageByStrategyGraphSystem _upgradesSimulationStageByStrategyGraphSystem;

		[Inject]
		private void Inject(UpgradesSimulationSystem upgradesSimulationSystem, UpgradesSimulationStageByStrategyGraphSystem upgradesSimulationStageByStrategyGraphSystem)
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
