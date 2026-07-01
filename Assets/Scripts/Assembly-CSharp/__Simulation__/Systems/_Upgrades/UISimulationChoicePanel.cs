using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationChoicePanel : MonoBehaviour
	{
		[SerializeField]
		private Button _runSimulationButton;

		[SerializeField]
		private Button _loadCsvButton;

		[SerializeField]
		private UISimulationCsvReportDropdown _csvReportDropdown;

		public event Action OnRunSimulation
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

		public event Action<string> OnLoadCsvFile
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void HandleRunSimulation()
		{
		}

		private void HandleLoadCsv()
		{
		}

		private void HandleCsvReportSelected(string filePath)
		{
		}
	}
}
