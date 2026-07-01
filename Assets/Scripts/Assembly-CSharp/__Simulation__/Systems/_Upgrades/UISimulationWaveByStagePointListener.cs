using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Simulation__.Systems.SimulationCurve;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationWaveByStagePointListener : MonoBehaviour
	{
		[SerializeField]
		private Canvas _rootCanvas;

		[SerializeField]
		private UISimulationWaveByStageUpgradesPopup _uiSimulationWaveByStageUpgradesPopup;

		private readonly Dictionary<string, StrategyLog> _stagesByStrategy;

		private UpgradesSimulationSystem _upgradesSimulationSystem;

		private UpgradesSimulationWaveByStageGraphSystem _upgradesSimulationWaveByStageGraphSystem;

		private UISimulationWaveByStageGraphView _uiSimulationWaveByStageGraphView;

		[Inject]
		private void Inject(UpgradesSimulationSystem upgradesSimulationSystem, UpgradesSimulationWaveByStageGraphSystem upgradesSimulationWaveByStageGraphSystem, UISimulationWaveByStageGraphView uiSimulationWaveByStageGraphView)
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

		private void OnSimulationCurvePointEntered(UISimulationCurvePoint uiSimulationCurvePoint)
		{
		}

		private void OnSimulationCurvePointExited()
		{
		}

		private Vector2 GetPopupPosition(UISimulationCurvePoint uiSimulationCurvePoint, RectTransform popupTransform)
		{
			return default(Vector2);
		}
	}
}
