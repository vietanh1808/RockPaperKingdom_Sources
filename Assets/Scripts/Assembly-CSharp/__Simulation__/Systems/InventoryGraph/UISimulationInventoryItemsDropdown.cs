using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems.InventoryGraph
{
	public class UISimulationInventoryItemsDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _inventoryDropdown;

		private SimulationInventoryGraphSystem _inventoryGraphSystem;

		private SimulationConfig _simulationConfig;

		[Inject]
		private void Inject(SimulationConfig simulationConfig, SimulationInventoryGraphSystem inventoryGraphSystem)
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

		private void Initialize()
		{
		}

		private void OnDropdownItemChanged(int index)
		{
		}
	}
}
