using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace __Simulation__.Systems.SimulationCurve
{
	public abstract class BaseUISimulationGraphView : MonoBehaviour
	{
		[Header("Graph")]
		[SerializeField]
		private UISimulationCurveView _curveView;

		[SerializeField]
		private UISimulationCurveTitleView _titleView;

		[Header("Left")]
		[SerializeField]
		private TMP_Text _maxValue;

		[SerializeField]
		private TMP_Text _middleValue;

		[Header("Colors")]
		[SerializeField]
		private List<Color> _colors;

		private int _colorIndex;

		public UISimulationCurveView CurveView => null;

		protected void RefreshGraph(SimulationCurveGraphData graphData)
		{
		}

		private void ClearGraph()
		{
		}

		private void DrawGraphData(SimulationCurveGraphData graphData)
		{
		}

		private void RefreshMaxValue(float maxValue)
		{
		}

		private Color GetColor(SimulationCurveData curveData)
		{
			return default(Color);
		}
	}
}
