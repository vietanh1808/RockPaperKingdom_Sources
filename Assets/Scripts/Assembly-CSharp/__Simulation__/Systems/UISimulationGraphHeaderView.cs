using UnityEngine;

namespace __Simulation__.Systems
{
	public class UISimulationGraphHeaderView : MonoBehaviour
	{
		[SerializeField]
		private UISimulationLevelElement _uiSimulationLevelPrefab;

		[SerializeField]
		private UISimulationFeatureView _uiSimulationFeaturePrefab;

		private int _previousPlayerLevel;

		public void SetupElement(SimulationSnapshot simulationSnapshot, Transform parent)
		{
		}

		private void AddPlayerLevelElement(SimulationSnapshot simulationSnapshot, Transform parent)
		{
		}

		private void AddFeatureUnlockElement(SimulationSnapshot simulationSnapshot, Transform parent)
		{
		}
	}
}
