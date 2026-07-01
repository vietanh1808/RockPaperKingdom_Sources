using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.EquipmentGraph
{
	public class UISimulationEquipmentGraphView : MonoBehaviour
	{
		[SerializeField]
		private UISimulationEquipmentElement _uiSimulationEquipmentPrefab;

		[SerializeField]
		private RectTransform _graphContainer;

		private GameSimulationSystem _gameSimulationSystem;

		private RarityConfig _rarityConfig;

		[Inject]
		private void Inject(GameSimulationSystem gameSimulationSystem, RarityConfig rarityConfig)
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

		private void DrawAllElements()
		{
		}

		private void AddElement(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
