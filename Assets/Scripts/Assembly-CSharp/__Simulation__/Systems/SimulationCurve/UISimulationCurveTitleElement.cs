using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationCurveTitleElement : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private Toggle _toggle;

		private UISimulationCurveRenderer _curve;

		public bool IsOverlay { get; private set; }

		public void Construct(string title, Color color, UISimulationCurveRenderer curve, bool isOverlay)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		private void OnToggleValueChanged(bool isOn)
		{
		}
	}
}
