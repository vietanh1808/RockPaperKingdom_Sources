using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	[Serializable]
	public class SimulationCsvExportConfig
	{
		[SerializeField]
		private bool _autoExportAfterSimulation;

		[SerializeField]
		private string _exportFolderPath;

		[SerializeField]
		private List<InventoryItemData> _inventoryItems;

		public bool AutoExportAfterSimulation => false;

		public string ExportFolderPath => null;

		public List<InventoryItemData> InventoryItems => null;
	}
}
