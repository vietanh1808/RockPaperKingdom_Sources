using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationCurveTitleView : MonoBehaviour
	{
		[SerializeField]
		private UISimulationCurveTitleElement _uiSimulationCurveTitleElement;

		[SerializeField]
		private Button _toggleStrategiesButton;

		private readonly List<UISimulationCurveTitleElement> _titleElements;

		private bool _strategiesVisible;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Clear()
		{
		}

		public void AddTitle(SimulationCurveData curveData, Color color, UISimulationCurveRenderer curve)
		{
		}

		private void ToggleStrategies()
		{
		}
	}
}
