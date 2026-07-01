using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	public class UISimulationFeatureView : MonoBehaviour
	{
		[SerializeField]
		private UISimulationFeatureElement _uiSimulationFeaturePrefab;

		public void Construct(List<FeatureItem> features)
		{
		}
	}
}
