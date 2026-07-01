using System.Collections.Generic;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class InventorySystem : DirtySaveLoadProvider
	{
		public Dictionary<string, InventoryItem> Items { get; }

		public bool HasEnoughItems(List<PriceData> price)
		{
			return false;
		}

		public bool HasEnoughItems(PriceData price)
		{
			return false;
		}

		public InventoryItem GetItem(string guid)
		{
			return null;
		}

		public void AddAmount(string guid, int amount)
		{
		}

		public void RemoveAmount(List<PriceData> itemAmountList)
		{
		}

		public void RemoveAmount(PriceData itemAmount)
		{
		}

		public void RemoveAmount(string guid, int amount)
		{
		}

		public void SetAmount(string guid, int amount)
		{
		}
	}
}
