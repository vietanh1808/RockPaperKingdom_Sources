using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Simulation__.Systems.SimulationCurve
{
	[Serializable]
	public class SimulationCurveData
	{
		public string Title;

		public Color Color;

		public bool IsOverlay;

		public List<SimulationCurvePointData> Points;

		public Vector3[] GetPositions()
		{
			return null;
		}
	}
}
