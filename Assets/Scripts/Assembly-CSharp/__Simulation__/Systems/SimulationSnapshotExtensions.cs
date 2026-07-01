using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems
{
	public static class SimulationSnapshotExtensions
	{
		public static void AddReward(this SimulationSnapshot snapshot, string type, Reward reward)
		{
		}

		public static void AddRewards(this SimulationSnapshot snapshot, string type, List<Reward> rewards)
		{
		}

		public static void RemoveInventoryItem(this SimulationSnapshot snapshot, string type, PriceData price)
		{
		}

		public static void RemoveInventoryItems(this SimulationSnapshot snapshot, string type, List<PriceData> prices)
		{
		}

		private static void AddItem(this InventoryItemSnapshot itemSnapshot, string type, int amount)
		{
		}

		private static void RemoveItem(this InventoryItemSnapshot itemSnapshot, string type, int amount)
		{
		}

		private static void AddToDictionary(Dictionary<string, int> dictionary, string type, int amount)
		{
		}
	}
}
