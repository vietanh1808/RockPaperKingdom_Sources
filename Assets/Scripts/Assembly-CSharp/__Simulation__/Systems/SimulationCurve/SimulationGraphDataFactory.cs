using System.Collections.Generic;
using __Game__.Scripts.Systems;
using __Simulation__.Systems.InventoryGraph;

namespace __Simulation__.Systems.SimulationCurve
{
	public class SimulationGraphDataFactory
	{
		private readonly GameSimulationSystem _gameSimulationSystem;

		public SimulationGraphDataFactory(GameSimulationSystem gameSimulationSystem)
		{
		}

		public SimulationCurveGraphData GetGraphData(InventorySimulationMode mode, InventoryItemData inventoryItemData, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		public SimulationCurveGraphData GetGraphData(InventorySimulationMode mode, InventoryItemSimulationBundle inventoryItemBundle, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		private SimulationCurveGraphData GetGraphData(List<InventoryItemSnapshot> inventorySnapshots, InventorySimulationMode mode, float snapshotWidth, float containerHeight)
		{
			return null;
		}

		private List<SimulationCurveData> GetCurveListByMode(InventorySimulationMode mode, List<InventoryItemSnapshot> inventorySnapshots)
		{
			return null;
		}

		private List<SimulationCurveData> GetTotalsCurves(List<InventoryItemSnapshot> inventorySnapshots)
		{
			return null;
		}

		private List<SimulationCurveData> GetSourcesCurves(List<InventoryItemSnapshot> inventorySnapshots)
		{
			return null;
		}

		private List<SimulationCurveData> GetSinkCurves(List<InventoryItemSnapshot> inventorySnapshots)
		{
			return null;
		}

		private List<InventoryItemSnapshot> GetInventoryItemSnapshots(InventoryItemData inventoryItemData)
		{
			return null;
		}

		private List<InventoryItemSnapshot> GetInventoryItemBundleSnapshots(InventoryItemSimulationBundle itemBundle)
		{
			return null;
		}

		private int GetMaxValue(List<InventoryItemSnapshot> inventorySnapshots)
		{
			return 0;
		}
	}
}
