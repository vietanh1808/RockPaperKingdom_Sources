using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems.InventoryGraph
{
	public class UISimulationGraphModeDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _modeDropdown;

		private SimulationInventoryGraphSystem _inventoryGraphSystem;

		[Inject]
		private void Inject(SimulationInventoryGraphSystem inventoryGraphSystem)
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

		private void OnDropdownModeChanged(int index)
		{
		}
	}
}
