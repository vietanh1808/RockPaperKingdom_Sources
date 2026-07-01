using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UIWaveSimulationGraphView : MonoBehaviour
	{
		[Header("Graph Elements")]
		[SerializeField]
		private RectTransform _graphContainer;

		[SerializeField]
		private RectTransform _curveContainer;

		private readonly List<GameObject> _uiElements;

		private UpgradesSimulationSystem _upgradesSimulationSystem;

		private UIWaveSimulationGraphElement _uiWaveSimulationGraphElement;

		public float GraphHeight => 0f;

		[Inject]
		private void Inject(UpgradesSimulationSystem upgradesSimulationSystem, UIWaveSimulationGraphElement uiWaveSimulationGraphElement)
		{
		}

		private void Start()
		{
		}

		private void OnSimulationFinished()
		{
		}

		public void CreateAllElementsByStage(int stageIndex)
		{
		}

		private int GetWavesCount(int stageIndex)
		{
			return 0;
		}

		private void RemoveAllElements()
		{
		}
	}
}
