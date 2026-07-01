using UnityEngine;
using Zenject;
using __Simulation__.SimulationModules;
using __Simulation__.Systems;
using __Simulation__.Systems.ExperienceGraph;
using __Simulation__.Systems.InventoryGraph;

namespace __Simulation__.Infrastructure
{
	public class SimulationSceneInstaller : MonoInstaller
	{
		[Header("Configs")]
		[SerializeField]
		private SimulationConfig _simulationConfig;

		[SerializeField]
		private OpenChestModuleConfig _openChestModuleConfig;

		[Header("UI")]
		[SerializeField]
		private UISimulationGraphView _uiSimulationGraphView;

		[SerializeField]
		private UISimulationInventoryGraphView _inventoryGraphView;

		[SerializeField]
		private UISimulationExperienceGraphView _experienceGraphView;

		[SerializeField]
		private UISimulationPlayerUpgradesGraphView _playerUpgradesGraphView;

		[Header("Prefabs")]
		[SerializeField]
		private UISimulationGraphElement _simulationGraphElementPrefab;

		public override void InstallBindings()
		{
		}
	}
}
