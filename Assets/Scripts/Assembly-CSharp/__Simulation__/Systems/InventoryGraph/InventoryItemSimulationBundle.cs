using System;
using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.InventoryGraph
{
	[Serializable]
	public class InventoryItemSimulationBundle
	{
		[SerializeField]
		private string _title;

		[SerializeField]
		private List<InventoryItemData> _items;

		public string Title => null;

		public List<InventoryItemData> Items => null;
	}
}
