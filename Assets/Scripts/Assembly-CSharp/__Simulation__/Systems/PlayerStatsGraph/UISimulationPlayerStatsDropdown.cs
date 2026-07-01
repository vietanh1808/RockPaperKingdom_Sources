using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems.PlayerStatsGraph
{
	public class UISimulationPlayerStatsDropdown : MonoBehaviour
	{
		private const int TOTAL_POWER_INDEX = 0;

		private const int CASTLE_HP_INDEX = 1;

		private const int HP_MULTIPLIER_INDEX = 2;

		private const int DMG_MULTIPLIER_INDEX = 3;

		[SerializeField]
		private TMP_Dropdown _dropdown;

		private SimulationPlayerStatsGraphSystem _playerStatsGraphSystem;

		[Inject]
		private void Inject(SimulationPlayerStatsGraphSystem playerStatsGraphSystem)
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
