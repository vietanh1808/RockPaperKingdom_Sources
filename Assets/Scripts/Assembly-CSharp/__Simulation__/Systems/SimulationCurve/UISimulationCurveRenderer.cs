using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationCurveRenderer : MonoBehaviour
	{
		private const float OVERLAY_WIDTH_MULTIPLIER = 2f;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private UISimulationCurvePoint _pointPrefab;

		private readonly List<UISimulationCurvePoint> _points;

		public event Action<UISimulationCurvePoint> OnPointPointerEntered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnPointPointerExited
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void DrawCurve(SimulationCurveData curveData, Color color)
		{
		}

		public void ApplySorting(int order, bool addRaycaster)
		{
		}

		public void ApplyOverlayLineWidth()
		{
		}

		public void ShowNumbers(bool isOn)
		{
		}

		private void DrawLines(SimulationCurveData curveData, Color color)
		{
		}

		private void DrawPoints(SimulationCurveData curveData, Color color)
		{
		}

		private void OnPointEntered(UISimulationCurvePoint point)
		{
		}

		private void OnPointExited()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
