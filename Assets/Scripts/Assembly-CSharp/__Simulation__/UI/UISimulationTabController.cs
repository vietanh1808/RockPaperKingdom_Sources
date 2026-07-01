using System.Collections.Generic;
using UnityEngine;

namespace __Simulation__.UI
{
	public class UISimulationTabController : MonoBehaviour
	{
		[SerializeField]
		private List<UISimulationTabButton> _tabButtons;

		private UISimulationTabButton _previousTabButton;

		private void Start()
		{
		}

		private void OnTabActivated(UISimulationTabButton tabButton)
		{
		}
	}
}
