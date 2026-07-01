using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.UnitsGraph
{
	public class UISimulationHeroGraphView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _graphContainer;

		[SerializeField]
		private UISimulationHeroUpgradeSnapshot _uiSimulationHeroPrefab;

		private GameSimulationSystem _gameSimulationSystem;

		private HeroConfig _heroConfig;

		[Inject]
		private void Inject(GameSimulationSystem gameSimulationSystem, HeroConfig heroConfig)
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
