using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationCsvReportDropdown : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown _csvReportDropdown;

		private UpgradesSimulationConfig _config;

		private readonly List<string> _csvFilePaths;

		public event Action<string> OnCsvReportSelected
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

		[Inject]
		private void Inject(UpgradesSimulationConfig config)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void RefreshFileList()
		{
		}

		public string GetLatestFilePath()
		{
			return null;
		}

		private void OnDropdownValueChanged(int index)
		{
		}
	}
}
