using UnityEngine;
using UnityEngine.UI;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationDisplayNumbersToggle : MonoBehaviour
	{
		[SerializeField]
		private UISimulationCurveView _uiSimulationCurveView;

		[SerializeField]
		private Toggle _toggle;

		private void Start()
		{
		}

		private void OnToggleValueChanged(bool isOn)
		{
		}
	}
}
