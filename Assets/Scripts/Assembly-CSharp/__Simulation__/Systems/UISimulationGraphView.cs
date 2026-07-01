using UnityEngine;
using Zenject;

namespace __Simulation__.Systems
{
	public class UISimulationGraphView : MonoBehaviour
	{
		[Header("Graph Elements")]
		[SerializeField]
		private RectTransform _graphContainer;

		[SerializeField]
		private RectTransform _curveContainer;

		[Header("Header")]
		[SerializeField]
		private UISimulationGraphHeaderView _uiSimulationGraphHeaderView;

		private GameSimulationSystem _gameSimulationSystem;

		private UISimulationGraphElement _graphElementPrefab;

		private int _currentDay;

		private int _currentSession;

		public float GraphHeight => 0f;

		[Inject]
		private void Inject(GameSimulationSystem gameSimulationSystem, UISimulationGraphElement graphElementPrefab)
		{
		}

		private void Start()
		{
		}

		private void SetupSnapshotElements()
		{
		}

		private void SetupGraphElement(SimulationSnapshot simulationSnapshot, int index)
		{
		}

		private void DisplayTimeShift(SimulationSnapshot simulationSnapshot, UISimulationGraphElement uiElementInstance)
		{
		}
	}
}
