using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationCurveView : MonoBehaviour
	{
		[SerializeField]
		private UISimulationCurveRenderer _simulationCurveRenderer;

		private readonly List<UISimulationCurveRenderer> _curveRenderers;

		private bool _showNumbers;

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

		public void Clear()
		{
		}

		public UISimulationCurveRenderer AddCurve(SimulationCurveData curveData, Color color)
		{
			return null;
		}

		public void ShowNumbers(bool isOn)
		{
		}

		private void OnRendererPointEntered(UISimulationCurvePoint point)
		{
		}

		private void OnRendererPointExited()
		{
		}
	}
}
