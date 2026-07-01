using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services.Analytics
{
	public class EconomyEventData
	{
		public string TransactionName { get; }

		public string Placement { get; }

		public List<IInventoryItemHolder> Spent { get; }

		public EconomyEventData(string transactionName, string placement, List<IInventoryItemHolder> spent = null)
		{
		}

		public EconomyEventData(string transactionName, string placement, List<PriceData> spent)
		{
		}
	}
}
